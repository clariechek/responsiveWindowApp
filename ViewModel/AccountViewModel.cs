using CommunityToolkit.Mvvm.ComponentModel;
using responsiveWindowApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace responsiveWindowApp.ViewModel
{
    public partial class AccountViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string fullname;

        [ObservableProperty]
        private string preferredName;

        [ObservableProperty]
        private string phone;

        [ObservableProperty]
        private string mobile;

        [ObservableProperty]
        private string pHome;

        [ObservableProperty]
        private string pWork;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string email2;

        [ObservableProperty]
        private string address;

        [ObservableProperty]
        private string suburb;

        [ObservableProperty]
        private string state;

        [ObservableProperty]
        private string postcode;

        [ObservableProperty]
        private string initialAuctionDate;

        [ObservableProperty]
        private string prevConsignments;

        [ObservableProperty]
        private string notes;

        [ObservableProperty]
        private ObservableCollection<Appraisal> estimates;

        public AccountViewModel()
        {
            // Initialize the AccountViewModel
            Fullname = "John Doe";
            PreferredName = "John";
            Phone = "03 1234 5678";
            Mobile = "0412 345 678";
            PHome = "03 1234 5678";
            PWork = "03 1234 5678";
            Email = "johndoe@outlook.com";
            Email2 = "johndoe2@outlook.com";
            Address = "123 Fake Street";
            Suburb = "Sydney";
            State = "NSW";
            Postcode = "2000";
            InitialAuctionDate = "April 2005";
            PrevConsignments = "5";
            Notes = "Example note....";
            Estimates = new ObservableCollection<Appraisal>
            {
                new Appraisal
                {
                    WineId = 1,
                    WineName = "Penfolds Grange",
                    Vintage = 2010,
                    Qty = "1",
                    Bottle = "$1000",
                    Rsv = 1,
                    Low = "$900",
                    High = "$1100",
                    Origin = "Australia",
                    Done = 1,
                    Source = "Auction",
                    Notes = "Example note...."
                },
                new Appraisal
                {
                    WineId = 2,
                    WineName = "Henschke Hill of Grace",
                    Vintage = 2010,
                    Qty = "1",
                    Bottle = "$1000",
                    Rsv = 1,
                    Low = "$900",
                    High = "$1100",
                    Origin = "Australia",
                    Done = 1,
                    Source = "Auction",
                    Notes = "Example note...."
                },
                new Appraisal
                {
                    WineId = 3,
                    WineName = "Chateau Lafite Rothschild",
                    Vintage = 2010,
                    Qty = "1",
                    Bottle = "$1000",
                    Rsv = 1,
                    Low = "$900",
                    High = "$1100",
                    Origin = "France",
                    Done = 1,
                    Source = "Auction",
                    Notes = "Example note...."
                }
            };
        }   
    }
}
