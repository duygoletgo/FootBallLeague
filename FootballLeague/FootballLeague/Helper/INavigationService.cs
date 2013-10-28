using System;
using System.Windows.Navigation;

namespace FootballLeague.Helper
{
    interface INavigationService
    {
        event NavigatingCancelEventHandler Navigating;
        void NavigateTo(Uri uri);
    }
}
