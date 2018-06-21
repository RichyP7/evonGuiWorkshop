using evonGuiWorkshop.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace evonGuiWorkshop.ViewModel
{
    public class OrdersViewModel :ViewModelBase
    {
        #region Data
        private ObservableCollection<Order> myOrders;
        #endregion

        public OrdersViewModel()
        {
            MyOrders = new ObservableCollection<Order>();
            //myOrders = new ObservableCollection<Order>();

            //OrderView = CollectionViewSource.GetDefaultView(myOrders) as ListCollectionView;

            //OrderView.CurrentChanged += (s, e) =>

            //{

            //    RaisePropertyChanged(() => Orders);

            //};
        }

        public ICollectionView OrderView { get; }


        public ObservableCollection<Order> MyOrders
        {
            get
            {
                return myOrders;
            }
            set
            {
                myOrders = value;
                RaisePropertyChanged("MyOrders");
            }
        }

        public RelayCommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new RelayCommand(LoadOrders, CanExecute);
                return _LoadCommand;
            }
        }

        public void LoadOrders()
        {

            var x = new Order { OrderNo = "100051", OrderDate = DateTime.MinValue.AddMilliseconds(2000392) };

            MyOrders.Add(x);
        }
        public bool CanExecute()
        {
            return true;
        }
        private RelayCommand _LoadCommand;

    }
}
