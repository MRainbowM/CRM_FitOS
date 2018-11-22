namespace CRM
{
    partial class SearchService
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor2 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Название";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(13, 38);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(300, 20);
            this.radTextBox1.TabIndex = 1;
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Location = new System.Drawing.Point(7, 45);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditor1.TabIndex = 2;
            this.radSpinEditor1.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(7, 21);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(19, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "От";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(192, 21);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(21, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "До";
            // 
            // radSpinEditor2
            // 
            this.radSpinEditor2.Location = new System.Drawing.Point(192, 45);
            this.radSpinEditor2.Name = "radSpinEditor2";
            this.radSpinEditor2.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditor2.TabIndex = 3;
            this.radSpinEditor2.TabStop = false;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(201, 148);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Поиск";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radSpinEditor1);
            this.radGroupBox1.Controls.Add(this.radSpinEditor2);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.HeaderText = "Стоимость";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 64);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(301, 78);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Стоимость";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(13, 148);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 14;
            this.radButton2.Text = "Очистить";
            // 
            // SearchService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 176);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Name = "SearchService";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Поиск услуги";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}
