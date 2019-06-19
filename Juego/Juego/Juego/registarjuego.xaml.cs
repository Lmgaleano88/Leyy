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
	public partial class registarjuego : ContentPage
	{
		public registarjuego ()
		{
			InitializeComponent ();
            Guardar.Clicked += guard_Clicked;
		}
        private void guard_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new visualizarjuego());
        }
	}
}