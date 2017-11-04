namespace ProyectoPOO3
{
    public class LocalComida : Tienda
    {
        public LocalComida(string categoria, int volumen, string nombre, int preciominimo, int preciomaximo, Piso piso) : base(volumen, nombre, preciominimo, preciomaximo, piso,categoria)
        {
        }
    }
}
