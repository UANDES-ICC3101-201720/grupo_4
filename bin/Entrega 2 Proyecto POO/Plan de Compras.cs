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

        public Plan_de_Compras()
        {
            this.Tiendas = new List<Tienda>();
        }
        public void GenerarPlan(List<Tienda> Tienda,Cliente cliente,List<Piso> Piso)
        {
            List<Piso> Pisos = Piso;
            Random random = new Random();
            int cantidad = random.Next(Pisos.Count());
            Piso entrar = cliente.PisoEntrar;
            GenerarPlanPorPiso(Tienda, cliente, entrar);
            Pisos.Remove(entrar);
            for (int i = 1; i <= cantidad; i++)
            {         
                int rnd2 = random.Next(Pisos.Count());
                Piso piso = Pisos[rnd2];
                GenerarPlanPorPiso(Tienda,cliente,piso);               
            }
        }
        public void GenerarPlanPorPiso(List<Tienda> Tienda,Cliente Cliente,Piso piso)
        {
            Random random = new Random();
            int Presupuesto = Cliente.PresupuestoInicial;
            int CantidadTiendas = random.Next(1,5);
            for (int i=0; i <= CantidadTiendas; i++)
            {
                List<Tienda> SelectStore = Tienda.Where(tienda => tienda.Piso.numero==piso.numero).ToList();
                int SelectStoreRnd = random.Next(SelectStore.Count());
                if (!Tiendas.Contains(Tienda[SelectStoreRnd]))
                {
                    this.Tiendas.Add(Tienda[SelectStoreRnd]);
                }
                
            }
        }
    }
}
