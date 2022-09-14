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
    public partial class ТипыСклада : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public ТипыСклада(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void ТипыСклада_Load(object sender, EventArgs e)
        {
            //подключение биндинга к гриду
            TableТипСклада.DataSource = MainForm.типыСкладаBindingSource;
            //подключение биндинга к навигатору
            NavigatorТипСклада.BindingSource = MainForm.типыСкладаBindingSource;

            //подключение к тестовому полю 
            ТипСкладаTB.DataBindings.Add("Text", MainForm.типыСкладаBindingSource, "Тип_склада",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableТипСклада.AutoResizeColumns();
            TableТипСклада.Columns[0].Visible = false;
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.типыСкладаBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            bool result = MainForm.RunFilter(MainForm.типыСкладаBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {//Добавить
            try
            {
                insert = true;
                MainForm.типыСкладаBindingSource.AddNew();
                TableТипСклада.Rows[TableТипСклада.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//удалить
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.типыСкладаBindingSource.Current;
                id = (int)dt["Код_типа"];
                MainForm.StoredProcedures.Delete_ТипыСклада(id);
                MainForm.типыСкладаTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.ТипыСклада_View);
            }
            catch (Exception)
            {
                MessageBox.Show("Данный тип склада используется, невозможно удалить", "Сообщение об ошибке");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//Изменить
            try
            {
                if (insert)
                {
                    if (ТипСкладаTB.Text != "")
                    {
                        //добавление 
                        MainForm.StoredProcedures.Insert_ТипыСклада(ТипСкладаTB.Text);
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (ТипСкладаTB.Text != "")
                    {
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.типыСкладаBindingSource.Current;
                        id = (int)dt["Код_типа"];
                        MainForm.StoredProcedures.Update_ТипСклада(id, ТипСкладаTB.Text);
                    }
                }
                MainForm.типыСкладаTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.ТипыСклада_View);
                TableТипСклада.AutoResizeColumns();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TableТипСклада_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
