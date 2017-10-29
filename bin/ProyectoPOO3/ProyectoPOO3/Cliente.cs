using System;
using System.Linq;

namespace ProyectoPOO3
{
    public class Cliente : Persona
    {
        public int PresupuestoInicial;
        public int PresupuestoActual;
        public bool Auto;
        public int Tiempo;
        public Plan_de_Compras Plan;
        public Cliente(string nombre, int PresupuestoInicial, bool Auto, Piso piso) : base(nombre)
        {
            this.PresupuestoActual = PresupuestoInicial;
            this.PresupuestoInicial = PresupuestoInicial;
            this.Auto = Auto;
            this.Tiempo = 0;
            this.Plan = new Plan_de_Compras();
            this.PisoEntrar = piso;
        }
        public void RecorrerPlan(Plan_de_Compras Plan)
        {
            int LargoPlan = Plan.Tiendas.Count();
            for (int i = 0; i < LargoPlan; i++)
            {
                Random random = new Random();
                if (Plan.Tiendas[i].ClientesAhora == Plan.Tiendas[i].Volumen)
                {
                    Tiempo += 3;
                }
                int demoraentienda = random.Next(Plan.Tiendas[i].Volumen / 2, Plan.Tiendas[i].Volumen);
                Tiempo += demoraentienda;
                int trabajador = random.Next(Plan.Tiendas[i].Trabajadores.Count());
                Plan.Tiendas[i].Trabajadores[trabajador].Atender(Plan.Tiendas[i]);
                if (i != 0)
                {
                    if (Plan.Tiendas[i - 1].Piso != Plan.Tiendas[i].Piso)
                    {
                        Tiempo += 5;
                        this.Piso = Plan.Tiendas[i].Piso;
                    }
                }
            }
            this.SalirMall();
        }

    }
}
