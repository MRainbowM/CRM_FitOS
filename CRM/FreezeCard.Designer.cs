namespace CRM
{
    partial class FreezeCard
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
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Location = new System.Drawing.Point(12, 86);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker1.TabIndex = 0;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "31 октября 2018 г.";
            this.radDateTimePicker1.Value = new System.DateTime(2018, 10, 31, 17, 55, 50, 922);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(52, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "ID Карты";
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.Enabled = false;
            this.radTextBoxControl1.Location = new System.Drawing.Point(12, 36);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(164, 20);
            this.radTextBoxControl1.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(87, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Начальная дата";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 112);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(82, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Конечная дата";
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.Location = new System.Drawing.Point(12, 136);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker2.TabIndex = 1;
            this.radDateTimePicker2.TabStop = false;
            this.radDateTimePicker2.Text = "31 октября 2018 г.";
            this.radDateTimePicker2.Value = new System.DateTime(2018, 10, 31, 17, 55, 50, 922);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(15, 212);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(164, 24);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Заморозить";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Location = new System.Drawing.Point(15, 186);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.Size = new System.Drawing.Size(79, 20);
            this.radSpinEditor1.TabIndex = 5;
            this.radSpinEditor1.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 162);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(135, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Остаток дней заморозки";
            // 
            // FreezeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 248);
            this.Controls.Add(this.radSpinEditor1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radDateTimePicker2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTextBoxControl1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radDateTimePicker1);
            this.Name = "FreezeCard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Заморозка карты";
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
