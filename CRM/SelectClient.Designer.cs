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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.GVClients = new Telerik.WinControls.UI.RadGridView();
            this.search = new Telerik.WinControls.UI.RadButton();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GVClients
            // 
            this.GVClients.Location = new System.Drawing.Point(13, 13);
            // 
            // 
            // 
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 30;
            gridViewTextBoxColumn2.HeaderText = "Фамилия";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.HeaderText = "Имя";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 135;
            gridViewTextBoxColumn4.HeaderText = "Отчество";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 150;
            this.GVClients.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.GVClients.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GVClients.Name = "GVClients";
            this.GVClients.Size = new System.Drawing.Size(534, 355);
            this.GVClients.TabIndex = 0;
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
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(436, 374);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 24);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SelectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 410);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.GVClients);
            this.Name = "SelectClient";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Выбрать клиента";
            this.Load += new System.EventHandler(this.SelectClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVClients.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GVClients;
        private Telerik.WinControls.UI.RadButton search;
        private Telerik.WinControls.UI.RadButton btnSelect;
    }
}
