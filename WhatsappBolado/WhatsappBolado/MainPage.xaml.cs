using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsappBolado.ViewModels;
using Xamarin.Forms;

namespace WhatsappBolado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = new MainViewModel();
            InitializeComponent();
        }
    }
}
