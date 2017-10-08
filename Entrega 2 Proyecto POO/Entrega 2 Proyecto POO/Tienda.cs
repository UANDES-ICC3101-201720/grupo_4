using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entrega_2_Proyecto_POO
{
    public abstract class Tienda
    {
        public int Volumen;
        public Piso Piso;
        public string Nombre;
        public int Ganancia;
        public int CantidadTrabajadores;
        public int PrecioMinimo;
        public int PrecioMaximo;
        public List<Trabajadores> Trabajadores;
        public int ContadorClientes;
        public int ClientesAhora;
        public int ClientesDiaAnterior;
        public int GananciaEfectiva;
        public Tienda(int volumen, string nombre, int PrecioMinimo, int PrecioMaximo,Piso Piso)
        {
            this.Piso = Piso;
            this.Volumen = volumen;
            this.Nombre = nombre;
            this.Ganancia = 0;
            this.CantidadTrabajadores = 0;
            this.PrecioMinimo = PrecioMinimo;
            this.PrecioMaximo = PrecioMaximo;
            this.ContadorClientes = 0;
            this.ClientesAhora = 0;
            this.ClientesDiaAnterior = 0;
            this.Trabajadores = new List<Trabajadores>();
            this.GananciaEfectiva = 0;

        }
        public void AgregarTrabajador(Trabajadores Trabajador)
        {
            Trabajadores.Add(Trabajador);
            CantidadTrabajadores += 1;
        }
        public void TiempoEnTienda()
        {

        }
        public void SumarGanancia(int venta)
        {
            Ganancia += venta;
        }
        public int ClientesPorDia(int CantidadTrabajadores,int ClientesDiaAnterior,int AreaLocal,int PrecioMinimo,int PrecioMaximo)
        {
            int CMAX = 0;
            CMAX = ClientesDiaAnterior + AreaLocal / 10 * (Math.Max(100 - (PrecioMinimo + PrecioMinimo) / 2, 0) / 100 )* CantidadTrabajadores;
            return CMAX;
        }
        public void GananciaLocal(int PrecioMinimo,int PrecioMaximo, int Volumen, int CantidadTrabajadores, int ClientesDiaAnterior)
        {
            Random random = new Random();
            int CMAX = ClientesPorDia(CantidadTrabajadores, ClientesDiaAnterior, Volumen, PrecioMinimo, PrecioMaximo);
            int CostoArriendo = Volumen * 100; // Dado que en el enunciado no dice cuanto es el Precio Arriendo por metro cuadrado asumimos que es 100.
            int V = random.Next(PrecioMinimo, PrecioMaximo);
            int Ganancia = V * CMAX - (CantidadTrabajadores + CostoArriendo);
            GananciaEfectiva = Ganancia;


        }
    }
}
