using GalaSoft.MvvmLight;
using Elite_Missions.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Elite_Missions.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        
        private readonly ILogfileService _logfileService;

        #region WelcomeTitle

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        } 
        #endregion

        #region LogFiles

        private List<string> list;

        public List<string> LogFiles
        {
            get { return list; }
            set { list = value; }
        } 
        #endregion

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(ILogfileService logfileService)
        {
            _logfileService = logfileService;
            WelcomeTitle = _logfileService.LogFile;

        }

        public override void Cleanup()
        {
            // Clean up if needed

            base.Cleanup();
        }
    }
}