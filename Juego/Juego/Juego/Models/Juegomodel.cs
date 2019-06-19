using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;


namespace Juego.Models
{
    public class Juegomodel
    {
        private int idJuego;
        private string Nombre;
        private string categoria;
        private string tamano;
        private decimal precio;
        private string cantidad;
       
        
        public int IdJuego { get => idJuego; set => idJuego = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Tamano { get => tamano; set => tamano = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
    }
}
