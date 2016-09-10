using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondsCalculatorWPF
{
    class MainWindowViewModel : BindableBase
    {
        private string _version;
        private double _nominal;
        private double _coupon;
        private double _aci;
        private double _redemption;
        private double _minPrice;
        private double _maxPrice;
        private double _priceStep;
        private int _days;

        public string AppVersion
        {
            get { return _version; }
            set { SetProperty(ref _version, value); }
        }
        public double Nominal
        {
            get { return _nominal; }
            set { SetProperty(ref _nominal, value); }
        }
        public double Coupon
        {
            get { return _coupon; }
            set { SetProperty(ref _coupon, value); }
        }
        public double ACI
        {
            get { return _aci; }
            set { SetProperty(ref _aci, value); }
        }
        public double Redemption
        {
            get { return _redemption; }
            set { SetProperty(ref _redemption, value); }
        }
        public double MaxPrice
        {
            get { return _maxPrice; }
            set { SetProperty(ref _maxPrice, value); }
        }
        public double MinPrice
        {
            get { return _minPrice; }
            set { SetProperty(ref _minPrice, value); }
        }
        public double PriceStep 
        {
            get { return _priceStep; }
            set { SetProperty(ref _priceStep, value); }
        }
        public int Days
        {
            get { return _days; }
            set { SetProperty(ref _days, value); }
        }
        public ObservableCollection<ResultRow> Results { get; set; } = new ObservableCollection<ResultRow>();

        public MainWindowViewModel()
        {
            AppVersion = "Version " + typeof(MainWindow).Assembly.GetName().Version.ToString();
            Nominal = 1000; 
            Coupon = 12;
            ACI = 10;
            Redemption = 40;
            MinPrice = 100;
            MaxPrice = 200;
            PriceStep = 10;
            Days = 365;
            Results.Add(new ResultRow { Buy = 12, Price = 234, Profit = 678, Profitability = 12, Sell = 2323 });
        }
    }
}
