using MoneyIsTIme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoneyIsTIme
{
    public partial class MainPage : ContentPage
    {
        public HoursToWorkViewModel HoursModel { get; set; }
        public MainPage()
        {
            HoursModel = new HoursToWorkViewModel();
            BindingContext = HoursModel;
            InitializeComponent();
        }
    }
}
