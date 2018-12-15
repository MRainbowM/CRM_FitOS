using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CRM
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            int k = PageView.Pages.Count;
            for (int i = 0; i < k; i++)
            {
                PageView.Pages.Remove(PageView.Pages[0]);
            }

        }
        //для карточек
        public static int ID_Client;
        public static int ID_Trainer;
        public static int ID_Service;
        public static int ID_Tariff;
        public static int ID_Card;
        public static int ID_Room;
        public static int ID_Schedule;

        //

        private void radMenuItem9_Click(object sender, EventArgs e)
        {

        }
        protected void ShowPage(Telerik.WinControls.UI.RadPageViewPage namePage)
        {
            int k = 0;
            for (int i = 0; i < PageView.Pages.Count; i++)
            {
                string name = PageView.Pages[i].Name;
                if (namePage.Name == name)
                {
                    k++;
                }
            }
            if (k == 0)
            {
                PageView.Pages.Add(namePage);
            }
            PageView.SelectedPage = namePage;
        }
        private void radMenuItemOperations_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageOperation);
        }
        private void radMenuItemSchedule_Click(object sender, EventArgs e)
        {
            ShowPage(pvSchedule);
        }
        private void radMenuItemCLients_Click(object sender, EventArgs e)
        {
            ShowPage(pvClients);
        }
        private void radMenuItemCards_Click(object sender, EventArgs e)
        {
            ShowPage(pvCards);
        }
        private void radMenuItemWorkers_Click(object sender, EventArgs e)
        {
            ShowPage(pvTrainers);
        }
        private void radMenuItemServices_Click(object sender, EventArgs e)
        {
            ShowPage(pvServices);
        }
        private void radMenuItemTariffs_Click(object sender, EventArgs e)
        {
            ShowPage(pvTariffs);
        }
        private void radMenuItemRooms_Click(object sender, EventArgs e)
        {
            ShowPage(pvRooms);
        }
        private void radMenuItemPay_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageRepaymonts);
        }
        private void radMenuItemStatistics_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageStatistics);
        }
        private void Options_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
        }


        private void radGridView3_Click(object sender, EventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.ShowDialog();
        }
        
        private void radGridViewPay_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            PayCard payCard = new PayCard();
            payCard.ShowDialog();
        }
        
        //добавление записей
        private void AddClient_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.StateSave = false;
            clientCard.ShowDialog();
            RefreshTable();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.StateSave = false;
            CardCard.ID_Client = 0;
            cardCard.ShowDialog();
            RefreshTable();
        }

        private void addTariff_Click(object sender, EventArgs e)
        {
            TariffCard tariffCard = new TariffCard();
            tariffCard.StateSave = false;
            tariffCard.ShowDialog();
            RefreshTable();
        }

        private void addTrainer_Click(object sender, EventArgs e)
        {
            TrainerCard trainerCard = new TrainerCard();
            trainerCard.StateSave = false;
            trainerCard.ShowDialog();
            RefreshTable();
        }

        private void addPay_Click(object sender, EventArgs e)
        {
            PayCard payCard = new PayCard();
            payCard.ShowDialog();
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            RoomCard roomCard = new RoomCard();
            roomCard.StateSave = false;
            roomCard.ShowDialog();
            RefreshTable();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            ServiceCard serviceCard = new ServiceCard();
            serviceCard.StateSave = false;
            serviceCard.ShowDialog();
            RefreshTable();
        }

        private void addSchedule_Click(object sender, EventArgs e)
        {
            ScheduleCard scheduleCard = new ScheduleCard();
            scheduleCard.StateSave = false;
            scheduleCard.ShowDialog();
            RefreshTable();
        }

        //ПОИСК
        private void searchClient_Click(object sender, EventArgs e)
        {
            SearchClients searchClients = new SearchClients();
            searchClients.ShowDialog();
        }

        private void searchCard_Click(object sender, EventArgs e)
        {
            SearchCard searchCard = new SearchCard();
            searchCard.ShowDialog();
        }

        private void searchTariff_Click(object sender, EventArgs e)
        {
            SearchTariff searchTariff = new SearchTariff();
            searchTariff.ShowDialog();
        }

        private void searchWorker_Click(object sender, EventArgs e)
        {
            SearchWorker searchWorker = new SearchWorker();
            searchWorker.ShowDialog();
        }

        private void searchRoom_Click(object sender, EventArgs e)
        {
            SearchRoom searchRoom = new SearchRoom();
            searchRoom.ShowDialog();
        }

        private void searchService_Click(object sender, EventArgs e)
        {
            SearchService searchService = new SearchService();
            searchService.ShowDialog();
        }

        private void searchSchedule_Click(object sender, EventArgs e)
        {
            SearchSchedule searchSchedule = new SearchSchedule();
            searchSchedule.ShowDialog();
        }

        private void searchPay_Click(object sender, EventArgs e)
        {
            SearchPay searchPay = new SearchPay();
            searchPay.ShowDialog();
        }


        //
        private void delSchedule_Click(object sender, EventArgs e)
        {
            SelectSchedule selectSchedule = new SelectSchedule();
            selectSchedule.ShowDialog();
        }

        private void scheduleRoom_Click(object sender, EventArgs e)
        {
            ScheduleRoom scheduleRoom = new ScheduleRoom();
            scheduleRoom.ShowDialog();
        }

        private void scheduleRoom2_Click(object sender, EventArgs e)
        {
            ScheduleRoom scheduleRoom = new ScheduleRoom();
            scheduleRoom.ShowDialog();
        }

        

        private void PageView_SelectedPageChanged(object sender, EventArgs e) //ИЗМЕНЕНИЕ ВКЛАДОК
        {
            RefreshTable();
        }
        
        private void RefreshTable() // обновить/заполнить таблицу
        {
            if (PageView.SelectedPage == pvClients)
            {
                GVClients.Rows.Clear();
                List<Client> Clients = Client.GetAll();
                for (int i = 0; i <= Clients.Count - 1; i++)// создание таблицы с КЛИЕНТАМИ
                {
                    GVClients.Rows.Add(Clients[i].id, Clients[i].surname, Clients[i].name, Clients[i].middleName, Clients[i].phone);
                }
            }
            if (PageView.SelectedPage == pvTrainers)
            {
                GVTrainers.Rows.Clear();
                List<Trainer> Trainers = Trainer.GetAll();
                for (int i = 0; i <= Trainers.Count - 1; i++)// создание таблицы с ТРЕНЕРАМИ
                {
                    GVTrainers.Rows.Add(Trainers[i].id, Trainers[i].surname, Trainers[i].name, Trainers[i].middleName, Trainers[i].phone);
                }
            }
            if (PageView.SelectedPage == pvServices)
            {
                GVServices.Rows.Clear();
                List<Service> Services = Service.GetAll();
                for (int i = 0; i <= Services.Count - 1; i++)// создание таблицы с УСЛУГАМИ
                {
                    GVServices.Rows.Add(Services[i].id, Services[i].name, Services[i].cost, Services[i].numberOfPeople);
                }
            }
            if (PageView.SelectedPage == pvTariffs)
            {
                GVTariffs.Rows.Clear();
                List<Tariff> Tariffs = Tariff.GetAll();
                for (int i = 0; i <= Tariffs.Count - 1; i++)// создание таблицы с УСЛУГАМИ
                {
                    GVTariffs.Rows.Add(Tariffs[i].id, Tariffs[i].name, Tariffs[i].totalCost, Tariffs[i].startDate, Tariffs[i].expirationDate);
                }
            }
            if (PageView.SelectedPage == pvTariffs)
            {
                GVTariffs.Rows.Clear();
                List<Tariff> Tariffs = Tariff.GetAll();
                for (int i = 0; i <= Tariffs.Count - 1; i++)// создание таблицы с УСЛУГАМИ
                {
                    GVTariffs.Rows.Add(Tariffs[i].id, Tariffs[i].name, Tariffs[i].totalCost, Tariffs[i].startDate, Tariffs[i].expirationDate);
                }
            }
            if (PageView.SelectedPage == pvCards)
            {
                GVCard.Rows.Clear();
                List<Card> CardList = Card.GetAll();
                for (int i = 0; i <= CardList.Count - 1; i++)// создание таблицы с КАРТАМИ
                {
                    GVCard.Rows.Add(CardList[i].id, CardList[i].n_Card, Tariff.FindByID(CardList[i].id_Tariff).name, CardList[i].id_User,
                        Client.FindByID(CardList[i].id_User).surname, Client.FindByID(CardList[i].id_User).name,
                        Client.FindByID(CardList[i].id_User).middleName, CardList[i].dateOfCreation);
                }
            }
            if (PageView.SelectedPage == pvRooms)
            {
                GVRooms.Rows.Clear();
                List<Room> RoomList = Room.GetAll();
                for (int i = 0; i < RoomList.Count; i++)// создание таблицы с ПОМЕЩЕНИЯМИ
                {
                    GVRooms.Rows.Add(RoomList[i].id, RoomList[i].name, RoomList[i].equipment, RoomList[i].capacity);
                }
            }
            if (PageView.SelectedPage == pvSchedule)
            {
                GVSchedule.Rows.Clear();
                List<ScheduleService> ScheduleServiceList = ScheduleService.GetAll();
                for (int i = 0; i < ScheduleServiceList.Count; i++)// создание таблицы с РАСПИСАНИЕМ
                {
                    GVSchedule.Rows.Add(ScheduleServiceList[i].ID, ScheduleServiceList[i].Date, Service.FindByID(ScheduleServiceList[i].ID_Service).name
                        /*ScheduleServiceList[i].equipment, RoomList[i].capacity*/);
                }
            }

        }

        private void RadForm1_Activated(object sender, EventArgs e)
        {
            RefreshTable();
        }


        // двойной клик по записи (изменение записи)
        private void GVClients_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.StateSave = true;

            int row = GVClients.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVClients.Rows[row].Cells[0].Value);
            ID_Client = d;
            clientCard.ShowDialog();
            RefreshTable();
        }

        private void GVTrainers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            TrainerCard trainerCard = new TrainerCard();
            trainerCard.StateSave = true;

            int row = GVTrainers.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVTrainers.Rows[row].Cells[0].Value);
            ID_Trainer = d;
            trainerCard.ShowDialog();
            RefreshTable();

        }

        private void GVServices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ServiceCard serviceCard = new ServiceCard();
            serviceCard.StateSave = true;

            int row = GVServices.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVServices.Rows[row].Cells[0].Value);
            ID_Service = d;
            serviceCard.ShowDialog();
            RefreshTable();

            //radGridView1.Columns["imgCol"].SortOrder = RadSortOrder.Ascending;

        }

        private void GVTariffs_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            TariffCard tariffCard = new TariffCard();
            tariffCard.StateSave = true;

            int row = GVTariffs.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVTariffs.Rows[row].Cells[0].Value);
            ID_Tariff = d;
            tariffCard.ShowDialog();
            RefreshTable();
        }

        private void GVCard_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.StateSave = true;

            int row = GVCard.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVCard.Rows[row].Cells[0].Value);
            ID_Card = d;
            cardCard.ShowDialog();
            RefreshTable();
        }

        private void GVRooms_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RoomCard roomCard = new RoomCard();
            roomCard.StateSave = true;

            int row = GVRooms.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVRooms.Rows[row].Cells[0].Value);
            ID_Room = d;
            roomCard.ShowDialog();
            RefreshTable();
        }

        private void GVSchedule_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            ScheduleCard scheduleCard = new ScheduleCard();
            scheduleCard.StateSave = true;

            int row = GVSchedule.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVSchedule.Rows[row].Cells[0].Value);
            ID_Schedule = d;
            scheduleCard.ShowDialog();
            RefreshTable();
        }
    }
    
}
