using System;
using System.Collections.Generic;

namespace ProyectoPOO3
{
    public abstract class Tienda
    {
        public int Volumen;
        public Piso Piso;
        public string Nombre;
        public int CantidadTrabajadores;
        public int PrecioMinimo;
        public int PrecioMaximo;
        public List<Trabajadores> Trabajadores;
        public int ContadorClientes;
        public int ClientesAhora;
        public int ClientesDiaAnterior;
        public int GananciaEfectiva;
        public string Categoria;
        public int Ventas;
        public List<int> VentasDiarias;
        public List<int> GananciasDiarias;
        public Tienda(int volumen, string nombre, int PrecioMinimo, int PrecioMaximo, Piso Piso, string categoria)
        {
            this.Piso = Piso;
            this.Volumen = volumen;
            this.Nombre = nombre;
            this.CantidadTrabajadores = 0;
            this.PrecioMinimo = PrecioMinimo;
            this.PrecioMaximo = PrecioMaximo;
            this.ContadorClientes = 0;
            this.ClientesAhora = 0;
            this.ClientesDiaAnterior = 0;
            this.Trabajadores = new List<Trabajadores>();
            this.GananciaEfectiva = 0;
            this.GananciasDiarias = new List<int>();
            this.Categoria = categoria;
            this.Ventas = 0;
            this.VentasDiarias = new List<int>();
        }
        public void AgregarTrabajador(Trabajadores Trabajador)
        {
            Trabajadores.Add(Trabajador);
            CantidadTrabajadores += 1;
        }
        public int ClientesPorDia(int CantidadTrabajadores, int ClientesDiaAnterior, int AreaLocal, int PrecioMinimo, int PrecioMaximo)
        {
            int CMAX = 0;
            CMAX = ClientesDiaAnterior + AreaLocal / 10 * (Math.Max(100 - (PrecioMinimo + PrecioMinimo) / 2, 0) / 100) * CantidadTrabajadores;
            return CMAX;
        }
        public void GananciaLocal(int PrecioMinimo, int PrecioMaximo, int Volumen, int CantidadTrabajadores, int ClientesDiaAnterior, Mall mall)
        {
            Random random = new Random();
            int CMAX = ClientesPorDia(CantidadTrabajadores, ClientesDiaAnterior, Volumen, PrecioMinimo, PrecioMaximo);
            int CostoArriendo = Volumen * mall.PrecioMetroCuadrado; // Dado que en el enunciado no dice cuanto es el Precio Arriendo por metro cuadrado asumimos que es 100.
            int V = random.Next(PrecioMinimo, PrecioMaximo);
            int Ganancia = V * CMAX - (CantidadTrabajadores * mall.SueldosPromedio + CostoArriendo);
            GananciaEfectiva = Ganancia;
            int Venta = V * CMAX;
            Ventas = Venta;
        }
        public void SumarCliente()
        {
            ContadorClientes += 1;
        }
        public void IniciarDia()
        {
            ContadorClientes = 0;
        }
        public void TerminarDia(Mall mall)
        {
            this.GananciaLocal(this.PrecioMinimo, this.PrecioMaximo, this.Volumen, this.CantidadTrabajadores, this.ClientesDiaAnterior, mall);
            GananciasDiarias.Add(GananciaEfectiva);
            VentasDiarias.Add(Ventas);
            ClientesDiaAnterior = ContadorClientes;
        }
        public int GananciasTotales()
        {
            int gananciastotales = 0;
            foreach (int ganancia in this.GananciasDiarias)
            {
                gananciastotales += ganancia;
            }
            return gananciastotales;
        }
    }
}
