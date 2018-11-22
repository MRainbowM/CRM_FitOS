namespace CRM
{
    partial class Autorizatsiya
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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.enter = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(38, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Логин";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(12, 36);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(212, 20);
            this.radTextBox1.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(45, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Пароль";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(12, 86);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(212, 20);
            this.radTextBox2.TabIndex = 2;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(12, 127);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(98, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Смена пароля";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(126, 127);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(98, 24);
            this.enter.TabIndex = 4;
            this.enter.Text = "Вход";
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Autorizatsiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 163);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Name = "Autorizatsiya";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton enter;
    }
}
