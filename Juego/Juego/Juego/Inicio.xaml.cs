using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Juego
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
            registrar.Clicked += registra_Clicked;
            visualizar.Clicked += visualizar_Clicked;
            Informacion.Clicked += info_Clicked;
            Licencias.Clicked += licen_Clicked;

		}
        private void registra_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new registarjuego());
        }
        private void visualizar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new visualizarjuego());
        }
        private void info_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new informaciondejuego());
        }
        private void licen_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new informaciondejuego());
        }



    }
}