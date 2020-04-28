using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlcoholCheck
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Inp_birthday.Date = DateTime.Now;
        }
        void Btn_calculate(object sender, System.EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - Inp_birthday.Date;
            if(timeSpan.Days >= 7665)
            {
                Lbl_verify.Text = "You can legally drink alcohol, be responsible.";
            }
            else 
            {
                Lbl_verify.Text = $"You still have {7665 - timeSpan.Days} days until you can drink.";
            }

        }
    }
}
