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

        public Plan_de_Compras()
        {
            this.Tiendas = new List<Tienda>();
            this.Gasto = new List<int>();
        }
        public void GenerarPlan(List<Tienda> Tienda,Cliente cliente,List<Piso> Piso)
        {
            List<Piso> Pisos = Piso;
            Random random = new Random();
            int cantidad = random.Next(Pisos.Count() - 1);
            int cotamax = 10;
            int cotamin = 8;
            int rnd = random.Next(cotamin,cotamax);
            Piso entrar = cliente.PisoEntrar;
            GenerarPlanPorPiso(Tienda, cliente, entrar, rnd);
            Pisos.Remove(entrar);
            for (int i = 1; i <= cantidad; i++)
            {               
                cotamax -= 2;
                cotamin -= 2;
                int rnd1 = random.Next(cotamin, cotamax);
                int rnd2 = random.Next(Pisos.Count() - 1);
                Piso piso = Pisos[rnd2];
                GenerarPlanPorPiso(Tienda,cliente,piso,rnd1);               
            }
        }
        public void GenerarPlanPorPiso(List<Tienda> Tienda,Cliente Cliente,Piso piso,int cantidad)
        {
            Random random = new Random();
            int Presupuesto = Cliente.PresupuestoInicial;
            int CantidadTiendas = random.Next(2,5);
            for (int i=0; i <= CantidadTiendas; i++)
            {
                List<Tienda> SelectStore = Tienda.Where(tienda => tienda.Piso.numero==piso.numero).ToList();
                int SelectStoreRnd = random.Next(SelectStore.Count() - 1);
                this.Tiendas.Add(Tienda[SelectStoreRnd]);
                int Gastar = random.Next(Tienda[SelectStoreRnd].PrecioMinimo, Tienda[SelectStoreRnd].PrecioMaximo) *random.Next(1,5);
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
    }
}
