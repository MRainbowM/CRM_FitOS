namespace CRM
{
    partial class OptionsForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tbWayPhoto = new Telerik.WinControls.UI.RadTextBox();
            this.btnWay = new Telerik.WinControls.UI.RadButton();
            this.selectDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWayPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(169, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Путь до папки с фотографиями";
            // 
            // tbWayPhoto
            // 
            this.tbWayPhoto.Enabled = false;
            this.tbWayPhoto.Location = new System.Drawing.Point(12, 36);
            this.tbWayPhoto.Name = "tbWayPhoto";
            this.tbWayPhoto.Size = new System.Drawing.Size(169, 20);
            this.tbWayPhoto.TabIndex = 1;
            // 
            // btnWay
            // 
            this.btnWay.Location = new System.Drawing.Point(12, 62);
            this.btnWay.Name = "btnWay";
            this.btnWay.Size = new System.Drawing.Size(169, 24);
            this.btnWay.TabIndex = 2;
            this.btnWay.Text = "Выбрать путь";
            this.btnWay.Click += new System.EventHandler(this.btnWay_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 101);
            this.Controls.Add(this.btnWay);
            this.Controls.Add(this.tbWayPhoto);
            this.Controls.Add(this.radLabel1);
            this.Name = "OptionsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWayPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox tbWayPhoto;
        private Telerik.WinControls.UI.RadButton btnWay;
        private System.Windows.Forms.FolderBrowserDialog selectDialog;
    }
}
