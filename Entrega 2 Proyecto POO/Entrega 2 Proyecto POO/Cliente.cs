using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    public class Cliente : Persona
    {
        public int PresupuestoInicial;
        public int PresupuestoActual;
        public List<Tienda> TiendasVisitadas;
        public bool Auto;
        public Plan_de_Compras Plan;
        public List<Piso> PisosVisitados;
        public Cliente(string nombre,int PresupuestoInicial,bool Auto,Plan_de_Compras Plan) : base(nombre)
        {
            this.PresupuestoActual = PresupuestoInicial;
            this.PresupuestoInicial = PresupuestoInicial;
            this.Auto = Auto;
            this.Plan = Plan;
            this.PisosVisitados = new List<Piso>();
            this.TiendasVisitadas = new List<Tienda>();
        }
    }
}
