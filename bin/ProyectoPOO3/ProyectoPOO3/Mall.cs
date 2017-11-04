using System.Collections.Generic;

namespace ProyectoPOO3
{
    public class Mall
    {
        public int Pisos;
        public int Horas;
        public int MinutoActual;
        public int Dinero;
        public int TotalDeClientes = 0;
        public int SueldosPromedio;
        public int PrecioMetroCuadrado;
        public List<int> ClientesPorDia;
        public void Apertura() { }
        public void Cierre() { }
        public Mall(int Pisos, int Horas, int Dinero,int PrecioMetroCuadrado, int SueldosPromedio)
        {
            this.Pisos = Pisos;
            this.Horas = Horas;
            this.MinutoActual = 0;
            this.Dinero = Dinero;
            this.ClientesPorDia = new List<int>();
            this.PrecioMetroCuadrado = PrecioMetroCuadrado;
            this.SueldosPromedio = SueldosPromedio;
        }
        public void RecepcionCliente()
        {
            TotalDeClientes += 1;
        }
        public void AbrirMall(List<Tienda> Tiendas)
        {
            MinutoActual = 0;
            foreach (Tienda tienda in Tiendas)
            {
                tienda.IniciarDia();
            }
        }
        public void CerrarMall(List<Tienda> Tiendas)
        {
            foreach (Tienda tienda in Tiendas)
            {
                tienda.TerminarDia(this);

            }
        }
    }
}
