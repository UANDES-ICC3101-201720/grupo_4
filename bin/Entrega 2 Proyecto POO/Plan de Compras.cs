using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Plan_de_Compras
    {
        public List<Tienda> Tiendas;
        public List<int> Gasto;

        public Plan_de_Compras(List<Tienda> tienda, List<int> gasto)
        {
            this.Tiendas = tienda;
            this.Gasto = gasto;
        }
        public void GenerarPlan(List<Tienda> Tienda,Cliente Cliente)
        {
            Random random = new Random();
            int Presupuesto = Cliente.PresupuestoInicial;
            int CantidadTiendas = random.Next(5, 20);
            for (int i=0; i <= CantidadTiendas; i++)
            {
                int SelectStore = random.Next(Tienda.Count-1);
                this.Tiendas.Add(Tienda[SelectStore]);
                int Gastar = random.Next(Tienda[SelectStore].PrecioMaximo, Tienda[SelectStore].PrecioMinimo)*random.Next(1,5);
                if (Presupuesto - Gastar > 0)
                {
                    Gasto.Add(Gastar);
                    Presupuesto = Presupuesto - Gastar;
                }
                else
                {
                    Gasto.Add(0);
                }
            }
        }
        public void OrdenarPlan(List<Tienda> Tienda,List<int> Gasto,Cliente Cliente)
        {
            List<Tienda> Stores=new List<Tienda>();
            List<int> Lista = new List<int>();
            foreach (Tienda Store in Tienda)
            {
                if (Store.Piso != Cliente.PisoEntrar)
                {
                    Lista.Add(Store.Piso.numero);
                }
                else
                {
                    Stores.Add(Store);
                }                
            }
            Lista.Sort();

        }
    }
}
