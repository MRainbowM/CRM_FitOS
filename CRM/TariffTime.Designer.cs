namespace CRM
{
    partial class TariffTime
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn5 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn6 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn7 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            gridViewTextBoxColumn1.HeaderText = "column9";
            gridViewTextBoxColumn1.Name = "column9";
            gridViewComboBoxColumn1.HeaderText = "column2";
            gridViewComboBoxColumn1.Name = "column2";
            gridViewComboBoxColumn2.HeaderText = "column3";
            gridViewComboBoxColumn2.Name = "column3";
            gridViewComboBoxColumn3.HeaderText = "column4";
            gridViewComboBoxColumn3.Name = "column4";
            gridViewComboBoxColumn4.HeaderText = "column5";
            gridViewComboBoxColumn4.Name = "column5";
            gridViewComboBoxColumn5.HeaderText = "column6";
            gridViewComboBoxColumn5.Name = "column6";
            gridViewComboBoxColumn6.HeaderText = "column7";
            gridViewComboBoxColumn6.Name = "column7";
            gridViewComboBoxColumn7.HeaderText = "column8";
            gridViewComboBoxColumn7.Name = "column8";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2,
            gridViewComboBoxColumn3,
            gridViewComboBoxColumn4,
            gridViewComboBoxColumn5,
            gridViewComboBoxColumn6,
            gridViewComboBoxColumn7});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(658, 355);
            this.radGridView1.TabIndex = 0;
            // 
            // TariffTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 379);
            this.Controls.Add(this.radGridView1);
            this.Name = "TariffTime";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TariffTime";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
