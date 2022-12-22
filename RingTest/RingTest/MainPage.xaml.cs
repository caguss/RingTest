using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RingTest
{
    public partial class MainPage : ContentPage
    {
        PlaySoundClass test;

        public MainPage()
        {
            InitializeComponent();
            test = new PlaySoundClass();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            test.PlaySound();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            test.StopSound();
        }
    }
}
