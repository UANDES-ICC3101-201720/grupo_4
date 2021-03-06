﻿using System;
using System.Collections.Generic;

namespace ProyectoPOO3
{
    public class Piso
    {
        public int numero;
        public List<Tienda> Tiendas;
        public int Area;
        public int AreaOcupada;
        public Piso(int Area, int numero)
        {
            this.numero = numero;
            this.Area = Area;
            this.Tiendas = new List<Tienda>();
            this.AreaOcupada = 0;
        }
        public void AgregarTienda(Tienda Tienda, int Volumen)
        {
            if (Area < AreaOcupada + Volumen)
            {
                Console.WriteLine("Supera el limite de Area de este piso");
            }
            else
            {
                Tiendas.Add(Tienda);
                AreaOcupada = AreaOcupada + Volumen / 2;
            }
        }
    }
}
