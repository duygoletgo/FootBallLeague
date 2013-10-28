using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using FootballLeague.Helper;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace FootballLeague.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            if (!SimpleIoc.Default.IsRegistered<TeamsViewModel>())
            {
                SimpleIoc.Default.Register<TeamsViewModel>(() => { return new TeamsViewModel(); }, MvvmKeys.TeamsViewModel);
            }
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<TeamsViewModel>();
        }

        public enum ContentPages
        {
            Main,
            Teams
        }
        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public TeamsViewModel Teams
        {
            get
            {
                return GetMvvmInstance.GetInstance<TeamsViewModel>(MvvmKeys.TeamsViewModel);
            }
        }

        public static void LocatorNavigateToPage(ContentPages pagename, string paramin = "")
        {
            try
            {
                switch (pagename)
                {
                    case ContentPages.Main:
                        SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo(new Uri("/Teams.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    case ContentPages.Teams:
                        //SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo(new Uri("/View/Teams.xaml", UriKind.RelativeOrAbsolute));
                        SimpleIoc.Default.GetInstance<INavigationService>().NavigateTo(new Uri("/View/Teams.xaml", UriKind.RelativeOrAbsolute));
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
