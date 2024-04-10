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
    public partial class TaskSummaryViewModel : ObservableRecipient
    {
        //[ObservableProperty]
        //private UserControl task;

        //[ObservableProperty]
        //private UserControl attachments;

        [ObservableProperty]
        private ObservableCollection<Appraisal> estimate;

        public TaskSummaryViewModel()
        {
            // Initialize the TaskSummaryViewModel
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
