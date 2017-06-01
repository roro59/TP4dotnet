using System.Collections.Generic;
using System.ServiceModel.Syndication;
using GalaSoft.MvvmLight;
using TP4.DataAccess;
using TP4.Model;

namespace TP4.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            DataAccess.Flux f = new Flux();
            MyFluxs = f.GetflMyFluxs("tests.xml");
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private List<MyFlux> _myFluxs;

        public List<MyFlux> MyFluxs
        {
            get { return _myFluxs; }
            set
            {
                if (_myFluxs != value)
                {
                    _myFluxs = value;
                    RaisePropertyChanged("MyFluxs");
                }
            }
        }

        private int _select;

        public int Select
        {
            get
            {
                return _select;
            }
            set
            {
                if (_select != value)
                {
                    _select = value;
                    RaisePropertyChanged("Select");
                }
            }
        }

        private List<SyndicationItem> _items;
        public List<SyndicationItem> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    RaisePropertyChanged("Items");
                }
            }
        }




    }
}