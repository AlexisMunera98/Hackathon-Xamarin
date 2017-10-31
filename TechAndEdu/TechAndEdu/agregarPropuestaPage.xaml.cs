using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TechAndEdu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class agregarPropuestaPage : ContentPage
	{

		public agregarPropuestaPage ()
		{
			InitializeComponent ();
            ListaCategorias.ItemsSource = new List<string> { "Deportes", "Salud","Recreación","Educación" };
        }

        private void BtnAgregarPropuesta_Clicked(object sender, EventArgs e)
        {
            /*
            String categoria = ListaCategorias.SelectedItem.ToString();
            String propuesta = propuestaTexto.Text;*/
            DisplayAlert("Advertencia", "La propuesta fue agregada", "Aceptar");

        }
    }
}