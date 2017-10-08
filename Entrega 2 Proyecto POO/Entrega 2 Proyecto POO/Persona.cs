using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Persona
    {
        public string nombre;
        public Piso Piso;
        public Piso PisoEntrar;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public void EntrarMall(Piso Piso)
        {
            this.Piso = Piso;

        }
        public void SalirMall()
        {
            this.Piso = null;
        }
    }
}
