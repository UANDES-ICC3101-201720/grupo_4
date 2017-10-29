using System;
using System.Collections.Generic;

namespace ProyectoPOO3
{
    public class Plan_de_Compras
    {
        public List<Tienda> Tiendas;

        public Plan_de_Compras()
        {
            this.Tiendas = new List<Tienda>();
        }
        public void GenerarPlan(List<Tienda> Stores, List<Piso> pisos, Cliente cliente)
        {
            foreach (Piso piso in pisos)
            {
                Random random = new Random();
                int entrar = random.Next(10);
                if (entrar > 4)
                {
                    foreach (Tienda tienda in Stores)
                    {
                        int entrar1 = random.Next(10);
                        if (entrar1 > 5)
                        {
                            Tiendas.Add(tienda);
                        }
                    }
                }
            }
        }
    }
}
