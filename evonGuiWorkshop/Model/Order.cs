using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evonGuiWorkshop.Model
{
    public class Order : ViewModelBase
    {
        #region Constructor

        public Order()
        { }

        #endregion

        #region Properties

        private string _OrderNo;

        public string OrderNo
        {
            get
            {
                return _OrderNo;
            }
            set
            {
                if (_OrderNo != value)
                {
                    _OrderNo = value;
                    RaisePropertyChanged();
                }
            }
        }

        private DateTime _OrderDate;

        public DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                if (_OrderDate != value)
                {
                    _OrderDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        private DateTime _DeliveryDate;

        public DateTime DeliveryDate
        {
            get
            {
                return _DeliveryDate;
            }
            set
            {
                Set(ref _DeliveryDate, value);
            }
        }

        #endregion
    }

}
