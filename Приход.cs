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
    public partial class Приход : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public Приход(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void Приход_Load(object sender, EventArgs e)
        {
            //Подключение таблицы к реализации
            TableПриход.DataSource = MainForm.приходBindingSource;
            //Подключение биндинга
            NavigatorПриход.BindingSource = MainForm.приходBindingSource;

            //Подключение к комбо бокусу наименования товара
            ТоварCB.DataSource = MainForm.ТоварыCBbindingSource1;
            ТоварCB.DisplayMember = "Наименование_товара";
            ТоварCB.ValueMember = "Код_товара";

            //Подключение к комбо бокусу адреса склада
            АдресCB.DataSource = MainForm.складBindingSource;
            АдресCB.DisplayMember = "Адрес_расположения";
            АдресCB.ValueMember = "Код_склада";

            //Подключение к тестовому полю количество
            КоличествоTB.DataBindings.Add("Text", MainForm.приходBindingSource, "Количество",
    true, DataSourceUpdateMode.OnPropertyChanged);

            TableПриход.AutoResizeColumns();
            TableПриход.Columns[0].Visible = false;
            TableПриход.Columns[1].Visible = false;
            TableПриход.Columns[2].Visible = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                insert = true;
                MainForm.приходBindingSource.AddNew();
                TableПриход.Rows[TableПриход.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.приходBindingSource.Current;
                id = (int)dt["Код_записи"];
                MainForm.StoredProcedures.Delete_Приход(id);
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить", "Сообщение об ошибке");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (insert)
                {
                    int id_pr;
                    DataRowView dt;
                    dt = (DataRowView)MainForm.ТоварыCBbindingSource1.Current;
                    id_pr = (int)dt["Код_товара"];

                    int id_st;
                    dt = (DataRowView)MainForm.складBindingSource.Current;
                    id_st = (int)dt["Код_склада"];

                    if (ТоварCB.Text != "" && АдресCB.Text != "" && КоличествоTB.Text != "")
                    {
                        //добавление клиента
                        MainForm.StoredProcedures.Insert_Приход(id_pr,
                            id_st, Convert.ToInt32(КоличествоTB.Text));
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (ТоварCB.Text != "" && АдресCB.Text != "" && КоличествоTB.Text != "")
                    {
                        int id_pr;
                        DataRowView dt;
                        dt = (DataRowView)MainForm.ТоварыCBbindingSource1.Current;
                        id_pr = (int)dt["Код_товара"];

                        int id_st;
                        dt = (DataRowView)MainForm.складBindingSource.Current;
                        id_st = (int)dt["Код_склада"];

                        int id;
                        dt = (DataRowView)MainForm.приходBindingSource.Current;
                        id = (int)dt["Код_записи"];
                        MainForm.StoredProcedures.Update_Приход(id, id_pr,
                            id_st, Convert.ToInt32(КоличествоTB.Text));
                    }
                }
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
                TableПриход.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте, все ли сделано и введено верно!", "Сообщение об ошибке");
            }
        }

        private void TableПриход_SelectionChanged(object sender, EventArgs e)
        {
            int id_pr;
            DataRowView dt;
            dt = (DataRowView)MainForm.приходBindingSource.Current;
            if (dt != null)
            {
                id_pr = (int)dt["Артикул_товара"];
                ТоварCB.SelectedValue = id_pr;

                int id_st;
                id_st = (int)dt["Код_склада"];
                АдресCB.SelectedValue = id_st;
            }
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.приходBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.приходBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void TableПриход_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
