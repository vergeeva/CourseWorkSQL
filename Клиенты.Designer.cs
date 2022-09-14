
namespace КурсоваяРаботаSQL
{
    partial class Клиенты
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Клиенты));
            this.ФИОTB = new System.Windows.Forms.TextBox();
            this.TableКлиенты = new System.Windows.Forms.DataGridView();
            this.ButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.ButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.NavigatorКлиенты = new System.Windows.Forms.BindingNavigator(this.components);
            this.FieldCB = new System.Windows.Forms.ToolStripComboBox();
            this.ValueTB = new System.Windows.Forms.ToolStripTextBox();
            this.FilterAccept = new System.Windows.Forms.ToolStripButton();
            this.FilterCancel = new System.Windows.Forms.ToolStripButton();
            this.ТелефонTB = new System.Windows.Forms.MaskedTextBox();
            this.Status = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableКлиенты)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorКлиенты)).BeginInit();
            this.NavigatorКлиенты.SuspendLayout();
            this.SuspendLayout();
            // 
            // ФИОTB
            // 
            this.ФИОTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ФИОTB.Location = new System.Drawing.Point(17, 443);
            this.ФИОTB.Margin = new System.Windows.Forms.Padding(4);
            this.ФИОTB.Name = "ФИОTB";
            this.ФИОTB.Size = new System.Drawing.Size(354, 24);
            this.ФИОTB.TabIndex = 7;
            // 
            // TableКлиенты
            // 
            this.TableКлиенты.AllowUserToAddRows = false;
            this.TableКлиенты.AllowUserToDeleteRows = false;
            this.TableКлиенты.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableКлиенты.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableКлиенты.Location = new System.Drawing.Point(4, 38);
            this.TableКлиенты.Margin = new System.Windows.Forms.Padding(4);
            this.TableКлиенты.Name = "TableКлиенты";
            this.TableКлиенты.ReadOnly = true;
            this.TableКлиенты.RowHeadersWidth = 51;
            this.TableКлиенты.RowTemplate.Height = 24;
            this.TableКлиенты.Size = new System.Drawing.Size(781, 399);
            this.TableКлиенты.TabIndex = 6;
            this.TableКлиенты.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TableКлиенты_DataError);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // NavigatorКлиенты
            // 
            this.NavigatorКлиенты.AddNewItem = null;
            this.NavigatorКлиенты.CountItem = this.bindingNavigatorCountItem;
            this.NavigatorКлиенты.DeleteItem = null;
            this.NavigatorКлиенты.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavigatorКлиенты.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.NavigatorКлиенты.Location = new System.Drawing.Point(0, 0);
            this.NavigatorКлиенты.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NavigatorКлиенты.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NavigatorКлиенты.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NavigatorКлиенты.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NavigatorКлиенты.Name = "NavigatorКлиенты";
            this.NavigatorКлиенты.PositionItem = this.bindingNavigatorPositionItem;
            this.NavigatorКлиенты.Size = new System.Drawing.Size(800, 35);
            this.NavigatorКлиенты.TabIndex = 5;
            this.NavigatorКлиенты.Text = "bindingNavigator1";
            // 
            // FieldCB
            // 
            this.FieldCB.AutoSize = false;
            this.FieldCB.Items.AddRange(new object[] {
            "ФИО_клиента",
            "Телефон",
            "Статус_доверенности"});
            this.FieldCB.Name = "FieldCB";
            this.FieldCB.Size = new System.Drawing.Size(200, 23);
            // 
            // ValueTB
            // 
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(100, 35);
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
            // ТелефонTB
            // 
            this.ТелефонTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ТелефонTB.Location = new System.Drawing.Point(422, 444);
            this.ТелефонTB.Margin = new System.Windows.Forms.Padding(4);
            this.ТелефонTB.Mask = "+7(999) 000-0000";
            this.ТелефонTB.Name = "ТелефонTB";
            this.ТелефонTB.Size = new System.Drawing.Size(145, 24);
            this.ТелефонTB.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(613, 447);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(132, 21);
            this.Status.TabIndex = 11;
            this.Status.Text = "Доверенное лицо";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // Клиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ТелефонTB);
            this.Controls.Add(this.ФИОTB);
            this.Controls.Add(this.TableКлиенты);
            this.Controls.Add(this.NavigatorКлиенты);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Клиенты";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Клиенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableКлиенты)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorКлиенты)).EndInit();
            this.NavigatorКлиенты.ResumeLayout(false);
            this.NavigatorКлиенты.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ФИОTB;
        private System.Windows.Forms.DataGridView TableКлиенты;
        private System.Windows.Forms.ToolStripButton ButtonUpdate;
        private System.Windows.Forms.ToolStripButton ButtonDelete;
        private System.Windows.Forms.ToolStripButton ButtonAdd;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.BindingNavigator NavigatorКлиенты;
        private System.Windows.Forms.MaskedTextBox ТелефонTB;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.ToolStripComboBox FieldCB;
        private System.Windows.Forms.ToolStripTextBox ValueTB;
        private System.Windows.Forms.ToolStripButton FilterAccept;
        private System.Windows.Forms.ToolStripButton FilterCancel;
    }
}