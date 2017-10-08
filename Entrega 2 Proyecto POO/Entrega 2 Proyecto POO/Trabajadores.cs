using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Trabajadores : Persona
    {
        public Trabajadores(string nombre) : base(nombre) { }
        public void Vender(Tienda tienda,int Cantidad)
        {
            tienda.SumarGanancia(Cantidad);
        }
    }
}
