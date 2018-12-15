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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dtDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.addService = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.addTrainer = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.GVClients = new Telerik.WinControls.UI.RadGridView();
            this.addClient = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.spPeople = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.spCost = new Telerik.WinControls.UI.RadSpinEditor();
            this.tbService = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.tbRoom = new Telerik.WinControls.UI.RadTextBox();
            this.addRoom = new Telerik.WinControls.UI.RadButton();
            this.btnReiteration = new Telerik.WinControls.UI.RadButton();
            this.tTime = new Telerik.WinControls.UI.RadTimePicker();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.tbMaxPeople = new Telerik.WinControls.UI.RadTextBox();
            this.lTrainer = new Telerik.WinControls.UI.RadListView();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.spMinuts = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.tTimeEnd = new Telerik.WinControls.UI.RadTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMinuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTimeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(13, 317);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(164, 20);
            this.dtDate.TabIndex = 2;
            this.dtDate.TabStop = false;
            this.dtDate.Text = "31 октября 2018 г.";
            this.dtDate.Value = new System.DateTime(2018, 10, 31, 18, 13, 58, 175);
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(488, 33);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(164, 24);
            this.addService.TabIndex = 4;
            this.addService.Text = "Выбрать услугу";
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 113);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Тренер(а)";
            // 
            // addTrainer
            // 
            this.addTrainer.Location = new System.Drawing.Point(13, 263);
            this.addTrainer.Name = "addTrainer";
            this.addTrainer.Size = new System.Drawing.Size(164, 24);
            this.addTrainer.TabIndex = 5;
            this.addTrainer.Text = "Выбрать тренера";
            this.addTrainer.Click += new System.EventHandler(this.sddTrainer_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(183, 113);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(38, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Бронь";
            // 
            // GVClients
            // 
            this.GVClients.Location = new System.Drawing.Point(183, 137);
            // 
            // 
            // 
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.Name = "column4";
            gridViewDecimalColumn1.Width = 30;
            gridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.HeaderText = "ID Карты";
            gridViewTextBoxColumn2.Name = "column3";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Оплата";
            gridViewTextBoxColumn3.Name = "column2";
            this.GVClients.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.GVClients.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GVClients.Name = "GVClients";
            this.GVClients.Size = new System.Drawing.Size(470, 357);
            this.GVClients.TabIndex = 6;
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(184, 525);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(138, 24);
            this.addClient.TabIndex = 6;
            this.addClient.Text = "Добавить клиента";
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(516, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // spPeople
            // 
            this.spPeople.Location = new System.Drawing.Point(107, 421);
            this.spPeople.Name = "spPeople";
            this.spPeople.Size = new System.Drawing.Size(70, 20);
            this.spPeople.TabIndex = 8;
            this.spPeople.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 293);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(30, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Дата";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(13, 475);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(61, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Стоимость";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(13, 423);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(73, 18);
            this.radLabel6.TabIndex = 3;
            this.radLabel6.Text = "Кол. человек";
            // 
            // spCost
            // 
            this.spCost.Location = new System.Drawing.Point(106, 474);
            this.spCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spCost.Name = "spCost";
            this.spCost.Size = new System.Drawing.Size(70, 20);
            this.spCost.TabIndex = 9;
            this.spCost.TabStop = false;
            // 
            // tbService
            // 
            this.tbService.Enabled = false;
            this.tbService.Location = new System.Drawing.Point(13, 37);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(469, 20);
            this.tbService.TabIndex = 10;
            this.tbService.TextChanged += new System.EventHandler(this.tbService_TextChanged);
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
            this.radLabel7.Location = new System.Drawing.Point(13, 63);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(69, 18);
            this.radLabel7.TabIndex = 11;
            this.radLabel7.Text = "Помещение";
            // 
            // tbRoom
            // 
            this.tbRoom.Enabled = false;
            this.tbRoom.Location = new System.Drawing.Point(13, 87);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(469, 20);
            this.tbRoom.TabIndex = 11;
            // 
            // addRoom
            // 
            this.addRoom.Location = new System.Drawing.Point(488, 83);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(164, 24);
            this.addRoom.TabIndex = 6;
            this.addRoom.Text = "Выбрать помещение";
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // btnReiteration
            // 
            this.btnReiteration.Location = new System.Drawing.Point(350, 525);
            this.btnReiteration.Name = "btnReiteration";
            this.btnReiteration.Size = new System.Drawing.Size(138, 24);
            this.btnReiteration.TabIndex = 8;
            this.btnReiteration.Text = "Сохранить и повторить";
            this.btnReiteration.Click += new System.EventHandler(this.reiteration_Click);
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(107, 343);
            this.tTime.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.tTime.MinValue = new System.DateTime(((long)(0)));
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(69, 20);
            this.tTime.TabIndex = 12;
            this.tTime.TabStop = false;
            this.tTime.Value = new System.DateTime(2018, 12, 13, 17, 24, 46, 743);
            this.tTime.ValueChanged += new System.EventHandler(this.tTime_ValueChanged);
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(13, 343);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(78, 18);
            this.radLabel8.TabIndex = 2;
            this.radLabel8.Text = "Время начала";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 524);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(13, 449);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(95, 18);
            this.radLabel9.TabIndex = 4;
            this.radLabel9.Text = "Макс. кол-во чел";
            // 
            // tbMaxPeople
            // 
            this.tbMaxPeople.Enabled = false;
            this.tbMaxPeople.Location = new System.Drawing.Point(107, 448);
            this.tbMaxPeople.Name = "tbMaxPeople";
            this.tbMaxPeople.Size = new System.Drawing.Size(69, 20);
            this.tbMaxPeople.TabIndex = 13;
            // 
            // lTrainer
            // 
            this.lTrainer.Location = new System.Drawing.Point(13, 137);
            this.lTrainer.Name = "lTrainer";
            this.lTrainer.Size = new System.Drawing.Size(163, 120);
            this.lTrainer.TabIndex = 14;
            // 
            // radLabel10
            // 
            this.radLabel10.Location = new System.Drawing.Point(13, 367);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(109, 18);
            this.radLabel10.TabIndex = 3;
            this.radLabel10.Text = "Длительность (мин)";
            // 
            // spMinuts
            // 
            this.spMinuts.Location = new System.Drawing.Point(123, 369);
            this.spMinuts.Name = "spMinuts";
            this.spMinuts.Size = new System.Drawing.Size(54, 20);
            this.spMinuts.TabIndex = 9;
            this.spMinuts.TabStop = false;
            this.spMinuts.ValueChanged += new System.EventHandler(this.spMinuts_ValueChanged);
            // 
            // radLabel11
            // 
            this.radLabel11.Location = new System.Drawing.Point(13, 396);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(73, 18);
            this.radLabel11.TabIndex = 3;
            this.radLabel11.Text = "Время конца";
            // 
            // tTimeEnd
            // 
            this.tTimeEnd.Enabled = false;
            this.tTimeEnd.Location = new System.Drawing.Point(108, 395);
            this.tTimeEnd.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.tTimeEnd.MinValue = new System.DateTime(((long)(0)));
            this.tTimeEnd.Name = "tTimeEnd";
            this.tTimeEnd.Size = new System.Drawing.Size(69, 20);
            this.tTimeEnd.TabIndex = 13;
            this.tTimeEnd.TabStop = false;
            this.tTimeEnd.Value = new System.DateTime(2018, 12, 13, 17, 24, 46, 743);
            // 
            // ScheduleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 561);
            this.Controls.Add(this.tTimeEnd);
            this.Controls.Add(this.radLabel11);
            this.Controls.Add(this.spMinuts);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.lTrainer);
            this.Controls.Add(this.tbMaxPeople);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.btnReiteration);
            this.Controls.Add(this.addRoom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbRoom);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.spCost);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.spPeople);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.GVClients);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.addTrainer);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.radLabel1);
            this.Name = "ScheduleCard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ScheduleCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMinuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTimeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadDateTimePicker dtDate;
        private Telerik.WinControls.UI.RadButton addService;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton addTrainer;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadGridView GVClients;
        private Telerik.WinControls.UI.RadButton addClient;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadSpinEditor spPeople;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadSpinEditor spCost;
        private Telerik.WinControls.UI.RadTextBox tbService;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox tbRoom;
        private Telerik.WinControls.UI.RadButton addRoom;
        private Telerik.WinControls.UI.RadButton btnReiteration;
        private Telerik.WinControls.UI.RadTimePicker tTime;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private System.Windows.Forms.ErrorProvider error;
        private Telerik.WinControls.UI.RadTextBox tbMaxPeople;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadListView lTrainer;
        private Telerik.WinControls.UI.RadTimePicker tTimeEnd;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadSpinEditor spMinuts;
        private Telerik.WinControls.UI.RadLabel radLabel10;
    }
}
