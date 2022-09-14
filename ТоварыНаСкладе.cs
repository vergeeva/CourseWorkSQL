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
    public partial class ТоварыНаСкладе : Form
    {
        bool insert = false; //если не добавление, то обновление
        //для хранения главной формы
        private readonly MDIParent1 MainForm;
        public ТоварыНаСкладе(MDIParent1 form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                insert = true;
                MainForm.приходBindingSource1.AddNew();
                TableТоварыСклад.Rows[TableТоварыСклад.Rows.Count - 1].Selected = true;
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

                dt = (DataRowView)MainForm.приходBindingSource1.Current;
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
                    dt = (DataRowView)MainForm.ТоварыCBbindingSource3.Current;
                    id_pr = (int)dt["Код_товара"];

                    int id_st;
                    dt = (DataRowView)MainForm.складCBBindingSource.Current;
                    id_st = (int)dt["Код_склада"];

                    if (НаименованиеCB.Text != "" && СкладCB.Text != "" && КоличествоTB.Text != "")
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
                    if (НаименованиеCB.Text != "" && СкладCB.Text != "" && КоличествоTB.Text != "")
                    {
                        int id_pr;
                        DataRowView dt;
                        dt = (DataRowView)MainForm.ТоварыCBbindingSource3.Current;
                        id_pr = (int)dt["Код_товара"];

                        int id_st;
                        dt = (DataRowView)MainForm.складCBBindingSource.Current;
                        id_st = (int)dt["Код_склада"];

                        int id;
                        dt = (DataRowView)MainForm.приходBindingSource1.Current;
                        id = (int)dt["Код_записи"];
                        MainForm.StoredProcedures.Update_Приход(id, id_pr,
                            id_st, Convert.ToInt32(КоличествоTB.Text));
                    }
                }
                MainForm.приходTableAdapter.Fill(MainForm.оптоваяТорговляDataSet.Приход_View);
                TableТоварыСклад.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте, все ли сделано и введено верно!", "Сообщение об ошибке");
            }
        }

        private void FilterAccept_Click(object sender, EventArgs e)
        {

        }

        private void FilterCancel_Click(object sender, EventArgs e)
        {

        }

        private void СкладCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (СкладCB.SelectedValue != null)
                {
                    MainForm.приходBindingSource1.Filter = "[Код_склада] = " + СкладCB.SelectedValue.ToString();
                }

                int id_pr;
                DataRowView dt;
                dt = (DataRowView)MainForm.приходBindingSource1.Current;
                if (dt != null)
                {
                    id_pr = (int)dt["Артикул_товара"];
                    НаименованиеCB.SelectedValue = id_pr;

                }

            }
            catch { }

        }

        private void ТоварыНаСкладе_Load(object sender, EventArgs e)
        {
            //складCBBindingSource
            //Подключение таблицы к реализации
            TableТоварыСклад.DataSource = MainForm.приходBindingSource1;
            //Подключение биндинга
            NavigatorТоварыСклад.BindingSource = MainForm.приходBindingSource1;

            //Подключение к комбо боксу адерса склада
            СкладCB.DataSource = MainForm.складCBBindingSource;
            СкладCB.DisplayMember = "Адрес_расположения";
            СкладCB.ValueMember = "Код_склада";

            //Подключение к тестовому полю тип склада
            ТипСкладаTB.DataBindings.Add("Text", MainForm.складCBBindingSource, "Тип_склада",
    true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к тестовому полю количество
            КоличествоTB.DataBindings.Add("Text", MainForm.приходBindingSource1, "Количество",
    true, DataSourceUpdateMode.OnPropertyChanged);

            //Подключение к комбо бокусу наименования товара
            НаименованиеCB.DataSource = MainForm.ТоварыCBbindingSource3;
            НаименованиеCB.DisplayMember = "Наименование_товара";
            НаименованиеCB.ValueMember = "Код_товара";

            TableТоварыСклад.AutoResizeColumns();
            TableТоварыСклад.Columns[0].Visible = false;
            TableТоварыСклад.Columns[1].Visible = false;
            TableТоварыСклад.Columns[2].Visible = false;
            TableТоварыСклад.Columns[4].Visible = false;
            СкладCB_SelectedIndexChanged(sender, e);
        }
    }
}
