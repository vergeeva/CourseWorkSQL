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

    public partial class Товары : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public Товары(MDIParent1 form)
        {//конструктор с параметром
            InitializeComponent();
            MainForm = form;
            //присваиваем этот параметр
        }

        private void Товары_Load(object sender, EventArgs e)
        {//события при загрузке формы

            //подключение биндинга к гриду
            TableТовары.DataSource = MainForm.товарыBindingSource;
            //подключение биндинга к навигатору
            NavigatorТовары.BindingSource = MainForm.товарыBindingSource;

            //подключение к тестовому полю артикула
            АртикулTB.DataBindings.Add("Text", MainForm.товарыBindingSource, "Артикул_товара",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //подключение к тестовому полю наименование
            НаименованиеTB.DataBindings.Add("Text", MainForm.товарыBindingSource, "Наименование_товара",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //подключение к тестовому полю цены
            ЦенаTB.DataBindings.Add("Text", MainForm.товарыBindingSource, "Цена_товара_шт",
                true, DataSourceUpdateMode.OnPropertyChanged);

            TableТовары.AutoResizeColumns();
            TableТовары.Columns[0].Visible = false;
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {//Добавить
            //добавить пустую строку, выделить в гриде
            //пользователь вводит данные и жмет сохранить
            try
            {
                insert = true;
                MainForm.товарыBindingSource.AddNew();
                TableТовары.Rows[TableТовары.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//Удалить
            string name = "";
            try
            {                
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.товарыBindingSource.Current;
                id = (int)dt["Код_товара"];
                name = (string)dt["Наименование_товара"];

                MainForm.StoredProcedures.Delete_Товары(id);
                MainForm.товарыTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Товары_View);
            }
            catch (Exception)
            {

                MessageBox.Show(String.Format("Нельзя удалить товар '{0}' в связи с целостностью данных", name), "Произошла ошибка удаления");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {//Обновить
            try
            {
                if (insert)
                {
                    if (АртикулTB.Text != "" && НаименованиеTB.Text != "" && ЦенаTB.Text != "")
                    {
                        //добавление товара
                        MainForm.StoredProcedures.Insert_Товары(Convert.ToInt32(АртикулTB.Text),
                            НаименованиеTB.Text, Convert.ToDouble(ЦенаTB.Text));
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (АртикулTB.Text != "" && НаименованиеTB.Text != "" && ЦенаTB.Text != "")
                    {
                        //добавление товара
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.товарыBindingSource.Current;
                        id = (int)dt["Код_товара"];
                        MainForm.StoredProcedures.Update_Товары(id, Convert.ToInt32(АртикулTB.Text),
                            НаименованиеTB.Text, Convert.ToDouble(ЦенаTB.Text));
                    }
                }
                MainForm.товарыTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Товары_View);
                TableТовары.AutoResizeColumns();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка сохранения, скорее всего данные не соответствуют условиям", "Произошла ошибка сохранения данных");
            }
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {//применить фильтр
            bool result = MainForm.RunFilter(MainForm.товарыBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {//отменить фильтр
            bool result = MainForm.RunFilter(MainForm.товарыBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void TableТовары_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
