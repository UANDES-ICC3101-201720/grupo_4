using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
                int entrar = random.Next(8);
                int rnd = random.Next(10);
                if (entrar < rnd)
                {
                    Stores.Reverse();
                    foreach (Tienda tienda in Stores)
                    {
                        int entrar1 = random.Next(10);
                        int rnd1 = random.Next(8);
                        if (rnd1 < entrar1 & tienda.Piso.Equals(piso))
                        {
                            Tiendas.Add(tienda);
                        }
                    }
                }
            }
        }
    }
}