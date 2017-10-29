namespace ProyectoPOO3
{
    public class Persona
    {
        public string nombre;
        public Piso Piso;
        public Piso PisoEntrar;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public void EntrarMall(Piso Piso, Mall Mall)
        {
            this.Piso = Piso;
            this.PisoEntrar = Piso;
            Mall.RecepcionCliente();

        }
        public void SalirMall()
        {
            this.Piso = null;
        }
    }
}
