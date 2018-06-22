using DAL.DB;
using DAL.DB.Common.Repositories;
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
        IGenericRepository<DimProduct> _ProductRepo;
        #endregion

        public OrdersViewModel(IGenericRepository<DimProduct> repo)
        {
            MyOrders = new ObservableCollection<Order>();
            _ProductRepo = repo;
        }

        public bool CanExecute()
        {
            return true;
        }
        private RelayCommand _LoadCommand;
        public RelayCommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new RelayCommand(LoadOrders, CanExecute);
                return _LoadCommand;
            }
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


        public void LoadOrders()
        {

            var myProduct = _ProductRepo.GetByID(20);// new Order { OrderNo = "100051",OrderName= "My Amazon", OrderDate = DateTime.MinValue.AddMilliseconds(2000392) };
            MyOrders.Add(GetOrderOfProduct(myProduct));
        }

        private static Order GetOrderOfProduct(DimProduct x)
        {
            return new Order() { OrderDate = x.StartDate ?? DateTime.MinValue, OrderName = x.EnglishProductName, OrderNo = x.ProductKey.ToString() };
        }
    }
}
