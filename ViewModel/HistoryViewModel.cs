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
    public partial class HistoryViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private ObservableCollection<Estimate> previousEstimates;

        [ObservableProperty]
        private ObservableCollection<Consignment> previousConsignments;

        [ObservableProperty]
        private string notes;

        [ObservableProperty]
        private ObservableCollection<Appraisal> estimate;

        public HistoryViewModel()
        {
            // Initialize the HistoryViewModel
            PreviousEstimates = new ObservableCollection<Estimate>
            {
                new Estimate
                {
                    EstimateNumber = 1,
                    Value = "$1000",
                    Bottles = 10,
                    Shipping = "$50",
                    Sub = "$1050",
                    EstimateBoxes = 1,
                    Date = "01/01/2021",
                    Conv = "Yes"
                },
                new Estimate
                {
                    EstimateNumber = 2,
                    Value = "$2000",
                    Bottles = 20,
                    Shipping = "$100",
                    Sub = "$2100",
                    EstimateBoxes = 2,
                    Date = "02/02/2021",
                    Conv = "No"
                },
                new Estimate
                {
                    EstimateNumber = 3,
                    Value = "$3000",
                    Bottles = 30,
                    Shipping = "$150",
                    Sub = "$3150",
                    EstimateBoxes = 3,
                    Date = "03/03/2021",
                    Conv = "Yes"
                }
            };
            PreviousConsignments = new ObservableCollection<Consignment>
            {
                new Consignment
                {
                    Number = 1,
                    Value = "$1000",
                    DateReceived = "10/04/2021",
                    InitialAuction = "01/01/2021",
                    Boxes = 2,
                    Insurance = "",
                    Conv = ""
                },
                new Consignment
                {
                    Number = 2,
                    Value = "$1000",
                    DateReceived = "10/04/2021",
                    InitialAuction = "01/01/2021",
                    Boxes = 2,
                    Insurance = "",
                    Conv = ""
                },
                new Consignment
                {
                    Number = 3,
                    Value = "$1000",
                    DateReceived = "10/04/2021",
                    InitialAuction = "01/01/2021",
                    Boxes = 2,
                    Insurance = "",
                    Conv = ""
                }
            };  
            Notes = "Example note...."; 
            Estimate = new ObservableCollection<Appraisal>
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
