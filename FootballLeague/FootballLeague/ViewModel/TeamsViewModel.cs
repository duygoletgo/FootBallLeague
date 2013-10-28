using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace FootballLeague.ViewModel
{
    public class TeamsViewModel : ViewModelBase
    {
        private RelayCommand _GoToTeamsView { get; set; }
        public RelayCommand GoToTeamsView
        {
            get { return new RelayCommand(GoToTeamsViewHandler); }
        }

        private void GoToTeamsViewHandler()
        {
            ViewModelLocator.LocatorNavigateToPage(ViewModelLocator.ContentPages.Teams);
        }
    }
}
