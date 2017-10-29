namespace ProyectoPOO3
{
    public class LocalEntretencion : Tienda
    {
        public string Categoria;
        public LocalEntretencion(string categoria, int volumen, string nombre, int preciominimo, int preciomaximo, Piso piso) : base(volumen, nombre, preciominimo, preciomaximo, piso)
        {
            this.Categoria = categoria;
        }
    }

}
