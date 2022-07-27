using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkatePro
{
    public partial class MainPage : ContentPage
    {
        public IList<Truco> Trucos { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Trucos = new List<Truco>();
            Trucos.Add(new Truco
            {
                Nombre = "Olie",
                Descripcion = "Este truco consiste en saltar con en Skate",
                Nvldificultad = "Facil",
                Comohacer = "Salta sin miedo presionando el tail,luego lon el pie de adelante raspa la lija hacia el nose acomodando el skate bajo tus pies"
            });

            Trucos.Add(new Truco
            {
                Nombre = "KickFlip",
                Descripcion = "Este truco consiste en saltar haciendo girar la tabla con una patada hacia atras",
                Nvldificultad = "Facil",
                Comohacer = "Has un Olie, esta vez con el pie de adelante se raspa la lija para afuera con una patada hacia atras, luego vueelve a acomdar los pies para caer sobre el skate "
            });

            Trucos.Add(new Truco
            {
                Nombre = "Heelflip",
                Descripcion = "Saltar haciendo girar la tabla con una patada hacia el frente",
                Nvldificultad = "Facil - medio",
                Comohacer ="Has un Olie, luego con el pie de adelante raspa la lija con una patada hacia el frente (Ver posicion de pies), luego vuelve a posicionar los pies para caer.  "
            });
            Trucos.Add(new Truco
            {
                Nombre = "Pop Shove-it",
                Descripcion = "Este truco consiste en hacer girar la tabla 180 grados popeando el skate",
                Nvldificultad = "Facil",
                Comohacer = "Salta presionando el Tail hacia atras"
            });
            Trucos.Add(new Truco
            {
                Nombre = "Shove-it",
                Descripcion = "Este truco consiste en hacer girar la tabla 180 grados sin que el tail toque el piso",
                Nvldificultad = "Facil",
                Comohacer = "Salta presionando el Tail hacia atras"
            });
            Trucos.Add(new Truco
            {
                Nombre = "fs Shove-it",
                Descripcion = "Este truco consiste en hacer girar la tabla 180 grados para atras sin que el tail toque el piso",
                Nvldificultad = "Facil - medio",
                Comohacer = "Salta presionando el Tail un poco hacia el frente"
            });
            Trucos.Add(new Truco
            {
                Nombre = "FS / BS",
                Descripcion = "Consiste en girar tu con el skate 180 grados, alfrente para backside y atras para frontside",
                Nvldificultad = "Facil - medio",
                Comohacer = "Has un olie y gira tu cuerpo 180 grados llevando el skate bajo tus pies"
            });
            Trucos.Add(new Truco
            {
                Nombre = "inward-heelflip",
                Descripcion = "Este truco consiste en hacer girar la tabla 180 grados para atras sin que el tail toque el piso",
                Nvldificultad = "dificil",
                Comohacer = "Salta presionando el Tail un poco hacia el frente"
            });
            Trucos.Add(new Truco
            {
                Nombre = "Flip-FS",
                Descripcion = "Consiste en girar tu con el skate 180 grados, alfrente para backside y atras para frontside",
                Nvldificultad = "Medio",
                Comohacer = "Has un olie y gira tu cuerpo 180 grados llevando el skate bajo tus pies"
            });
            Trucos.Add(new Truco
            {
                Nombre = "Flip-BS",
                Descripcion = "Consiste en girar tu con el skate 180 grados, alfrente para backside y atras para frontside",
                Nvldificultad = "Medio",
                Comohacer = "Has un olie y gira tu cuerpo 180 grados llevando el skate bajo tus pies"
            });
            BindingContext = this;
        }

        private void ListTruco_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                var truco = e.SelectedItem as Truco;
                this.Navigation.PushModalAsync(new Oliepage(truco));
            }
            Truco selectedItem = e.SelectedItem as Truco;
        }

        private void ListTruco_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Truco tappedItem = e.Item as Truco;
        }

        private void btnGOS_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Gameofskate());
        }
    }
}
