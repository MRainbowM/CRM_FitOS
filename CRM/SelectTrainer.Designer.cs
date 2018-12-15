namespace CRM
{
    partial class SelectTrainer
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
            this.search = new Telerik.WinControls.UI.RadButton();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.GVTrainers = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTrainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTrainers.MasterTemplate)).BeginInit();
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
            // GVTrainers
            // 
            this.GVTrainers.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            gridViewTextBoxColumn1.HeaderText = "ID Тренера";
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
            this.GVTrainers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1});
            this.GVTrainers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GVTrainers.Name = "GVTrainers";
            this.GVTrainers.Size = new System.Drawing.Size(534, 355);
            this.GVTrainers.TabIndex = 6;
            // 
            // SelectTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 410);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.GVTrainers);
            this.Name = "SelectTrainer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Выбрать работника";
            this.Load += new System.EventHandler(this.SelectTrainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTrainers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTrainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton search;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private Telerik.WinControls.UI.RadGridView GVTrainers;
    }
}
