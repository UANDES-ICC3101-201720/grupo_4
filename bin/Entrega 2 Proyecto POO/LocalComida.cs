using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class LocalComida : Tienda
    {
        public string Categoria;

        public LocalComida(string categoria,int volumen,string nombre,int preciominimo,int preciomaximo,Piso piso) :base(volumen,nombre,preciominimo,preciomaximo,piso)
        {
            this.Categoria = categoria;
        }
    }
}
