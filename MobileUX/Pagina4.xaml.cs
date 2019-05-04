using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileUX
{
    public partial class Pagina4 : ContentPage
    {
        public Pagina4()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}
