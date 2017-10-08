using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Mall
    {
        public int Pisos;
        public List<Trabajadores> Trabajadores;
        public int Horas;
        public int Dinero;
        public void Apertura() { }
        public void Cierre() { }
        public Mall(int Pisos,int Horas)
        {
            this.Pisos = Pisos;
            this.Horas = Horas;
        }
    }
}
