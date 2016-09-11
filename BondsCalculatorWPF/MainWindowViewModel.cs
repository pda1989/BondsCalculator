using Prism.Commands;
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
            set
            {
                if (value > 0)
                    SetProperty(ref _nominal, value);
            }
        }
        public double Coupon
        {
            get { return _coupon; }
            set
            {
                if (value > 0)
                    SetProperty(ref _coupon, value);
            }
        }
        public double ACI
        {
            get { return _aci; }
            set
            {
                if (value > 0)
                    SetProperty(ref _aci, value);
            }
        }
        public double Redemption
        {
            get { return _redemption; }
            set
            {
                if (value >= 1)
                    SetProperty(ref _redemption, value);
            }
        }
        public double MaxPrice
        {
            get { return _maxPrice; }
            set
            {
                if (value > 0)
                    SetProperty(ref _maxPrice, value);
                if (value < _minPrice)
                {
                    _minPrice = value;
                    OnPropertyChanged("MinPrice");
                }
            }
        }
        public double MinPrice
        {
            get { return _minPrice; }
            set
            {
                if (value > 0)
                    SetProperty(ref _minPrice, value);
                if (value > _maxPrice)
                {
                    _maxPrice = value;
                    OnPropertyChanged("MaxPrice");
                }
            }
        }
        public double PriceStep 
        {
            get { return _priceStep; }
            set
            {
                if (value > 0)
                    SetProperty(ref _priceStep, value);
            }
        }
        public int Days
        {
            get { return _days; }
            set
            {
                if (value >= 365 && value <= 366)
                    SetProperty(ref _days, value);
            }
        }
        public ObservableCollection<ResultRow> Results { get; set; } = new ObservableCollection<ResultRow>();

        public DelegateCommand CalculateCommand { get; set; }

        public MainWindowViewModel()
        {
            AppVersion = "Version " + typeof(MainWindow).Assembly.GetName().Version.ToString();
            Nominal = 1000; 
            MinPrice = 90;
            MaxPrice = 100;
            PriceStep = 0.1;
            Days = 365;
            Redemption = 1;

            CalculateCommand = new DelegateCommand(CalculateProfitability);
        }

        public void CalculateProfitability()
        {
            Results.Clear();
            for (double i = _minPrice; i <= _maxPrice; i += _priceStep)
            {
                var price = Math.Round(i, 2);
                var buy = _nominal * price / 100 + _aci;
                var sell = _nominal + _coupon;
                var profit = Math.Round(sell - buy, 2);
                var profitability = 0d;
                try
                {
                    profitability = Math.Round(profit / buy * 100 / _redemption * _days, 2);
                }
                catch (Exception) { }
                Results.Add(new ResultRow
                {
                    Buy = buy,
                    Price = price,
                    Profit = profit,
                    Sell = sell,
                    Profitability = profitability
                });
            }
        }
    }
}
