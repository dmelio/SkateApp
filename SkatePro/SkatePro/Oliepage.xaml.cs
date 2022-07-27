using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkatePro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Oliepage : ContentPage
    {
        public Truco _truco { get; set; }
        public Oliepage(Truco truco)
        {
            InitializeComponent();

            BindingContext = truco;
        }

    }
}