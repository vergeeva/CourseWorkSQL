
namespace КурсоваяРаботаSQL
{
    partial class ТипыСклада
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ТипыСклада));
            this.TableТипСклада = new System.Windows.Forms.DataGridView();
            this.FilterCancel = new System.Windows.Forms.ToolStripButton();
            this.FilterAccept = new System.Windows.Forms.ToolStripButton();
            this.ValueTB = new System.Windows.Forms.ToolStripTextBox();
            this.FieldCB = new System.Windows.Forms.ToolStripComboBox();
            this.ButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.ТипСкладаTB = new System.Windows.Forms.TextBox();
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
            this.NavigatorТипСклада = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TableТипСклада)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorТипСклада)).BeginInit();
            this.NavigatorТипСклада.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableТипСклада
            // 
            this.TableТипСклада.AllowUserToAddRows = false;
            this.TableТипСклада.AllowUserToDeleteRows = false;
            this.TableТипСклада.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableТипСклада.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableТипСклада.Location = new System.Drawing.Point(9, 31);
            this.TableТипСклада.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableТипСклада.Name = "TableТипСклада";
            this.TableТипСклада.ReadOnly = true;
            this.TableТипСклада.RowHeadersWidth = 51;
            this.TableТипСклада.RowTemplate.Height = 24;
            this.TableТипСклада.Size = new System.Drawing.Size(428, 238);
            this.TableТипСклада.TabIndex = 6;
            this.TableТипСклада.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TableТипСклада_DataError);
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
            this.ValueTB.Size = new System.Drawing.Size(76, 35);
            // 
            // FieldCB
            // 
            this.FieldCB.AutoSize = false;
            this.FieldCB.Items.AddRange(new object[] {
            "Тип_склада"});
            this.FieldCB.Name = "FieldCB";
            this.FieldCB.Size = new System.Drawing.Size(151, 23);
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
            // ТипСкладаTB
            // 
            this.ТипСкладаTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ТипСкладаTB.Location = new System.Drawing.Point(442, 46);
            this.ТипСкладаTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ТипСкладаTB.Name = "ТипСкладаTB";
            this.ТипСкладаTB.Size = new System.Drawing.Size(146, 20);
            this.ТипСкладаTB.TabIndex = 8;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            // NavigatorТипСклада
            // 
            this.NavigatorТипСклада.AddNewItem = null;
            this.NavigatorТипСклада.CountItem = this.bindingNavigatorCountItem;
            this.NavigatorТипСклада.DeleteItem = null;
            this.NavigatorТипСклада.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavigatorТипСклада.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.NavigatorТипСклада.Location = new System.Drawing.Point(0, 0);
            this.NavigatorТипСклада.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NavigatorТипСклада.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NavigatorТипСклада.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NavigatorТипСклада.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NavigatorТипСклада.Name = "NavigatorТипСклада";
            this.NavigatorТипСклада.PositionItem = this.bindingNavigatorPositionItem;
            this.NavigatorТипСклада.Size = new System.Drawing.Size(596, 35);
            this.NavigatorТипСклада.TabIndex = 5;
            this.NavigatorТипСклада.Text = "bindingNavigator1";
            // 
            // ТипыСклада
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 279);
            this.Controls.Add(this.TableТипСклада);
            this.Controls.Add(this.ТипСкладаTB);
            this.Controls.Add(this.NavigatorТипСклада);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ТипыСклада";
            this.Text = "ТипыСклада";
            this.Load += new System.EventHandler(this.ТипыСклада_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableТипСклада)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorТипСклада)).EndInit();
            this.NavigatorТипСклада.ResumeLayout(false);
            this.NavigatorТипСклада.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TableТипСклада;
        private System.Windows.Forms.ToolStripButton FilterCancel;
        private System.Windows.Forms.ToolStripButton FilterAccept;
        private System.Windows.Forms.ToolStripTextBox ValueTB;
        private System.Windows.Forms.ToolStripComboBox FieldCB;
        private System.Windows.Forms.ToolStripButton ButtonUpdate;
        private System.Windows.Forms.ToolStripButton ButtonDelete;
        public System.Windows.Forms.TextBox ТипСкладаTB;
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
        private System.Windows.Forms.BindingNavigator NavigatorТипСклада;
    }
}