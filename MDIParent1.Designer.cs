
namespace КурсоваяРаботаSQL
{
    partial class MDIParent1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.OpenТовары = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenКлиенты = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenРеализация = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenВозврат = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenПриход = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenСклад = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenТипыСклада = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenТоварыНаСкладе = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenСкидки = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.оптоваяТорговляDataSet = new КурсоваяРаботаSQL.ОптоваяТорговляDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.Товары_ViewTableAdapter();
            this.tableAdapterManager = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.TableAdapterManager();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.Клиенты_ViewTableAdapter();
            this.реализацияТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокРеализацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокРеализацияTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.СписокРеализация_ViewTableAdapter();
            this.реализацияТоваровTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.РеализацияТоваров_ViewTableAdapter();
            this.StoredProcedures = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.QueriesTableAdapter();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.Склад_ViewTableAdapter();
            this.приходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приходTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.Приход_ViewTableAdapter();
            this.скидкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.скидкиTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.Скидки_ViewTableAdapter();
            this.возвратBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.возвратTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.Возврат_ViewTableAdapter();
            this.списокВозвратBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокВозвратTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.СписокВозврат_ViewTableAdapter();
            this.типыСкладаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типыСкладаTableAdapter = new КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.ТипыСклада_ViewTableAdapter();
            this.ТоварыCBbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыCBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типыСкладаCBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ТоварыCBbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ТоварыCBbindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыCBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.складCBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приходBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ТоварыCBbindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оптоваяТорговляDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРеализацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокВозвратBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыСкладаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыCBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыСкладаCBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыCBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складCBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenТовары,
            this.OpenКлиенты,
            this.OpenРеализация,
            this.OpenВозврат,
            this.OpenПриход,
            this.OpenСклад,
            this.OpenТипыСклада,
            this.OpenТоварыНаСкладе,
            this.OpenСкидки});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // OpenТовары
            // 
            this.OpenТовары.Image = ((System.Drawing.Image)(resources.GetObject("OpenТовары.Image")));
            this.OpenТовары.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenТовары.Name = "OpenТовары";
            this.OpenТовары.Size = new System.Drawing.Size(96, 24);
            this.OpenТовары.Text = "&Товары";
            this.OpenТовары.Click += new System.EventHandler(this.OpenТовары_Click);
            // 
            // OpenКлиенты
            // 
            this.OpenКлиенты.Image = ((System.Drawing.Image)(resources.GetObject("OpenКлиенты.Image")));
            this.OpenКлиенты.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenКлиенты.Name = "OpenКлиенты";
            this.OpenКлиенты.Size = new System.Drawing.Size(103, 24);
            this.OpenКлиенты.Text = "&Клиенты";
            this.OpenКлиенты.Click += new System.EventHandler(this.OpenКлиенты_Click);
            // 
            // OpenРеализация
            // 
            this.OpenРеализация.Image = ((System.Drawing.Image)(resources.GetObject("OpenРеализация.Image")));
            this.OpenРеализация.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenРеализация.Name = "OpenРеализация";
            this.OpenРеализация.Size = new System.Drawing.Size(186, 24);
            this.OpenРеализация.Text = "&Реализация товаров";
            this.OpenРеализация.Click += new System.EventHandler(this.OpenРеализация_Click);
            // 
            // OpenВозврат
            // 
            this.OpenВозврат.Image = ((System.Drawing.Image)(resources.GetObject("OpenВозврат.Image")));
            this.OpenВозврат.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenВозврат.Name = "OpenВозврат";
            this.OpenВозврат.Size = new System.Drawing.Size(160, 24);
            this.OpenВозврат.Text = "&Возврат товаров";
            this.OpenВозврат.Click += new System.EventHandler(this.OpenВозврат_Click);
            // 
            // OpenПриход
            // 
            this.OpenПриход.Image = ((System.Drawing.Image)(resources.GetObject("OpenПриход.Image")));
            this.OpenПриход.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenПриход.Name = "OpenПриход";
            this.OpenПриход.Size = new System.Drawing.Size(96, 24);
            this.OpenПриход.Text = "&Приход";
            this.OpenПриход.Click += new System.EventHandler(this.OpenПриход_Click);
            // 
            // OpenСклад
            // 
            this.OpenСклад.Image = ((System.Drawing.Image)(resources.GetObject("OpenСклад.Image")));
            this.OpenСклад.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenСклад.Name = "OpenСклад";
            this.OpenСклад.Size = new System.Drawing.Size(94, 24);
            this.OpenСклад.Text = "&Склады";
            this.OpenСклад.Click += new System.EventHandler(this.OpenСклад_Click);
            // 
            // OpenТипыСклада
            // 
            this.OpenТипыСклада.Image = ((System.Drawing.Image)(resources.GetObject("OpenТипыСклада.Image")));
            this.OpenТипыСклада.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenТипыСклада.Name = "OpenТипыСклада";
            this.OpenТипыСклада.Size = new System.Drawing.Size(130, 24);
            this.OpenТипыСклада.Text = "&Типы склада";
            this.OpenТипыСклада.Click += new System.EventHandler(this.OpenТипыСклада_Click);
            // 
            // OpenТоварыНаСкладе
            // 
            this.OpenТоварыНаСкладе.Image = ((System.Drawing.Image)(resources.GetObject("OpenТоварыНаСкладе.Image")));
            this.OpenТоварыНаСкладе.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenТоварыНаСкладе.Name = "OpenТоварыНаСкладе";
            this.OpenТоварыНаСкладе.Size = new System.Drawing.Size(167, 24);
            this.OpenТоварыНаСкладе.Text = "&Товары на складе";
            this.OpenТоварыНаСкладе.Click += new System.EventHandler(this.OpenТоварыНаСкладе_Click);
            // 
            // OpenСкидки
            // 
            this.OpenСкидки.Image = ((System.Drawing.Image)(resources.GetObject("OpenСкидки.Image")));
            this.OpenСкидки.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenСкидки.Name = "OpenСкидки";
            this.OpenСкидки.Size = new System.Drawing.Size(92, 24);
            this.OpenСкидки.Text = "&Скидки";
            this.OpenСкидки.Click += new System.EventHandler(this.OpenСкидки_Click);
            // 
            // оптоваяТорговляDataSet
            // 
            this.оптоваяТорговляDataSet.DataSetName = "ОптоваяТорговляDataSet";
            this.оптоваяТорговляDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары_View";
            this.товарыBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = КурсоваяРаботаSQL.ОптоваяТорговляDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты_View";
            this.клиентыBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // реализацияТоваровBindingSource
            // 
            this.реализацияТоваровBindingSource.DataMember = "РеализацияТоваров_View";
            this.реализацияТоваровBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // списокРеализацияBindingSource
            // 
            this.списокРеализацияBindingSource.DataMember = "СписокРеализация_View";
            this.списокРеализацияBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // списокРеализацияTableAdapter
            // 
            this.списокРеализацияTableAdapter.ClearBeforeFill = true;
            // 
            // реализацияТоваровTableAdapter
            // 
            this.реализацияТоваровTableAdapter.ClearBeforeFill = true;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад_View";
            this.складBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // приходBindingSource
            // 
            this.приходBindingSource.DataMember = "Приход_View";
            this.приходBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // приходTableAdapter
            // 
            this.приходTableAdapter.ClearBeforeFill = true;
            // 
            // скидкиBindingSource
            // 
            this.скидкиBindingSource.DataMember = "Скидки_View";
            this.скидкиBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // скидкиTableAdapter
            // 
            this.скидкиTableAdapter.ClearBeforeFill = true;
            // 
            // возвратBindingSource
            // 
            this.возвратBindingSource.DataMember = "Возврат_View";
            this.возвратBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // возвратTableAdapter
            // 
            this.возвратTableAdapter.ClearBeforeFill = true;
            // 
            // списокВозвратBindingSource
            // 
            this.списокВозвратBindingSource.DataMember = "СписокВозврат_View";
            this.списокВозвратBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // списокВозвратTableAdapter
            // 
            this.списокВозвратTableAdapter.ClearBeforeFill = true;
            // 
            // типыСкладаBindingSource
            // 
            this.типыСкладаBindingSource.DataMember = "ТипыСклада_View";
            this.типыСкладаBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // типыСкладаTableAdapter
            // 
            this.типыСкладаTableAdapter.ClearBeforeFill = true;
            // 
            // ТоварыCBbindingSource
            // 
            this.ТоварыCBbindingSource.DataMember = "Товары_View";
            this.ТоварыCBbindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // клиентыCBBindingSource
            // 
            this.клиентыCBBindingSource.DataMember = "Клиенты_View";
            this.клиентыCBBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // типыСкладаCBBindingSource
            // 
            this.типыСкладаCBBindingSource.DataMember = "ТипыСклада_View";
            this.типыСкладаCBBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // ТоварыCBbindingSource1
            // 
            this.ТоварыCBbindingSource1.DataMember = "Товары_View";
            this.ТоварыCBbindingSource1.DataSource = this.оптоваяТорговляDataSet;
            // 
            // ТоварыCBbindingSource2
            // 
            this.ТоварыCBbindingSource2.DataMember = "Товары_View";
            this.ТоварыCBbindingSource2.DataSource = this.оптоваяТорговляDataSet;
            // 
            // клиентыCBBindingSource1
            // 
            this.клиентыCBBindingSource1.DataMember = "Клиенты_View";
            this.клиентыCBBindingSource1.DataSource = this.оптоваяТорговляDataSet;
            // 
            // складCBBindingSource
            // 
            this.складCBBindingSource.DataMember = "Склад_View";
            this.складCBBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // приходBindingSource1
            // 
            this.приходBindingSource1.DataMember = "Приход_View";
            this.приходBindingSource1.DataSource = this.оптоваяТорговляDataSet;
            // 
            // ТоварыCBbindingSource3
            // 
            this.ТоварыCBbindingSource3.DataMember = "Товары_View";
            this.ТоварыCBbindingSource3.DataSource = this.оптоваяТорговляDataSet;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 491);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDIParent1";
            this.Text = " Оптовая торговля";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оптоваяТорговляDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРеализацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокВозвратBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыСкладаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыCBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыСкладаCBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыCBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складCBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ТоварыCBbindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.BindingSource товарыBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.Товары_ViewTableAdapter товарыTableAdapter;
        public ОптоваяТорговляDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public ОптоваяТорговляDataSet оптоваяТорговляDataSet;
        public System.Windows.Forms.BindingSource клиентыBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.Клиенты_ViewTableAdapter клиентыTableAdapter;
        public System.Windows.Forms.BindingSource реализацияТоваровBindingSource;
        public System.Windows.Forms.BindingSource списокРеализацияBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.СписокРеализация_ViewTableAdapter списокРеализацияTableAdapter;
        public ОптоваяТорговляDataSetTableAdapters.РеализацияТоваров_ViewTableAdapter реализацияТоваровTableAdapter;
        public ОптоваяТорговляDataSetTableAdapters.QueriesTableAdapter StoredProcedures;
        public System.Windows.Forms.BindingSource складBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.Склад_ViewTableAdapter складTableAdapter;
        public System.Windows.Forms.BindingSource приходBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.Приход_ViewTableAdapter приходTableAdapter;
        public System.Windows.Forms.BindingSource скидкиBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.Скидки_ViewTableAdapter скидкиTableAdapter;
        public System.Windows.Forms.BindingSource возвратBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.Возврат_ViewTableAdapter возвратTableAdapter;
        public System.Windows.Forms.BindingSource списокВозвратBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.СписокВозврат_ViewTableAdapter списокВозвратTableAdapter;
        public System.Windows.Forms.BindingSource типыСкладаBindingSource;
        public ОптоваяТорговляDataSetTableAdapters.ТипыСклада_ViewTableAdapter типыСкладаTableAdapter;
        public System.Windows.Forms.BindingSource ТоварыCBbindingSource;
        public System.Windows.Forms.BindingSource клиентыCBBindingSource;
        public System.Windows.Forms.BindingSource типыСкладаCBBindingSource;
        private System.Windows.Forms.ToolStripMenuItem OpenТовары;
        private System.Windows.Forms.ToolStripMenuItem OpenКлиенты;
        private System.Windows.Forms.ToolStripMenuItem OpenРеализация;
        private System.Windows.Forms.ToolStripMenuItem OpenСклад;
        private System.Windows.Forms.ToolStripMenuItem OpenТипыСклада;
        private System.Windows.Forms.ToolStripMenuItem OpenПриход;
        private System.Windows.Forms.ToolStripMenuItem OpenСкидки;
        private System.Windows.Forms.ToolStripMenuItem OpenВозврат;
        public System.Windows.Forms.BindingSource ТоварыCBbindingSource1;
        public System.Windows.Forms.BindingSource ТоварыCBbindingSource2;
        public System.Windows.Forms.BindingSource клиентыCBBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem OpenТоварыНаСкладе;
        public System.Windows.Forms.BindingSource складCBBindingSource;
        public System.Windows.Forms.BindingSource приходBindingSource1;
        public System.Windows.Forms.BindingSource ТоварыCBbindingSource3;
    }
}



