
namespace КурсоваяРаботаSQL
{
    partial class Скидки
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Скидки));
            this.СтоимостьTB = new System.Windows.Forms.TextBox();
            this.TableСкидки = new System.Windows.Forms.DataGridView();
            this.ButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.ButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.СкидкаTB = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.NavigatorСкидки = new System.Windows.Forms.BindingNavigator(this.components);
            this.FieldCB = new System.Windows.Forms.ToolStripComboBox();
            this.ValueTB = new System.Windows.Forms.ToolStripTextBox();
            this.FilterAccept = new System.Windows.Forms.ToolStripButton();
            this.FilterCancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableСкидки)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorСкидки)).BeginInit();
            this.NavigatorСкидки.SuspendLayout();
            this.SuspendLayout();
            // 
            // СтоимостьTB
            // 
            this.СтоимостьTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.СтоимостьTB.Location = new System.Drawing.Point(84, 289);
            this.СтоимостьTB.Margin = new System.Windows.Forms.Padding(4);
            this.СтоимостьTB.Name = "СтоимостьTB";
            this.СтоимостьTB.Size = new System.Drawing.Size(203, 24);
            this.СтоимостьTB.TabIndex = 7;
            // 
            // TableСкидки
            // 
            this.TableСкидки.AllowUserToAddRows = false;
            this.TableСкидки.AllowUserToDeleteRows = false;
            this.TableСкидки.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableСкидки.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableСкидки.Location = new System.Drawing.Point(13, 39);
            this.TableСкидки.Margin = new System.Windows.Forms.Padding(4);
            this.TableСкидки.Name = "TableСкидки";
            this.TableСкидки.ReadOnly = true;
            this.TableСкидки.RowHeadersWidth = 51;
            this.TableСкидки.RowTemplate.Height = 24;
            this.TableСкидки.Size = new System.Drawing.Size(695, 242);
            this.TableСкидки.TabIndex = 6;
            this.TableСкидки.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TableСкидки_DataError);
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
            // СкидкаTB
            // 
            this.СкидкаTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.СкидкаTB.Location = new System.Drawing.Point(377, 289);
            this.СкидкаTB.Margin = new System.Windows.Forms.Padding(4);
            this.СкидкаTB.Name = "СкидкаTB";
            this.СкидкаTB.Size = new System.Drawing.Size(244, 24);
            this.СкидкаTB.TabIndex = 8;
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
            // NavigatorСкидки
            // 
            this.NavigatorСкидки.AddNewItem = null;
            this.NavigatorСкидки.CountItem = this.bindingNavigatorCountItem;
            this.NavigatorСкидки.DeleteItem = null;
            this.NavigatorСкидки.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavigatorСкидки.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.NavigatorСкидки.Location = new System.Drawing.Point(0, 0);
            this.NavigatorСкидки.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NavigatorСкидки.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NavigatorСкидки.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NavigatorСкидки.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NavigatorСкидки.Name = "NavigatorСкидки";
            this.NavigatorСкидки.PositionItem = this.bindingNavigatorPositionItem;
            this.NavigatorСкидки.Size = new System.Drawing.Size(721, 35);
            this.NavigatorСкидки.TabIndex = 5;
            this.NavigatorСкидки.Text = "bindingNavigator1";
            // 
            // FieldCB
            // 
            this.FieldCB.AutoSize = false;
            this.FieldCB.Items.AddRange(new object[] {
            "Стоимость_от",
            "Скидка"});
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
            // Скидки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 330);
            this.Controls.Add(this.СтоимостьTB);
            this.Controls.Add(this.TableСкидки);
            this.Controls.Add(this.СкидкаTB);
            this.Controls.Add(this.NavigatorСкидки);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Скидки";
            this.Text = "Скидки";
            this.Load += new System.EventHandler(this.Скидки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableСкидки)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorСкидки)).EndInit();
            this.NavigatorСкидки.ResumeLayout(false);
            this.NavigatorСкидки.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox СтоимостьTB;
        private System.Windows.Forms.DataGridView TableСкидки;
        private System.Windows.Forms.ToolStripButton ButtonUpdate;
        private System.Windows.Forms.ToolStripButton ButtonDelete;
        private System.Windows.Forms.ToolStripButton ButtonAdd;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.TextBox СкидкаTB;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.BindingNavigator NavigatorСкидки;
        private System.Windows.Forms.ToolStripComboBox FieldCB;
        private System.Windows.Forms.ToolStripTextBox ValueTB;
        private System.Windows.Forms.ToolStripButton FilterAccept;
        private System.Windows.Forms.ToolStripButton FilterCancel;
    }
}