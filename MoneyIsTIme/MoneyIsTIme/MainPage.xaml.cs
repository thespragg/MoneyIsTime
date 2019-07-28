using MoneyIsTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoneyIsTime
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

        public void ResetButtons()
        {
            Days.TextColor = Color.FromHex("#CBCBCB");
            Hours.TextColor = Color.FromHex("#CBCBCB");
            Minutes.TextColor = Color.FromHex("#CBCBCB");
        }

        private void Time_Clicked(object sender, EventArgs e)
        {
            ResetButtons();
            var button = (Button)sender;
            HoursModel.ChangeUnit(button.ClassId);
            button.TextColor = Color.FromHex("#37B8CC");
        }
    }
}
