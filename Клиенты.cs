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
    public partial class Клиенты : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public Клиенты(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void Клиенты_Load(object sender, EventArgs e)
        {
            //подключение биндинга к гриду
            TableКлиенты.DataSource = MainForm.клиентыBindingSource;
            //подключение биндинга к навигатору
            NavigatorКлиенты.BindingSource = MainForm.клиентыBindingSource;

            //подключение к тестовому фио клиента
            ФИОTB.DataBindings.Add("Text", MainForm.клиентыBindingSource, "ФИО_клиента",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //подключение к тестовому полю телефон
            ТелефонTB.DataBindings.Add("Text", MainForm.клиентыBindingSource, "Телефон",
                true, DataSourceUpdateMode.OnPropertyChanged);

            //подключение к чек боксу статус доверенности
            Status.DataBindings.Add("Checked", MainForm.клиентыBindingSource, "Статус_доверенности",
                true, DataSourceUpdateMode.OnPropertyChanged);
            TableКлиенты.AutoResizeColumns();
            TableКлиенты.Columns[0].Visible = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                insert = true;
                MainForm.клиентыBindingSource.AddNew();
                TableКлиенты.Rows[TableКлиенты.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)MainForm.клиентыBindingSource.Current;
                id = (int)dt["Код_клиента"];
                name = (string)dt["ФИО_клиента"];
                MainForm.StoredProcedures.Delete_Клиенты(id);
                MainForm.клиентыTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Клиенты_View);
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("Нельзя удалить клиента '{0}' так как с ним есть связанные заказы", name), "Произошла ошибка удаления");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (insert)
                {
                    if (ФИОTB.Text != "" && ТелефонTB.Text != "")
                    {
                        //добавление клиента
                        MainForm.StoredProcedures.Insert_Клиенты(ФИОTB.Text,
                            ТелефонTB.Text, Status.Checked);
                        insert = false;
                    }
                }
                else
                {
                    //обновление данных
                    if (ФИОTB.Text != "" && ТелефонTB.Text != "")
                    {
                        //добавление товара
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)MainForm.клиентыBindingSource.Current;
                        id = (int)dt["Код_клиента"];
                        MainForm.StoredProcedures.Update_Клиенты(id, ФИОTB.Text,
                            ТелефонTB.Text, Status.Checked);
                    }
                }
                MainForm.клиентыTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Клиенты_View);
                TableКлиенты.AutoResizeColumns();
            }
            catch (Exception)
            {
            }
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {
            //применить фильтр
            bool result = MainForm.RunFilter(MainForm.клиентыBindingSource, ValueTB.Text, FieldCB.Text);
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {
            //отменить фильтр
            bool result = MainForm.RunFilter(MainForm.клиентыBindingSource, "", "");
            if (!result)
            {
                MessageBox.Show("Ошибка запроса");
            }
        }

        private void TableКлиенты_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
