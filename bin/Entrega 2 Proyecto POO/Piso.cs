using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Piso
    {
        public int numero;
        public List<Tienda> Tiendas;
        public int Area;
        public int AreaOcupada;
        public int Estacionamientos;
        public int EstacionamientosOcupados;
        public Piso(int Area,int Estacionamientos,int numero)
        {
            this.numero = numero;
            this.Area = Area;
            this.Estacionamientos = Estacionamientos;
            this.EstacionamientosOcupados = 0;
            this.Tiendas = new List<Tienda>();
            this.AreaOcupada = 0;
        }
        public void AgregarTienda(Tienda Tienda,int Volumen)
        {
            if (Area < AreaOcupada + Volumen)
            {
                Console.WriteLine("Supera el limite de Area de este piso");
            }
            else
            {
                Tiendas.Add(Tienda);
                AreaOcupada =AreaOcupada + Volumen/2;
            }
        }
    }
}
