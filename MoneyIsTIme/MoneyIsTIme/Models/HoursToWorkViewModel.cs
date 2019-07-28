using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoneyIsTime.Models
{
    public class HoursToWorkViewModel : INotifyPropertyChanged
    {
        private float hourlyWage { get; set; }
        public float HourlyWage {
            get => hourlyWage;
            set {
                hourlyWage = value;
                CalculateHours();
                NotifyPropertyChanged("");
            }
        }

        private float purchaseCost { get; set; }
        public float PurchaseCost {
            get => purchaseCost;
            set
            {
                purchaseCost = value;
                CalculateHours();
                NotifyPropertyChanged("");
            }
        }
        public string HoursOfWork { get; set; }

        public int Modifier { get; set; }
        public string Unit { get; set; }
        public HoursToWorkViewModel()
        {
            HoursOfWork = "0.0";
            Modifier = 60;
            Unit = "Hours";
        }

        public void CalculateHours()
        {
            if (HourlyWage == 0 || PurchaseCost == 0) return;
            HoursOfWork = String.Format("{0:0.##}", ((PurchaseCost*60) / (HourlyWage)/Modifier));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangeUnit(string unitType)
        {
            switch (unitType)
            {
                case "Days":
                    Unit = "Days";
                    Modifier = 1440;
                    break;
                case "Hours":
                    Unit = "Hours";
                    Modifier = 60;
                    break;
                case "Minutes":
                    Unit = "Minutes";
                    Modifier = 1;
                    break;
            }
            NotifyPropertyChanged("");
            CalculateHours();
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
