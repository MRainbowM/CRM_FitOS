namespace CRM
{
    partial class SelectClient
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.search = new Telerik.WinControls.UI.RadButton();
            this.del = new Telerik.WinControls.UI.RadButton();
            this.select = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(13, 13);
            // 
            // 
            // 
            gridViewTextBoxColumn1.HeaderText = "ID Клиента";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.HeaderText = "Фамилия";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 130;
            gridViewTextBoxColumn3.HeaderText = "Имя";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 130;
            gridViewTextBoxColumn4.HeaderText = "Отчество";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 130;
            gridViewCheckBoxColumn1.HeaderText = "Выбор";
            gridViewCheckBoxColumn1.Name = "column5";
            gridViewCheckBoxColumn1.Width = 47;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(534, 355);
            this.radGridView1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(229, 374);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 24);
            this.search.TabIndex = 5;
            this.search.Text = "Поиск";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(13, 374);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(110, 24);
            this.del.TabIndex = 4;
            this.del.Text = "Удалить";
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(436, 374);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(110, 24);
            this.select.TabIndex = 3;
            this.select.Text = "Выбрать";
            // 
            // SelectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 410);
            this.Controls.Add(this.search);
            this.Controls.Add(this.del);
            this.Controls.Add(this.select);
            this.Controls.Add(this.radGridView1);
            this.Name = "SelectClient";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Выбрать клиента";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton search;
        private Telerik.WinControls.UI.RadButton del;
        private Telerik.WinControls.UI.RadButton select;
    }
}
