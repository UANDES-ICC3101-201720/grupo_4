using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Trabajadores : Persona
    {
        public Tienda Tienda;
        public Trabajadores(string nombre,Tienda Tienda) : base(nombre)
        {
            this.Tienda = Tienda;
        }
        public void Atender(Tienda tienda)
        {
            tienda.SumarCliente();
        }
    }
}
