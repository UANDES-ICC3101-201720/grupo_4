namespace ProyectoPOO3
{
    public class Trabajadores : Persona
    {
        public Tienda Tienda;
        public Trabajadores(string nombre, Tienda Tienda) : base(nombre)
        {
            this.Tienda = Tienda;
        }
        public void Atender(Tienda tienda)
        {
            tienda.SumarCliente();
        }
    }

}
