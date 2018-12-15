namespace CRM
{
    partial class SelectService
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
            this.GVServices = new Telerik.WinControls.UI.RadGridView();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.search = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.GVServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVServices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GVServices
            // 
            this.GVServices.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.GVServices.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "column4";
            gridViewTextBoxColumn1.Width = 30;
            gridViewTextBoxColumn2.HeaderText = "Название услуги";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 370;
            gridViewTextBoxColumn3.HeaderText = "Стоимость";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 70;
            gridViewCheckBoxColumn1.HeaderText = "Выбор";
            gridViewCheckBoxColumn1.Name = "column3";
            this.GVServices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1});
            this.GVServices.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GVServices.Name = "GVServices";
            this.GVServices.Size = new System.Drawing.Size(539, 357);
            this.GVServices.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(435, 375);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 24);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 375);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 24);
            this.search.TabIndex = 2;
            this.search.Text = "Поиск";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SelectService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 411);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.GVServices);
            this.Name = "SelectService";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Выбор услуг";
            this.Load += new System.EventHandler(this.SelectService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVServices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GVServices;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private Telerik.WinControls.UI.RadButton search;
    }
}
