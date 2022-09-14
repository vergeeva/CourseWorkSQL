using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяРаботаSQL
{
    public partial class РеализацияТоваров : Form
    {
        bool insertRealize = false; //Для реализации
        bool insertListRealize = false; //Для списка товаров на реализации

        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public РеализацияТоваров(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void РеализацияТоваров_Load(object sender, EventArgs e)
        {
            //-----------РЕАЛИЗАЦИЯ----------------------------------------------------------------
            //Подключение таблицы к реализации
            TableРеализация.DataSource = MainForm.реализацияТоваровBindingSource;
            //Подключение биндинга
            NavigatorРеализация.BindingSource = MainForm.реализацияТоваровBindingSource;

            //подключение к полю со списком фио клиента
            ФИОCB.DataSource = MainForm.клиентыCBBindingSource;
            ФИОCB.DisplayMember = "ФИО_клиента";
            ФИОCB.ValueMember = "Код_клиента";

            //подключение к чек боксу статус доверенности
            Статус.DataBindings.Add("Checked", MainForm.клиентыCBBindingSource, "Статус_доверенности",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к полю даты реализации
            ДатаTB.DataBindings.Add("Text", MainForm.реализацияТоваровBindingSource, "Дата_реализации",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к полю предоплаты
            ПредоплатаTB.DataBindings.Add("Text", MainForm.реализацияТоваровBindingSource, "Предоплата",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к чек боксу оплачено полностью
            Paid.DataBindings.Add("Checked", MainForm.реализацияТоваровBindingSource, "Оплачено_полностью",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableРеализация.AutoResizeColumns();
            TableРеализация.Columns[0].Visible = false;
            TableРеализация.Columns[1].Visible = false;

            //----------СПИСОК ТОВАРОВ НА РЕАЛИЗАЦИИ---------------------------------------------------------
            //подключение таблицы и биндинга списка
            TableСписокРеализация.DataSource = MainForm.списокРеализацияBindingSource;
            NavigatorСписокРеализация.BindingSource = MainForm.списокРеализацияBindingSource;

            //подключение к полю со списком товаров
            НаименованиеCB.DataSource = MainForm.ТоварыCBbindingSource;
            НаименованиеCB.DisplayMember = "Наименование_товара";
            НаименованиеCB.ValueMember = "Код_товара";

            //Подключение к полю цена товара за штуку
            ЦенаTB.DataBindings.Add("Text", MainForm.ТоварыCBbindingSource, "Цена_товара_шт",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к полю количество
            КоличествоTB.DataBindings.Add("Text", MainForm.списокРеализацияBindingSource, "Количество",
                true, DataSourceUpdateMode.OnPropertyChanged);
            TableСписокРеализация.Columns[0].Visible = false;
            TableСписокРеализация.Columns[1].Visible = false;
            TableСписокРеализация.Columns[2].Visible = false;
            TableСписокРеализация.AutoResizeColumns();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {//Добавить реализацию
            try
            {
                insertRealize = true;
                MainForm.реализацияТоваровBindingSource.AddNew();
                TableРеализация.Rows[TableРеализация.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//Удалить из реализации
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.реализацияТоваровBindingSource.Current;
                id = (int)dt["Код_реализации"];
                MainForm.StoredProcedures.Delete_Реализация(id);
                MainForm.реализацияТоваровTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.РеализацияТоваров_View);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно удалить, сначала удалите товары из реализации");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//Сохранить изменения для реализации
            try
            {
                if (insertRealize)
                {
                    if (ФИОCB.Text != "" && ДатаTB.Text != "" && ПредоплатаTB.Text != "")
                    {
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.клиентыCBBindingSource.Current;
                        id = (int)dt["Код_клиента"];
                        
                        MainForm.StoredProcedures.Insert_Реализация(id, Convert.ToDateTime(ДатаTB.Text), 
                            Convert.ToDouble(ПредоплатаTB.Text), Paid.Checked);
                        insertRealize = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (ФИОCB.Text != "" && ДатаTB.Text != "" && ПредоплатаTB.Text != "")
                    {                        
                        int id_client;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.клиентыCBBindingSource.Current;
                        id_client = (int)dt["Код_клиента"];

                        int id;
                        dt = (DataRowView)MainForm.реализацияТоваровBindingSource.Current;
                        id = (int)dt["Код_реализации"];

                        MainForm.StoredProcedures.Update_Реализация(id, id_client, Convert.ToDateTime(ДатаTB.Text),
                            Convert.ToDouble(ПредоплатаTB.Text), Paid.Checked);
                    }
                }
                MainForm.реализацияТоваровTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.РеализацияТоваров_View);
                TableРеализация.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные, они некорректны");
            }
        }

        private void ButtonAdd1_Click(object sender, EventArgs e)
        {//Добавить товар в список реализации
            try
            {
                insertListRealize = true;
                MainForm.списокРеализацияBindingSource.AddNew();
                TableСписокРеализация.Rows[TableСписокРеализация.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные, они некорректны");                
            }
        }

        private void ButtonDelete1_Click(object sender, EventArgs e)
        {//удалить товар из списка реализации
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.списокРеализацияBindingSource.Current;
                id = (int)dt["Код"];

                MainForm.StoredProcedures.Delete_СписокРеализация(id);
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
                MainForm.списокРеализацияTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.СписокРеализация_View);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно удалить");
            }
        }

        private void ButtonUpdate1_Click(object sender, EventArgs e)
        {//Обновить товар в списке реализации
            try
            {
                if (insertListRealize)
                {
                    if (НаименованиеCB.Text != "" && КоличествоTB.Text != "")
                    {
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.реализацияТоваровBindingSource.Current;
                        id = (int)dt["Код_реализации"];

                        int id_pr;
                        dt = (DataRowView)MainForm.ТоварыCBbindingSource.Current;
                        id_pr = (int)dt["Код_товара"];

                        MainForm.StoredProcedures.Insert_СписокРеализация(id, id_pr,
                            Convert.ToInt32(КоличествоTB.Text));
                        insertListRealize = false;
                       
                    }
                }
                else
                {
                    //обновление данных
                    if (ФИОCB.Text != "" && ДатаTB.Text != "" && ПредоплатаTB.Text != "")
                    {
                        int id_pr;
                        DataRowView dt;
                        dt = (DataRowView)MainForm.ТоварыCBbindingSource.Current;
                        id_pr = (int)dt["Код_товара"];

                        int id;
                        dt = (DataRowView)MainForm.списокРеализацияBindingSource.Current;
                        id = (int)dt["Код"];

                        int id_real;

                        dt = (DataRowView)MainForm.реализацияТоваровBindingSource.Current;
                        id_real = (int)dt["Код_реализации"];

                        MainForm.StoredProcedures.Update_ТоварыРеализация(id, id_real, id_pr,
                            Convert.ToInt32(КоличествоTB.Text));
                    }
                }
                MainForm.списокРеализацияTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.СписокРеализация_View);
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
                TableСписокРеализация.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                string msg = ex.Message.Split('.')[0];
                MessageBox.Show(String.Format("Проверьте данные! Ошибка: {0}", msg), "Сообщение об ошибке");
            }
        }

        private void TableРеализация_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                //для того, чтобы высветить список товаров на конкретной реализации
                int id;
                DataRowView dt = (DataRowView)MainForm.реализацияТоваровBindingSource.Current;
                if (dt != null)
                {
                    id = (int)dt["Код_реализации"];
                    MainForm.списокРеализацияBindingSource.Filter = "[Код_реализации] =" + id;

                    ПолнаяСтоимость.Text = MainForm.StoredProcedures.GetSumRealize(id).ToString();

                    //Чтобы высветить в комбо бокс имя клиента
                    int id_client;
                    id_client = (int)dt["Код_клиент"];
                    ФИОCB.SelectedValue = id_client;
                }
            }
            catch
            {
                throw;
            }

        }

        private void TableСписокРеализация_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //для того, чтобы высветить список товаров на конкретной реализации
                int id;
                DataRowView dt = (DataRowView)MainForm.списокРеализацияBindingSource.Current;
                if (dt != null)
                {
                    id = (int)dt["Артикул_товара"];
                    НаименованиеCB.SelectedValue = id;
                }
            }
            catch
            {

            }
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            //применить фильтр
            bool result = MainForm.RunFilter(MainForm.реализацияТоваровBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            //отменить фильтр
            bool result = MainForm.RunFilter(MainForm.реализацияТоваровBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterAccept1_Click(object sender, EventArgs e)
        {//применить фильтр
            string OldFilter = MainForm.списокРеализацияBindingSource.Filter;
            bool result = MainForm.RunFilter(MainForm.списокРеализацияBindingSource, ValueTB1.Text, FieldCB1.Text);
            if (!result)
            {
                TableРеализация_SelectionChanged(sender, e);
                MessageBox.Show("Ошибка запроса");
            }
            else
            {
                MainForm.списокРеализацияBindingSource.Filter += " AND " + OldFilter;
            }
        }

        private void FilterCancel1_Click(object sender, EventArgs e)
        {
            //отменить фильтр
            TableРеализация_SelectionChanged(sender, e);
        }

        private void TableРеализация_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void TableСписокРеализация_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
