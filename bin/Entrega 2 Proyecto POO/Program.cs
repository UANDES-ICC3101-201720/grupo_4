using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entrega_2_Proyecto_POO
{
    class Program
    {
        public static void Reporte1(Mall mall,int dia)
        {
            Console.WriteLine("Cantidad de Clientes recepcionados en el dia "+ dia.ToString()+ " es de "+ mall.TotalDeClientes.ToString());
            mall.ClientesPorDia.Add(mall.TotalDeClientes);
            mall.TotalDeClientes = 0;
        }
        public static void Reporte2(Mall mall, int dias)
        {
            int Total = 0;
            foreach (int clientes in mall.ClientesPorDia)
            {
                Total += clientes;
            }
            double Promedio = Total / dias;
            Console.WriteLine("Promedio de clientes Hasta el dia "+ dias.ToString()+ " es de: "+ Promedio.ToString());
        }
        public static void Reporte3(List<Tienda> Tiendas,int dias)
        {
            int Total = 0;
            foreach (Tienda tienda in Tiendas)
            {
                foreach(int ganancia in tienda.GananciasDiarias)
                {
                    Total += ganancia;
                }
            }
            Console.WriteLine("La ganancia total de todas las Tiendas hasta el dia "+ dias.ToString()+" es de: "+ Total.ToString());
        }
        public static void Reporte4(List<Tienda> Tiendas, int dia)
        {
            int Total = 0;
            int TotalDeTiendas = 0;
            foreach (Tienda tienda in Tiendas)
            { 
                foreach (int ganancia in tienda.GananciasDiarias)
                Total += ganancia;
                TotalDeTiendas += 1;
            }
            double promedio = Total / TotalDeTiendas;
            Console.WriteLine("La ganancia promedio para el dia "+ dia.ToString()+ " es de: "+ promedio.ToString());
        }
        public static void Reporte5(List<Tienda> Tiendas)
        {
            int GananciaMaxima = 0;
            Tienda TiendaMax = null;
            foreach(Tienda tienda in Tiendas)
            {
                int ganancia = 0;
                foreach (int dinero in tienda.GananciasDiarias)
                {
                    ganancia += dinero;
                }
                if (ganancia > GananciaMaxima)
                {
                    GananciaMaxima = ganancia;
                    TiendaMax = tienda;
                }
            }
            try { Console.WriteLine("La tienda con la mayor ganancia total es " + TiendaMax.Nombre + " y su ganancia total es de: " + GananciaMaxima.ToString()); }
            catch
            {
                Console.WriteLine("No todos tienen ganancias negativas para este dia");
            }
        }
        public static void Reporte6(List<Tienda> Tiendas)
        {
            long GananciaMinima = 999999999999999999;
            Tienda TiendaMin = null;
            foreach (Tienda tienda in Tiendas)
            {
                int ganancia = 0;
                foreach (int dinero in tienda.GananciasDiarias)
                {
                    ganancia += dinero;
                }
                if (ganancia < GananciaMinima)
                {
                    GananciaMinima = ganancia;
                    TiendaMin = tienda;
                }
            }
            Console.WriteLine("La tienda con la menor ganancia total es "+ TiendaMin.Nombre+ " y su ganancia total es de: "+ GananciaMinima.ToString());
        }
        public static void Reporte7(List<Tienda> Tiendas,int dia)
        {
            int ClientesAtendidos = 0;
            Tienda LocalMax = null;
            foreach(Tienda tienda in Tiendas)
            {
                if (ClientesAtendidos <= tienda.ContadorClientes)
                {
                    ClientesAtendidos = tienda.ContadorClientes;
                    LocalMax = tienda;
                }
            }
            Console.WriteLine("El local con mayor cantidad de clientes antendidos este dia fue "+ LocalMax.Nombre+ " con una cantidad de "+ ClientesAtendidos.ToString()+ " clientes");
        }
        public static void Reporte8(List<Tienda> Tiendas)
        {
            long ClientesAtendidos = 9999999999999999;
            Tienda LocalMin = null;
            foreach (Tienda tienda in Tiendas)
            {
                if (ClientesAtendidos > tienda.ContadorClientes)
                {
                    ClientesAtendidos = tienda.ContadorClientes;
                    LocalMin = tienda;
                }
            }
            Console.WriteLine("El local con menor cantidad de clientes antendidos este dia fue "+ LocalMin.Nombre+" con una cantidad de "+ClientesAtendidos.ToString()+" clientes");
        }

        static void Main(string[] args)
        {
            Simular simular = new Simular();
            Console.WriteLine("Ingrese la Cantidad de Horas del Mall");
            int minutos = Convert.ToInt32(Console.ReadLine()) * 60;
            Console.Write("Ingrese la Cantidad de dinero inicial del Mall\n");
            int plataMall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la Cantidad de pisos");
            int cantidadPisos = Convert.ToInt32(Console.ReadLine());
            Mall mall = new Mall(cantidadPisos, minutos / 60, plataMall);
            List<int> Area = new List<int>();
            for (int i = 1; i<=cantidadPisos; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Ingrese el Area del Primer piso");
                    int area = Convert.ToInt32(Console.ReadLine());
                    Area.Add(area);
                }
                else
                {
                    Console.WriteLine("Ingrese el Area del siguiente piso");
                    int area = Convert.ToInt32(Console.ReadLine());
                    while (area > Area[i - 2])
                    {
                        Console.WriteLine("El piso no puede ser mas grande que el anterior, ingrese denuevo el area porfavor");
                        area = Convert.ToInt32(Console.ReadLine());
                    }
                    Area.Add(area);
                }              
            }
            simular.CrearPisos(cantidadPisos, Area);
            simular.CrearTrabajadores(simular.PeopleNames, simular.AllStores);
            for (int i=1; i<=10; i++)
            {
                simular.CrearClientes(simular.PeopleNames, simular.AllStores, simular.AllFloors);
                mall.AbrirMall(simular.AllStores);
                for (int j=1; j<=minutos; j++)
                {
                    simular.EntradaAlMall(simular.Clientes, mall);
                    mall.MinutoActual += 1;
                }
                mall.CerrarMall(simular.AllStores);
                Console.WriteLine("");
                Console.WriteLine("Reporte dia: " + i.ToString());
                Reporte1(mall, i);
                Reporte2(mall, i);
                Reporte3(simular.AllStores, i);
                Reporte4(simular.AllStores, i);
                Reporte5(simular.AllStores);
                Reporte6(simular.AllStores);
                Reporte7(simular.AllStores,i);
                Reporte8(simular.AllStores);
                Thread.Sleep(1000);
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.P)
                {
                    Console.ReadKey();
                    
                }
            }
            Console.Read();            
        }
    }
}
