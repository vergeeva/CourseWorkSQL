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
    public partial class Склад : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public Склад(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void Склад_Load(object sender, EventArgs e)
        {
            //подключение биндинга к гриду
            TableСклад.DataSource = MainForm.складBindingSource;
            //подключение биндинга к навигатору
            NavigatorСклад.BindingSource = MainForm.складBindingSource;

            //подключение к комбо боксу
            ТипСкладаCB.DataSource = MainForm.типыСкладаCBBindingSource;
            ТипСкладаCB.DisplayMember = "Тип_склада";
            ТипСкладаCB.ValueMember = "Код_типа";

            //подключение к тестовому полю 
            АдресTB.DataBindings.Add("Text", MainForm.складBindingSource, "Адрес_расположения",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableСклад.AutoResizeColumns();
            TableСклад.Columns[0].Visible = false;
            TableСклад.Columns[1].Visible = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {//Добавить склад
            try
            {
                insert = true;
                MainForm.складBindingSource.AddNew();
                TableСклад.Rows[TableСклад.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//Удалить склад
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.складBindingSource.Current;
                id = (int)dt["Код_склада"];
                MainForm.StoredProcedures.Delete_Склад(id);
                MainForm.складTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Склад_View);
            }
            catch (Exception)
            {
                MessageBox.Show("На складе был приход товаров, нельзя удалить");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//Обновить данные о складе
            try
            {
                if (insert)
                {
                    if (ТипСкладаCB.Text != "" && АдресTB.Text != "")
                    {
                        //добавление товара
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.типыСкладаCBBindingSource.Current;
                        id = (int)dt["Код_типа"];
                        
                        MainForm.StoredProcedures.Insert_Склад(id, АдресTB.Text);
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (ТипСкладаCB.Text != "" && АдресTB.Text != "")
                    {                        
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.складBindingSource.Current;
                        id = (int)dt["Код_склада"];
                        MainForm.StoredProcedures.Update_Склад(id, Convert.ToInt32(ТипСкладаCB.SelectedValue),
                            АдресTB.Text);
                    }
                }
                MainForm.складTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Склад_View);
                TableСклад.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные, проверьте");
            }
        }

        private void TableСклад_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //для того, чтобы высветить список товаров на конкретной реализации
                int id;
                DataRowView dt = (DataRowView)MainForm.складBindingSource.Current;
                if (dt != null)
                {
                    id = (int)dt["Код_типа"];
                    ТипСкладаCB.SelectedValue = id;
                }
            }
            catch
            {

            }
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.складBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.складBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void TableСклад_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
