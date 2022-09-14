using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяРаботаSQL
{
    public partial class Возврат : Form
    {
        bool insertReturn = false; //если не добавление, то обновление
        bool insertReturnList = false;
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public Возврат(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void Возврат_Load(object sender, EventArgs e)
        {
            //-----------ВОЗВРАТ----------------------------------------------------------------
            //Подключение таблицы к возврату
            TableВозврат.DataSource = MainForm.возвратBindingSource;
            //Подключение биндинга
            NavigatorВозврат.BindingSource = MainForm.возвратBindingSource;

            //подключение к полю со списком фио клиента
            ФИОCB.DataSource = MainForm.клиентыCBBindingSource1;
            ФИОCB.DisplayMember = "ФИО_клиента";
            ФИОCB.ValueMember = "Код_клиента";

            //подключение к чек боксу статус возврата
            Статус.DataBindings.Add("Checked", MainForm.возвратBindingSource, "Статус_возврата",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к полю даты возврата
            ДатаTB.DataBindings.Add("Text", MainForm.возвратBindingSource, "Дата_возврата",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableВозврат.AutoResizeColumns();
            TableВозврат.Columns[0].Visible = false; //код возврата
            TableВозврат.Columns[2].Visible = false; // код_товара

            //----------СПИСОК ТОВАРОВ НА ВОЗВРАТ---------------------------------------------------------
            //подключение таблицы и биндинга списка
            TableСписокВозврат.DataSource = MainForm.списокВозвратBindingSource;
            NavigatorСписокВозврат.BindingSource = MainForm.списокВозвратBindingSource;

            //подключение к полю со списком товаров
            НаименованиеCB.DataSource = MainForm.ТоварыCBbindingSource2;
            НаименованиеCB.DisplayMember = "Наименование_товара";
            НаименованиеCB.ValueMember = "Код_товара";

            //Подключение к полю причина возврата
            ПричинаTB.DataBindings.Add("Text", MainForm.списокВозвратBindingSource, "Причина_возврата",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к полю количество товара на возврат
            КоличествоTB.DataBindings.Add("Text", MainForm.списокВозвратBindingSource, "Количество_на_возврат",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableСписокВозврат.Columns[0].Visible = false;
            TableСписокВозврат.Columns[1].Visible = false;
            TableСписокВозврат.Columns[3].Visible = false;
            TableСписокВозврат.AutoResizeColumns();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {//Добавить возврат
            try
            {
                insertReturn = true;
                MainForm.возвратBindingSource.AddNew();
                TableВозврат.Rows[TableВозврат.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//удалить возврат
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.возвратBindingSource.Current;
                id = (int)dt["Код_возврата"];
                MainForm.StoredProcedures.Delete_Возврат(id);
                MainForm.возвратTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Возврат_View);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно удалить, в документе имеются товары на возврат", "Предупреждение об ошибке");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//обновить возврат
            if (insertReturn)
            {
                if (ФИОCB.Text != "" && ДатаTB.Text != "")
                {
                    int id;
                    DataRowView dt;

                    dt = (DataRowView)MainForm.клиентыCBBindingSource1.Current;
                    id = (int)dt["Код_клиента"];

                    MainForm.StoredProcedures.Insert_Возврат(Convert.ToDateTime(ДатаTB.Text), id,
                        Статус.Checked);
                    insertReturn = false;
                }
            }
            else
            {
                //обновление данных
                if (ФИОCB.Text != "" && ДатаTB.Text != "")
                {
                    int id_client;
                    DataRowView dt;

                    dt = (DataRowView)MainForm.клиентыCBBindingSource1.Current;
                    id_client = (int)dt["Код_клиента"];

                    int id;
                    dt = (DataRowView)MainForm.возвратBindingSource.Current;
                    id = (int)dt["Код_возврата"];

                    MainForm.StoredProcedures.Update_Возрат(id, Convert.ToDateTime(ДатаTB.Text), id_client,
                        Статус.Checked);
                }
            }
            MainForm.возвратTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Возврат_View);
            TableВозврат.AutoResizeColumns();
        }

        private void ButtonAdd1_Click(object sender, EventArgs e)
        {//добавить товар на возврат
            try
            {
                insertReturnList = true;
                MainForm.списокВозвратBindingSource.AddNew();
                TableСписокВозврат.Rows[TableСписокВозврат.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete1_Click(object sender, EventArgs e)
        {//Удалить товар из возврата
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.списокВозвратBindingSource.Current;
                id = (int)dt["Код"];

                MainForm.StoredProcedures.Delete_СписокВозврат(id);
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
                MainForm.списокВозвратTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.СписокВозврат_View);
            }
            catch (Exception ex)
            {
                string msg = ex.Message.Split('.')[0];
                MessageBox.Show(String.Format("Проверьте данные! Ошибка: {0}", msg), "Предупреждение об ошибке");
            }
        }

        private void ButtonUpdate1_Click(object sender, EventArgs e)
        {//обновить товар на возврат
            try
            {
                if (insertReturnList)
                {
                    if (НаименованиеCB.Text != "" && КоличествоTB.Text != "" && ПричинаTB.Text != "")
                    {
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.возвратBindingSource.Current;
                        id = (int)dt["Код_возврата"];

                        int id_pr;
                        dt = (DataRowView)MainForm.ТоварыCBbindingSource2.Current;
                        id_pr = (int)dt["Код_товара"];

                        MainForm.StoredProcedures.Insert_СписокВозврат(id_pr, id, ПричинаTB.Text,
                            Convert.ToInt32(КоличествоTB.Text));
                        insertReturnList = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (НаименованиеCB.Text != "" && КоличествоTB.Text != "" && ПричинаTB.Text != "")
                    {
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.возвратBindingSource.Current;
                        id = (int)dt["Код_возврата"];

                        int id_pr;
                        dt = (DataRowView)MainForm.ТоварыCBbindingSource2.Current;
                        id_pr = (int)dt["Код_товара"];

                        int id_return;
                        dt = (DataRowView)MainForm.списокВозвратBindingSource.Current;
                        id_return = (int)dt["Код"];

                        MainForm.StoredProcedures.Update_СписокВозврат(id_return, id_pr, id,
                            ПричинаTB.Text, Convert.ToInt32(КоличествоTB.Text));
                    }
                }
                MainForm.списокВозвратTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.СписокВозврат_View);
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
                TableСписокВозврат.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                string msg = ex.Message.Split('.')[0];
                MessageBox.Show(String.Format("Проверьте данные! Ошибка: {0}", msg), "Предупреждение об ошибке");
            }
        }

        private void TableВозврат_SelectionChanged(object sender, EventArgs e)
        {//для таблицы возврат
            try
            {

                //для того, чтобы высветить список товаров на конкретной реализации
                int id;
                DataRowView dt = (DataRowView)MainForm.возвратBindingSource.Current;
                if (dt != null)
                {
                    try
                    {
                        id = (int)dt["Код_возврата"];
                        MainForm.списокВозвратBindingSource.Filter = "[Код_возврата] =" + id;
                    }
                    catch { }

                    //Чтобы высветить в комбо бокс имя клиента
                    int id_client;
                    id_client = (int)dt["Код_клиента"];
                    ФИОCB.SelectedValue = id_client;
                }
            }
            catch
            {

            }
        }

        private void TableСписокВозврат_SelectionChanged(object sender, EventArgs e)
        {
            //для таблицы списка товаров на возврат
            try
            {
                //для того, чтобы высветить список товаров на конкретной реализации
                int id;
                DataRowView dt = (DataRowView)MainForm.списокВозвратBindingSource.Current;
                if (dt != null)
                {
                    id = (int)dt["Артикул_товара"];
                    НаименованиеCB.SelectedValue = id;
                }
            }
            catch
            {

            }
            TableСписокВозврат.AutoResizeColumns();
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            //применить фильтр
            bool result = MainForm.RunFilter(MainForm.возвратBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            //отменить фильтр
            bool result = MainForm.RunFilter(MainForm.возвратBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterAccept1_Click(object sender, EventArgs e)
        {
            //применить фильтр
            string OldFilter = MainForm.возвратBindingSource.Filter;
            bool result = MainForm.RunFilter(MainForm.возвратBindingSource, ValueTB1.Text, FieldCB1.Text);
            if (!result)
            {
                TableВозврат_SelectionChanged(sender, e);
                MessageBox.Show("Ошибка запроса");
            }
            else
            {
                MainForm.возвратBindingSource.Filter += " AND " + OldFilter;
            }
        }

        private void FilterCancel1_Click(object sender, EventArgs e)
        {
            //отменить фильтр
            TableВозврат_SelectionChanged(sender, e);
        }

        private void TableВозврат_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void TableСписокВозврат_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
