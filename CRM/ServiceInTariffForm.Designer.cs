namespace CRM
{
    partial class ServiceInTariffForm
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
            this.spAmount = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.spPeriodicity = new Telerik.WinControls.UI.RadSpinEditor();
            this.btnAddService = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.getService = new Telerik.WinControls.UI.RadButton();
            this.cmbServices = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodicity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // spAmount
            // 
            this.spAmount.Location = new System.Drawing.Point(12, 86);
            this.spAmount.Name = "spAmount";
            this.spAmount.Size = new System.Drawing.Size(56, 20);
            this.spAmount.TabIndex = 1;
            this.spAmount.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Услуга";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(43, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Кол-во";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(79, 62);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(88, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Периодичность";
            // 
            // spPeriodicity
            // 
            this.spPeriodicity.Location = new System.Drawing.Point(111, 86);
            this.spPeriodicity.Name = "spPeriodicity";
            this.spPeriodicity.Size = new System.Drawing.Size(56, 20);
            this.spPeriodicity.TabIndex = 2;
            this.spPeriodicity.TabStop = false;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(12, 112);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(155, 24);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(295, 112);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(155, 24);
            this.radButton2.TabIndex = 6;
            this.radButton2.Text = "Удалить";
            // 
            // getService
            // 
            this.getService.Location = new System.Drawing.Point(295, 82);
            this.getService.Name = "getService";
            this.getService.Size = new System.Drawing.Size(155, 24);
            this.getService.TabIndex = 6;
            this.getService.Text = "Посмотреть услугу";
            this.getService.Click += new System.EventHandler(this.getService_Click);
            // 
            // cmbServices
            // 
            this.cmbServices.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbServices.Location = new System.Drawing.Point(12, 36);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(438, 20);
            this.cmbServices.TabIndex = 7;
            this.cmbServices.Text = "radDropDownList1";
            // 
            // ServiceInTariffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 149);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.getService);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.spPeriodicity);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.spAmount);
            this.Name = "ServiceInTariffForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Добавить услуги в тариф";
            this.Load += new System.EventHandler(this.ServiceInTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodicity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadSpinEditor spAmount;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadSpinEditor spPeriodicity;
        private Telerik.WinControls.UI.RadButton btnAddService;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton getService;
        private Telerik.WinControls.UI.RadDropDownList cmbServices;
    }
}
