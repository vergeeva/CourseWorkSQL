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
    public partial class Скидки : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public Скидки(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {//Добавить
            try
            {
                insert = true;
                MainForm.скидкиBindingSource.AddNew();
                TableСкидки.Rows[TableСкидки.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//Удалить
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.скидкиBindingSource.Current;
                id = (int)dt["Код_скидки"];
                MainForm.StoredProcedures.Delete_Скидки(id);
                MainForm.скидкиTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Скидки_View);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//Обновить
            try
            {
                if (insert)
                {
                    if (СтоимостьTB.Text != "" && СкидкаTB.Text != "")
                    {
                        //добавление скидки
                        MainForm.StoredProcedures.Insert_Скидки(Convert.ToDouble(СтоимостьTB.Text),
                            Convert.ToInt32(СкидкаTB.Text));
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (СтоимостьTB.Text != "" && СкидкаTB.Text != "")
                    {
                        //добавление товара
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.скидкиBindingSource.Current;
                        id = (int)dt["Код_скидки"];
                        MainForm.StoredProcedures.Update_Скидки(id, Convert.ToDouble(СтоимостьTB.Text),
                            Convert.ToInt32(СкидкаTB.Text));
                    }
                }
                MainForm.скидкиTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Скидки_View);
                TableСкидки.AutoResizeColumns();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Скидки_Load(object sender, EventArgs e)
        {
            //подключение биндинга к гриду
            TableСкидки.DataSource = MainForm.скидкиBindingSource;
            //подключение биндинга к навигатору
            NavigatorСкидки.BindingSource = MainForm.скидкиBindingSource;

            //подключение к тестовому полю стоимости от
            СтоимостьTB.DataBindings.Add("Text", MainForm.скидкиBindingSource, "Стоимость_от",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //подключение к тестовому полю скидки
            СкидкаTB.DataBindings.Add("Text", MainForm.скидкиBindingSource, "Скидка",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableСкидки.AutoResizeColumns();
            TableСкидки.Columns[0].Visible = false;
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.скидкиBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.скидкиBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void TableСкидки_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
