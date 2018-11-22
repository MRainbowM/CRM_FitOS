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
            int k = radPageView.Pages.Count;
            for (int i = 0; i < k; i++)
            {
                radPageView.Pages.Remove(radPageView.Pages[0]);
            }

        }
        

        private void radMenuItem9_Click(object sender, EventArgs e)
        {

        }
        protected void ShowPage(Telerik.WinControls.UI.RadPageViewPage namePage)
        {
            int k = 0;
            for (int i = 0; i < radPageView.Pages.Count; i++)
            {
                string name = radPageView.Pages[i].Name;
                if (namePage.Name == name)
                {
                    k++;
                }
            }
            if (k == 0)
            {
                radPageView.Pages.Add(namePage);
            }
            radPageView.SelectedPage = namePage;
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
            ShowPage(radPageViewPageClients);
        }
        private void radMenuItemCards_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageCards);
        }
        private void radMenuItemWorkers_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageWorkers);
        }
        private void radMenuItemServices_Click(object sender, EventArgs e)
        {
            ShowPage(radPageViewPageServices);
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

        private void radGridViewCLients_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.Show();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard();
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

        private void addWorker_Click(object sender, EventArgs e)
        {
            WorkerCard workerCard = new WorkerCard();
            workerCard.Show();
        }

        private void radGridViewWorkers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            WorkerCard workerCard = new WorkerCard();
            workerCard.Show();
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
            serviceCard.Show();
        }

        private void radGridViewServices_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ServiceCard serviceCard = new ServiceCard();
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
    }
}
