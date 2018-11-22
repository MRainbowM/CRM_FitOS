namespace CRM
{
    partial class ScheduleCard
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.addService = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckedListBox1 = new Telerik.WinControls.UI.RadCheckedListBox();
            this.sddTrainer = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.addClient = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor2 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.getRoom = new Telerik.WinControls.UI.RadButton();
            this.reiteration = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sddTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reiteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Location = new System.Drawing.Point(13, 117);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePicker1.TabIndex = 2;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "31 октября 2018 г.";
            this.radDateTimePicker1.Value = new System.DateTime(2018, 10, 31, 18, 13, 58, 175);
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(13, 63);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(164, 24);
            this.addService.TabIndex = 4;
            this.addService.Text = "Выбрать услугу";
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 143);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Тренер(а)";
            // 
            // radCheckedListBox1
            // 
            this.radCheckedListBox1.Location = new System.Drawing.Point(13, 167);
            this.radCheckedListBox1.Name = "radCheckedListBox1";
            this.radCheckedListBox1.Size = new System.Drawing.Size(164, 60);
            this.radCheckedListBox1.TabIndex = 5;
            // 
            // sddTrainer
            // 
            this.sddTrainer.Location = new System.Drawing.Point(13, 233);
            this.sddTrainer.Name = "sddTrainer";
            this.sddTrainer.Size = new System.Drawing.Size(164, 24);
            this.sddTrainer.TabIndex = 5;
            this.sddTrainer.Text = "Выбрать тренера";
            this.sddTrainer.Click += new System.EventHandler(this.sddTrainer_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(183, 13);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(38, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Бронь";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(183, 37);
            // 
            // 
            // 
            gridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.HeaderText = "ID Карты";
            gridViewTextBoxColumn2.Name = "column3";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Оплата";
            gridViewTextBoxColumn3.Name = "column2";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(470, 350);
            this.radGridView1.TabIndex = 6;
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(183, 393);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(138, 24);
            this.addClient.TabIndex = 6;
            this.addClient.Text = "Добавить клиента";
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(516, 393);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(138, 24);
            this.radButton4.TabIndex = 7;
            this.radButton4.Text = "Сохранить";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Location = new System.Drawing.Point(92, 343);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.Size = new System.Drawing.Size(86, 20);
            this.radSpinEditor1.TabIndex = 8;
            this.radSpinEditor1.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 93);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Дата и время";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(14, 367);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(61, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Стоимость";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(13, 343);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(73, 18);
            this.radLabel6.TabIndex = 3;
            this.radLabel6.Text = "Кол. человек";
            // 
            // radSpinEditor2
            // 
            this.radSpinEditor2.Location = new System.Drawing.Point(92, 367);
            this.radSpinEditor2.Name = "radSpinEditor2";
            this.radSpinEditor2.Size = new System.Drawing.Size(86, 20);
            this.radSpinEditor2.TabIndex = 9;
            this.radSpinEditor2.TabStop = false;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Enabled = false;
            this.radTextBox1.Location = new System.Drawing.Point(13, 37);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(164, 20);
            this.radTextBox1.TabIndex = 10;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Услуга";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(13, 263);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(69, 18);
            this.radLabel7.TabIndex = 11;
            this.radLabel7.Text = "Помещение";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Enabled = false;
            this.radTextBox2.Location = new System.Drawing.Point(13, 287);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(164, 20);
            this.radTextBox2.TabIndex = 11;
            // 
            // getRoom
            // 
            this.getRoom.Location = new System.Drawing.Point(13, 313);
            this.getRoom.Name = "getRoom";
            this.getRoom.Size = new System.Drawing.Size(164, 24);
            this.getRoom.TabIndex = 6;
            this.getRoom.Text = "Выбрать помещение";
            this.getRoom.Click += new System.EventHandler(this.getRoom_Click);
            // 
            // reiteration
            // 
            this.reiteration.Location = new System.Drawing.Point(349, 393);
            this.reiteration.Name = "reiteration";
            this.reiteration.Size = new System.Drawing.Size(138, 24);
            this.reiteration.TabIndex = 8;
            this.reiteration.Text = "Повторение занятия";
            this.reiteration.Click += new System.EventHandler(this.reiteration_Click);
            // 
            // ScheduleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 424);
            this.Controls.Add(this.reiteration);
            this.Controls.Add(this.getRoom);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radSpinEditor2);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radSpinEditor1);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.sddTrainer);
            this.Controls.Add(this.radCheckedListBox1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radLabel1);
            this.Name = "ScheduleCard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Расписание";
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckedListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sddTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reiteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadButton addService;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCheckedListBox radCheckedListBox1;
        private Telerik.WinControls.UI.RadButton sddTrainer;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton addClient;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadButton getRoom;
        private Telerik.WinControls.UI.RadButton reiteration;
    }
}
