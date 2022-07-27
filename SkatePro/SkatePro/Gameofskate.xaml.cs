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
    public partial class Gameofskate : ContentPage
    {
        public IList<Skater> Skaters { get; set; }
        public Gameofskate()
        {
            InitializeComponent();
            Skaters = new List<Skater>();
            BindingContext = this;
        }

        private void btnRegSkater_Clicked(object sender, EventArgs e)
        {
            if(entSkater1.Text != null && entSkater2.Text != null)
            {
                Skaters.Add(new Skater
                {
                    NombreSkater = entSkater1.Text
                });
                Skaters.Add(new Skater
                {
                    NombreSkater = entSkater2.Text
                });

                var skter1 = Skaters.First<Skater>();
                var skter2 = Skaters.Last<Skater>();
                entNombre1game.Text = skter1.NombreSkater.ToString();
                entNombre2game.Text = skter2.NombreSkater.ToString();
            }
            else
            {
                DisplayAlert("Atencion","Debe ingresar los nombres de los participantes","Aceptar");
            }
            
        }

        private void btnAgregarletraP1_Clicked(object sender, EventArgs e)
        {
            if(entSkater1.Text != null && entSkater2.Text != null)
            {
                var skter1 = Skaters.First<Skater>();
                var skter2 = Skaters.Last<Skater>();

                if (entSp1.Text == null && entKp1.Text == null && entAp1.Text == null && entTp1.Text == null && entEp1.Text == null)
                {
                    entSp1.Text = "S";
                }
                else
                {
                    if (entSp1.Text == "S" && entKp1.Text == null && entAp1.Text == null && entTp1.Text == null && entEp1.Text == null)
                    {
                        entKp1.Text = "K";
                    }
                    else
                    {
                        if (entSp1.Text == "S" && entKp1.Text == "K" && entAp1.Text == null && entTp1.Text == null && entEp1.Text == null)
                        {
                            entAp1.Text = "A";
                        }
                        else
                        {
                            if (entSp1.Text == "S" && entKp1.Text == "K" && entAp1.Text == "A" && entTp1.Text == null && entEp1.Text == null)
                            {
                                entTp1.Text = "T";
                            }
                            else
                            {
                                if (entSp1.Text == "S" && entKp1.Text == "K" && entAp1.Text == "A" && entTp1.Text == "T" && entEp1.Text == null)
                                {
                                    entEp1.Text = "E";
                                    DisplayAlert("Game Over", skter1.NombreSkater + " a perdido", "Aceptar");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                DisplayAlert("Atencion","Debe registrar a los jugadores para comenzar","Aceptar");
            }
            
        }

        private void btnAgregarletraP2_Clicked(object sender, EventArgs e)
        {

            if (entSkater1.Text != null && entSkater2.Text != null)
            {
                var skter1 = Skaters.First<Skater>();
                var skter2 = Skaters.Last<Skater>();

                if (entSp2.Text == null && entKp2.Text == null && entAp2.Text == null && entTp2.Text == null && entEp2.Text == null)
                {
                    entSp2.Text = "S";
                }
                else
                {
                    if (entSp2.Text == "S" && entKp2.Text == null && entAp2.Text == null && entTp2.Text == null && entEp2.Text == null)
                    {
                        entKp2.Text = "K";
                    }
                    else
                    {
                        if (entSp2.Text == "S" && entKp2.Text == "K" && entAp2.Text == null && entTp2.Text == null && entEp2.Text == null)
                        {
                            entAp2.Text = "A";
                        }
                        else
                        {
                            if (entSp2.Text == "S" && entKp2.Text == "K" && entAp2.Text == "A" && entTp2.Text == null && entEp2.Text == null)
                            {
                                entTp2.Text = "T";
                            }
                            else
                            {
                                if (entSp2.Text == "S" && entKp2.Text == "K" && entAp2.Text == "A" && entTp2.Text == "T" && entEp2.Text == null)
                                {
                                    entEp2.Text = "E";
                                    DisplayAlert("Game Over", skter2.NombreSkater + " a perdido", "Aceptar");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                DisplayAlert("Atencion", "Debe registrar a los jugadores para comenzar", "Aceptar");
            }
            
        }

        private void btnNuevojuego_Clicked(object sender, EventArgs e)
        {
            Skaters.Clear();
            entSp1.Text = null;
            entKp1.Text = null;
            entAp1.Text = null;
            entTp1.Text = null;
            entEp1.Text = null;
            entSp2.Text = null;
            entKp2.Text = null;
            entAp2.Text = null;
            entTp2.Text = null;
            entEp2.Text = null;
            entNombre1game.Text = null;
            entNombre2game.Text = null;
            entSkater1.Text = null;
            entSkater2.Text = null ;
        }
    }
}
