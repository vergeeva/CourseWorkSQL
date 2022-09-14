
namespace КурсоваяРаботаSQL
{
    partial class ТоварыНаСкладе
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ТоварыНаСкладе));
            this.КоличествоTB = new System.Windows.Forms.TextBox();
            this.TableТоварыСклад = new System.Windows.Forms.DataGridView();
            this.FilterCancel = new System.Windows.Forms.ToolStripButton();
            this.FilterAccept = new System.Windows.Forms.ToolStripButton();
            this.ValueTB = new System.Windows.Forms.ToolStripTextBox();
            this.FieldCB = new System.Windows.Forms.ToolStripComboBox();
            this.ButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.ButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorТоварыСклад = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.СкладCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.НаименованиеCB = new System.Windows.Forms.ComboBox();
            this.ТипСкладаTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableТоварыСклад)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorТоварыСклад)).BeginInit();
            this.NavigatorТоварыСклад.SuspendLayout();
            this.SuspendLayout();
            // 
            // КоличествоTB
            // 
            this.КоличествоTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.КоличествоTB.Location = new System.Drawing.Point(396, 421);
            this.КоличествоTB.Margin = new System.Windows.Forms.Padding(4);
            this.КоличествоTB.Name = "КоличествоTB";
            this.КоличествоTB.Size = new System.Drawing.Size(284, 24);
            this.КоличествоTB.TabIndex = 9;
            // 
            // TableТоварыСклад
            // 
            this.TableТоварыСклад.AllowUserToAddRows = false;
            this.TableТоварыСклад.AllowUserToDeleteRows = false;
            this.TableТоварыСклад.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableТоварыСклад.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableТоварыСклад.Location = new System.Drawing.Point(13, 82);
            this.TableТоварыСклад.Margin = new System.Windows.Forms.Padding(4);
            this.TableТоварыСклад.Name = "TableТоварыСклад";
            this.TableТоварыСклад.ReadOnly = true;
            this.TableТоварыСклад.RowHeadersWidth = 51;
            this.TableТоварыСклад.RowTemplate.Height = 24;
            this.TableТоварыСклад.Size = new System.Drawing.Size(796, 331);
            this.TableТоварыСклад.TabIndex = 6;
            // 
            // FilterCancel
            // 
            this.FilterCancel.AutoSize = false;
            this.FilterCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterCancel.Image = ((System.Drawing.Image)(resources.GetObject("FilterCancel.Image")));
            this.FilterCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterCancel.Name = "FilterCancel";
            this.FilterCancel.Size = new System.Drawing.Size(32, 32);
            this.FilterCancel.Tag = "Отменить";
            this.FilterCancel.Text = "Отменить";
            this.FilterCancel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.FilterCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FilterCancel.Click += new System.EventHandler(this.FilterCancel_Click);
            // 
            // FilterAccept
            // 
            this.FilterAccept.AutoSize = false;
            this.FilterAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterAccept.Image = ((System.Drawing.Image)(resources.GetObject("FilterAccept.Image")));
            this.FilterAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterAccept.Name = "FilterAccept";
            this.FilterAccept.Size = new System.Drawing.Size(32, 32);
            this.FilterAccept.Tag = "Применить";
            this.FilterAccept.Text = "Применить";
            this.FilterAccept.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.FilterAccept.Click += new System.EventHandler(this.FilterAccept_Click);
            // 
            // ValueTB
            // 
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(124, 35);
            // 
            // FieldCB
            // 
            this.FieldCB.AutoSize = false;
            this.FieldCB.Items.AddRange(new object[] {
            "Наименование_товара",
            "Количество"});
            this.FieldCB.Name = "FieldCB";
            this.FieldCB.Size = new System.Drawing.Size(249, 23);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.Image")));
            this.ButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(24, 32);
            this.ButtonUpdate.Text = "Сохранить изменения";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.RightToLeftAutoMirrorImage = true;
            this.ButtonDelete.Size = new System.Drawing.Size(24, 32);
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.RightToLeftAutoMirrorImage = true;
            this.ButtonAdd.Size = new System.Drawing.Size(24, 32);
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(60, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // NavigatorТоварыСклад
            // 
            this.NavigatorТоварыСклад.AddNewItem = null;
            this.NavigatorТоварыСклад.CountItem = this.bindingNavigatorCountItem;
            this.NavigatorТоварыСклад.DeleteItem = null;
            this.NavigatorТоварыСклад.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavigatorТоварыСклад.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.ButtonAdd,
            this.ButtonDelete,
            this.ButtonUpdate,
            this.FieldCB,
            this.ValueTB,
            this.FilterAccept,
            this.FilterCancel});
            this.NavigatorТоварыСклад.Location = new System.Drawing.Point(0, 0);
            this.NavigatorТоварыСклад.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NavigatorТоварыСклад.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NavigatorТоварыСклад.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NavigatorТоварыСклад.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NavigatorТоварыСклад.Name = "NavigatorТоварыСклад";
            this.NavigatorТоварыСклад.PositionItem = this.bindingNavigatorPositionItem;
            this.NavigatorТоварыСклад.Size = new System.Drawing.Size(822, 35);
            this.NavigatorТоварыСклад.TabIndex = 5;
            this.NavigatorТоварыСклад.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберите склад: ";
            // 
            // СкладCB
            // 
            this.СкладCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.СкладCB.FormattingEnabled = true;
            this.СкладCB.Location = new System.Drawing.Point(136, 44);
            this.СкладCB.Name = "СкладCB";
            this.СкладCB.Size = new System.Drawing.Size(366, 24);
            this.СкладCB.TabIndex = 11;
            this.СкладCB.SelectedIndexChanged += new System.EventHandler(this.СкладCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип склада";
            // 
            // НаименованиеCB
            // 
            this.НаименованиеCB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.НаименованиеCB.FormattingEnabled = true;
            this.НаименованиеCB.Location = new System.Drawing.Point(12, 421);
            this.НаименованиеCB.Name = "НаименованиеCB";
            this.НаименованиеCB.Size = new System.Drawing.Size(359, 24);
            this.НаименованиеCB.TabIndex = 13;
            // 
            // ТипСкладаTB
            // 
            this.ТипСкладаTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ТипСкладаTB.Location = new System.Drawing.Point(613, 46);
            this.ТипСкладаTB.Name = "ТипСкладаTB";
            this.ТипСкладаTB.ReadOnly = true;
            this.ТипСкладаTB.Size = new System.Drawing.Size(197, 24);
            this.ТипСкладаTB.TabIndex = 14;
            // 
            // ТоварыНаСкладе
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 462);
            this.Controls.Add(this.ТипСкладаTB);
            this.Controls.Add(this.НаименованиеCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.СкладCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.КоличествоTB);
            this.Controls.Add(this.TableТоварыСклад);
            this.Controls.Add(this.NavigatorТоварыСклад);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ТоварыНаСкладе";
            this.Text = "ТоварыНаСкладе";
            this.Load += new System.EventHandler(this.ТоварыНаСкладе_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableТоварыСклад)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorТоварыСклад)).EndInit();
            this.NavigatorТоварыСклад.ResumeLayout(false);
            this.NavigatorТоварыСклад.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox КоличествоTB;
        private System.Windows.Forms.DataGridView TableТоварыСклад;
        private System.Windows.Forms.ToolStripButton FilterCancel;
        private System.Windows.Forms.ToolStripButton FilterAccept;
        private System.Windows.Forms.ToolStripTextBox ValueTB;
        private System.Windows.Forms.ToolStripComboBox FieldCB;
        private System.Windows.Forms.ToolStripButton ButtonUpdate;
        private System.Windows.Forms.ToolStripButton ButtonDelete;
        private System.Windows.Forms.ToolStripButton ButtonAdd;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator NavigatorТоварыСклад;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox СкладCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox НаименованиеCB;
        private System.Windows.Forms.TextBox ТипСкладаTB;
    }
}