using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoneyIsTIme.Models
{
    public class HoursToWorkViewModel : INotifyPropertyChanged
    {
        private float hourlyWage { get; set; }
        public float HourlyWage {
            get => hourlyWage;
            set {
                CalculateHours();
                hourlyWage = value;
                NotifyPropertyChanged("");
            }
        }

        private float purchaseCost { get; set; }
        public float PurchaseCost {
            get => purchaseCost;
            set
            {
                CalculateHours();
                purchaseCost = value;
                NotifyPropertyChanged("");
            }
        }
        public float HoursOfWork { get; set; }

        public HoursToWorkViewModel()
        {
            PurchaseCost = 0;
            HourlyWage = 0;
            HoursOfWork = 1;
        }

        public void CalculateHours()
        {
            if (HourlyWage == 0 || PurchaseCost == 0) return;
            HoursOfWork = PurchaseCost / HourlyWage;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
