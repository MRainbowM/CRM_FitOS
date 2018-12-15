namespace CRM
{
    partial class SelectTariff
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.search = new Telerik.WinControls.UI.RadButton();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.GVTariffs = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTariffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTariffs.MasterTemplate)).BeginInit();
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
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(435, 373);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 24);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // GVTariffs
            // 
            this.GVTariffs.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.GVTariffs.MasterTemplate.AllowAddNewRow = false;
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.Name = "column3";
            gridViewDecimalColumn1.Width = 30;
            gridViewTextBoxColumn1.HeaderText = "Название";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.HeaderText = "Стоимость";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 80;
            this.GVTariffs.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.GVTariffs.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GVTariffs.Name = "GVTariffs";
            this.GVTariffs.ReadOnly = true;
            this.GVTariffs.Size = new System.Drawing.Size(534, 355);
            this.GVTariffs.TabIndex = 6;
            // 
            // SelectTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 408);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.GVTariffs);
            this.Name = "SelectTariff";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Выбор тарифа";
            this.Load += new System.EventHandler(this.SelectTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTariffs.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTariffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton search;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private Telerik.WinControls.UI.RadGridView GVTariffs;
    }
}
