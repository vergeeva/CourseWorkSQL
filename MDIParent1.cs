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
    public partial class MDIParent1 : Form
    {
        private int ProductsCount = 1; //товары
        private int ClientsCount = 1; //Клиенты
        private int RealizeCount = 1; //Реализация товаров
        private int StockCount = 1; //Склад
        private int TypeCount = 1; //Типы склада
        private int DeliveryCount = 1; //Приход
        private int RateCount = 1; //Процент
        private int ReturnCount = 1; //Возврат
        private int ProductStock = 1; //Возврат


        public MDIParent1()
        {
            InitializeComponent();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.ТипыСклада_View". При необходимости она может быть перемещена или удалена.
            this.типыСкладаTableAdapter.Fill(this.оптоваяТорговляDataSet.ТипыСклада_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.СписокВозврат_View". При необходимости она может быть перемещена или удалена.
            this.списокВозвратTableAdapter.Fill(this.оптоваяТорговляDataSet.СписокВозврат_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.Возврат_View". При необходимости она может быть перемещена или удалена.
            this.возвратTableAdapter.Fill(this.оптоваяТорговляDataSet.Возврат_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.Скидки_View". При необходимости она может быть перемещена или удалена.
            this.скидкиTableAdapter.Fill(this.оптоваяТорговляDataSet.Скидки_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.Приход_View". При необходимости она может быть перемещена или удалена.
            this.приходTableAdapter.Fill(this.оптоваяТорговляDataSet.Приход_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.Склад_View". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.оптоваяТорговляDataSet.Склад_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.СписокРеализация_View". При необходимости она может быть перемещена или удалена.
            this.списокРеализацияTableAdapter.Fill(this.оптоваяТорговляDataSet.СписокРеализация_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.РеализацияТоваров_View". При необходимости она может быть перемещена или удалена.
            this.реализацияТоваровTableAdapter.Fill(this.оптоваяТорговляDataSet.РеализацияТоваров_View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.Клиенты_View". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.оптоваяТорговляDataSet.Клиенты_View);
            //загрузка формы 
            this.товарыTableAdapter.Fill(this.оптоваяТорговляDataSet.Товары_View);
            this.WindowState = FormWindowState.Maximized;


        }
        private void OpenТовары_Click(object sender, EventArgs e)
        {
            //открыть таблицу товары
            Form childForm = new Товары(this)
            {
                MdiParent = this,
                Text = "Товары " + ProductsCount++,
            };
            childForm.Show();
        }

        private void OpenКлиенты_Click(object sender, EventArgs e)
        {
            //Открыть таблицу клиенты
            Form childForm = new Клиенты(this)
            {
                MdiParent = this,
                Text = "Клиенты " + ClientsCount++,
            };
            childForm.Show();
        }

        private void OpenРеализация_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Реализация товаров"
            Form childForm = new РеализацияТоваров(this)
            {
                MdiParent = this,
                Text = "Реализация товаров " + RealizeCount++,
            };
            childForm.Show();
        }

        private void OpenСклад_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Склад"
            Form childForm = new Склад(this)
            {
                MdiParent = this,
                Text = "Склад " + StockCount++,
            };
            childForm.Show();

        }

        private void OpenПриход_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Склад"
            Form childForm = new Приход(this)
            {
                MdiParent = this,
                Text = "Приход " + DeliveryCount++,
            };
            childForm.Show();
        }

        private void OpenСкидки_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Склад"
            Form childForm = new Скидки(this)
            {
                MdiParent = this,
                Text = "Скидки " + RateCount++,
            };
            childForm.Show();
        }

        private void OpenВозврат_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Склад"
            Form childForm = new Возврат(this)
            {
                MdiParent = this,
                Text = "Возврат " + ReturnCount++,
            };
            childForm.Show();
        }

        public bool RunFilter(BindingSource binding, string value, string field)//биндинг, значение фильтра, поле для фильтрации
        {//задать фильтр таблице
            try
            {
                if (value == "" && field == "")
                {//если поле и значение не указано
                    binding.Filter = "";//присваиваем пустой фильтр
                    return true;//фильтр сработал, возвращаем
                }
                if (int.TryParse(value, out _))
                {//если число
                    binding.Filter = String.Format("[{0}] = {1}", field, value);
                }
                else
                {//если пользователь использует знаки
                    if (value[0] == '<' || value[0] == '>' || value[0] == '=')
                    {
                        if ((int.TryParse(value.Substring(1), out _)) || (value[1] == '=' && int.TryParse(value.Substring(2), out _)))
                        {//для чисел
                            binding.Filter = String.Format("[{0}] {1}", field, value);
                        }
                        else if (DateTime.TryParse(value.Substring(1), out _))
                        {//если знак однозначный для даты
                            char mark = value[0];
                            value = Convert.ToDateTime(value.Substring(1)).ToString().Replace('.', '-');
                            binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value);
                        }
                        else if (value[1] == '=' && DateTime.TryParse(value.Substring(2), out _))
                        {//если знак из двух знаков для даты
                            string mark = value.Substring(0, 2);
                            //конвертируем дату, так как для сравнения формат даты немного другой
                            value = Convert.ToDateTime(value.Substring(2)).ToString().Replace('.', '-');
                            binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value);
                        }
                    }
                    else
                    {//для строк
                        if (value[value.Length - 1] == '*')
                        {//если есть звездочка
                            binding.Filter = String.Format("[{0}] like '{1}'", field, value);
                        }
                        else if (DateTime.TryParse(value, out _))
                        {//если дата без знаков
                            //конвертируем дату, так как для сравнения формат даты немного другой
                            value = Convert.ToDateTime(value).ToString().Replace('.', '-');
                            binding.Filter = String.Format("[{0}] = '{1}'", field, value);
                        }
                        else
                        {//если строка без звездочки
                            binding.Filter = String.Format("[{0}] like '{1}*'", field, value);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void OpenТипыСклада_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Склад"
            Form childForm = new ТипыСклада(this)
            {
                MdiParent = this,
                Text = "Типы склада " + TypeCount++,
            };
            childForm.Show();
        }

        private void OpenТоварыНаСкладе_Click(object sender, EventArgs e)
        {
            //Открыть таблицу "Товары на складе"
            Form childForm = new ТоварыНаСкладе(this)
            {
                MdiParent = this,
                Text = "Товары на складе " + ProductStock++,
            };
            childForm.Show();
        }
    }
}
