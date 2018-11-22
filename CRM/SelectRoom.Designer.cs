namespace CRM
{
    partial class SelectRoom
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.search = new Telerik.WinControls.UI.RadButton();
            this.del = new Telerik.WinControls.UI.RadButton();
            this.select = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(228, 373);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 24);
            this.search.TabIndex = 9;
            this.search.Text = "Поиск";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(12, 373);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(110, 24);
            this.del.TabIndex = 8;
            this.del.Text = "Удалить";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(435, 373);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(110, 24);
            this.select.TabIndex = 7;
            this.select.Text = "Выбрать";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            gridViewTextBoxColumn1.HeaderText = "Название";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 200;
            gridViewTextBoxColumn2.HeaderText = "Оборудование";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 210;
            gridViewTextBoxColumn3.HeaderText = "Вмест-ть";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 60;
            gridViewCheckBoxColumn1.HeaderText = "Выбор";
            gridViewCheckBoxColumn1.Name = "column5";
            gridViewCheckBoxColumn1.Width = 47;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(534, 355);
            this.radGridView1.TabIndex = 6;
            // 
            // SelectRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 409);
            this.Controls.Add(this.search);
            this.Controls.Add(this.del);
            this.Controls.Add(this.select);
            this.Controls.Add(this.radGridView1);
            this.Name = "SelectRoom";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Выбрать помещение";
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton search;
        private Telerik.WinControls.UI.RadButton del;
        private Telerik.WinControls.UI.RadButton select;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
