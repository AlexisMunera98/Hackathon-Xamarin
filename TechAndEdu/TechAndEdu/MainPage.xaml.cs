using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TechAndEdu
{
	public partial class MainPage : ContentPage
	{
        ObservableCollection<Propuesta> propuestas = new ObservableCollection<Propuesta>();

        
		public MainPage()
		{
			InitializeComponent();
            ListaPropuestas.ItemsSource = propuestas;
            /*
            List<Propuesta> propuestas = new List<Propuesta>();
            propuestas.Add(new Propuesta("Quiero una cancha de futbol", "Deporte", 0, 0));
            propuestas.Add(new Propuesta("Quiero clases de porro", "Baile", 0, 0));
            propuestas.Add(new Propuesta("Quiero una cancha de tenis", "Salud", 0, 0));
            propuestas.Add(new Propuesta("Quiero otra cancha de futbol", "Deporte", 0, 0));
            propuestas.Add(new Propuesta("Viernes de asados", "Recreacion", 0, 0));
            propuestas.Add(new Propuesta("Semillero de robotica", "Semilleros", 0, 0));
            propuestas.Add(new Propuesta("Lab de software", "Laboratorios", 0, 0));
            propuestas.Add(new Propuesta("Odontologia", "Salud", 0, 0));
            */


            propuestas.Add(new Propuesta{ propuesta = "Quiero una cancha de futbol", categoria = "Deporte Likes 5 Dislikes 1", likes = 0, dislikes = 0});
            propuestas.Add(new Propuesta { propuesta = "Quiero clases de porro", categoria = "Baile Likes 30 Dislikes 11", likes = 0, dislikes = 0 });
            propuestas.Add(new Propuesta { propuesta = "Quiero una cancha de tenis", categoria = "Deporte Likes 5 Dislikes 10", likes = 0, dislikes = 0 });
            propuestas.Add(new Propuesta { propuesta = "Viernes de asados", categoria = "Recreacion Likes 58 Dislikes 3", likes = 0, dislikes = 0 });
            propuestas.Add(new Propuesta { propuesta = "Semillero de robotica", categoria = "Semilleros Likes 5 Dislikes 2", likes = 0, dislikes = 0 });
            propuestas.Add(new Propuesta { propuesta = "Lab de software", categoria = "Laboratorios Likes 15 Dislikes 4", likes = 0, dislikes = 0 });


        }

        private  async void AgregarComando_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new agregarPropuestaPage());
        }
    }
}
