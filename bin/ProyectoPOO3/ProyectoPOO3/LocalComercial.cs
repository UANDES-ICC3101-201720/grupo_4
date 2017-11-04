namespace ProyectoPOO3
{
    public class LocalComercial : Tienda
    {


        public LocalComercial(string categoria, int volumen, string nombre, int preciominimo, int preciomaximo, Piso piso) : base(volumen, nombre, preciominimo, preciomaximo, piso, categoria)
        {
        }
    }
}
