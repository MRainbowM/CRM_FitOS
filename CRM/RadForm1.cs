using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            ShowPage(radPageViewPageSchedule);
        }
        private void radMenuItemCLients_Click(object sender, EventArgs e)
        {
            ShowPage(pvClients);
        }
        private void radMenuItemCards_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageCards);
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
            ShowPage(radPageViewPageTariffs);
        }
        private void radMenuItemRooms_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageRooms);
        }
        private void radMenuItemPay_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageRepaymonts);
        }
        private void radMenuItemStatistics_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageStatistics);
        }


        private void AddClient_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.StateSave = false;
            clientCard.Show();
        }

        private void radGridView3_Click(object sender, EventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.Show();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.Show();
        }

        private void radGridView3_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.Show();
        }

        private void radGridViewTariff_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            TariffCard tariffCard = new TariffCard();
            tariffCard.Show();
        }

        private void addTariff_Click(object sender, EventArgs e)
        {
            TariffCard tariffCard = new TariffCard();
            tariffCard.Show();
        }

        private void addTrainer_Click(object sender, EventArgs e)
        {
            TrainerCard trainerCard = new TrainerCard();
            trainerCard.StateSave = false;
            trainerCard.Show();
        }


        private void radGridViewPay_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            PayCard payCard = new PayCard();
            payCard.Show();
        }

        private void addPay_Click(object sender, EventArgs e)
        {
            PayCard payCard = new PayCard();
            payCard.Show();
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            RoomCard roomCard = new RoomCard();
            roomCard.Show();
        }

        private void radGridViewRoom_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RoomCard roomCard = new RoomCard();
            roomCard.Show();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            ServiceCard serviceCard = new ServiceCard();
            serviceCard.StateSave = false;
            serviceCard.Show();
        }

       
        private void searchClient_Click(object sender, EventArgs e)
        {
            SearchClients searchClients = new SearchClients();
            searchClients.Show();
        }

        private void searchCard_Click(object sender, EventArgs e)
        {
            SearchCard searchCard = new SearchCard();
            searchCard.Show();
        }

        private void searchTariff_Click(object sender, EventArgs e)
        {
            SearchTariff searchTariff = new SearchTariff();
            searchTariff.Show();
        }

        private void searchWorker_Click(object sender, EventArgs e)
        {
            SearchWorker searchWorker = new SearchWorker();
            searchWorker.Show();
        }

        private void searchRoom_Click(object sender, EventArgs e)
        {
            SearchRoom searchRoom = new SearchRoom();
            searchRoom.Show();
        }

        private void searchService_Click(object sender, EventArgs e)
        {
            SearchService searchService = new SearchService();
            searchService.Show();
        }

        private void addSchedule_Click(object sender, EventArgs e)
        {
            ScheduleCard scheduleCard = new ScheduleCard();
            scheduleCard.Show();
        }

        private void searchSchedule_Click(object sender, EventArgs e)
        {
            SearchSchedule searchSchedule = new SearchSchedule();
            searchSchedule.Show();
        }

        private void delSchedule_Click(object sender, EventArgs e)
        {
            SelectSchedule selectSchedule = new SelectSchedule();
            selectSchedule.Show();
        }

        private void scheduleRoom_Click(object sender, EventArgs e)
        {
            ScheduleRoom scheduleRoom = new ScheduleRoom();
            scheduleRoom.Show();
        }

        private void scheduleRoom2_Click(object sender, EventArgs e)
        {
            ScheduleRoom scheduleRoom = new ScheduleRoom();
            scheduleRoom.Show();
        }

        private void searchPay_Click(object sender, EventArgs e)
        {
            SearchPay searchPay = new SearchPay();
            searchPay.Show();
        }

        private void PageView_SelectedPageChanged(object sender, EventArgs e)
        {
            if (PageView.SelectedPage == pvClients) 
            {
                GVClients.Rows.Clear();
                List<Client> Clients = Client.GetAll();
                for (int i = 0; i <= Clients.Count - 1; i++)// создание таблицы с КЛИЕНТАМИ
                {
                    GVClients.Rows.Add(Clients[i].id,Clients[i].surname, Clients[i].name, Clients[i].middleName, Clients[i].phone);
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
        }
        

        private void GVClients_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.StateSave = true;

            int row = GVClients.CurrentCell.RowIndex;
            string d = (String)GVClients.Rows[row].Cells[0].Value;
            ID_Client = Int32.Parse(d);
            clientCard.Show();
        }

        private void GVTrainers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            TrainerCard trainerCard = new TrainerCard();
            trainerCard.StateSave = true;

            int row = GVTrainers.CurrentCell.RowIndex;
            string d = (String)GVTrainers.Rows[row].Cells[0].Value;
            ID_Trainer = Int32.Parse(d);
            trainerCard.Show();

        }

        private void GVServices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ServiceCard serviceCard = new ServiceCard();
            serviceCard.StateSave = true;

            int row = GVServices.CurrentCell.RowIndex;
            string d = (String)GVServices.Rows[row].Cells[0].Value;
            ID_Service = Int32.Parse(d);
            serviceCard.Show();
        }
    }
}
