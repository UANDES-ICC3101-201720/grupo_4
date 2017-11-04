using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Threading;

namespace ProyectoPOO3
{
    public class Simular
    {
        public List<Piso> AllFloors = new List<Piso>();
        public List<Tienda> AllStores = new List<Tienda>();
        public List<string> PeopleNames = new List<string> { "Maria Meyer", "Benjamin Lazo", "Jaime Castro", "Pedro Naranjo", "Pichu Contardo", "Benjamin Paredes", "Benjamin Naranjo", "Paz Vairetti", "Carla Mitri", "Jaime Meltrozo", "Aquiles Lazo", "Jose Meyer", "The God Fuc%@* Contardo", "Quecu Contardo", "Carmen Meyer", "Quecu Naranjo", "German Castro", "Maria Vairetti", "Bea Vairetti", "Pichu Soto", "The God Fuc%@* Mitri", "Juan Ferrada", "Maria Stark", "Jaime Stark", "Carmen Lazo", "Bea Meltrozo", "German Satula", "Benjamin Zanartu", "Carmen Raydas", "Pedro Vairetti", "Aquiles Ferrada", "Maria Paredes", "Devora Naranjo", "Andres Paredes", "Aquiles Vera", "Paz Castro", "Aquiles Ferrada", "Aquiles Raydas", "The God Fuc%@* Castro", "Carmen Castro", "Pedro Mitri", "Andres Paredes", "Pedro Satula", "Jaime Castro", "Rosa Vairetti", "Bea Satula", "The God Fuc%@* Diaz", "Paz Vera", "Andres Lazo", "The God Fuc%@* Vairetti", "Aquiles Diaz", "Rosa Ferrada", "Rosa Zanartu", "Aquiles Meltrozo", "Bea Meltrozo", "Carmen Meltrozo", "German Sepulveda", "Quecu Zanartu", "Carmen Vera", "German Zanartu", "Rosa Lazo", "Juan Paredes", "The God Fuc%@* Diaz", "Benjamin Raydas", "Juan Soto", "Aquiles Raydas", "German Meyer", "The God Fuc%@* Lazo", "Quecu Vairetti", "Paz Castro", "Jaime Satula", "German Vairetti", "Cata Meyer", "Maria Stark", "Jose Mitri", "Bea Satula", "German Sepulveda", "German Castro", "Andres Raydas", "Juan Raydas", "The God Fuc%@* Castro", "Paz Raydas", "Bea Raydas", "Quecu Contardo", "Paz Soto", "Aquiles Ferrada", "Rosa Raydas", "Pedro Satula", "Carmen Meltrozo", "Pedro Vera", "Cata Vairetti", "Jaime Sepulveda", "The God Fuc%@* Ferrada", "Benjamin Paredes", "The God Fuc%@* Soto", "Jose Mitri", "Jaime Zanartu", "Pichu Diaz", "German Vera", "Maria Contardo", "Cata Ferrada", "Andres Vairetti", "Pedro Paredes", "Pedro Raydas", "Paz Vairetti", "Aquiles Soto", "Jose Vera", "Cata Vera", "Bea Stark", "Andres Satula", "Paz Diaz", "Bea Meltrozo", "The God Fuc%@* Diaz", "Quecu Vairetti", "German Paredes", "Benjamin Raydas", "Andres Paredes", "Jose Contardo", "German Contardo", "German Naranjo", "Paz Stark", "Paz Naranjo", "Aquiles Mitri", "Carmen Zanartu", "Pedro Meltrozo", "Aquiles Paredes", "Benjamin Vairetti", "Juan Satula", "Carla Satula", "Maria Contardo", "Andres Soto", "The God Fuc%@* Raydas", "Pichu Meltrozo", "Pichu Ferrada", "Devora Sepulveda", "Bea Zanartu", "Jaime Lazo", "Aquiles Ferrada", "Carla Stark", "Benjamin Contardo", "The God Fuc%@* Raydas", "Andres Ferrada", "German Vera", "Rosa Diaz", "Benjamin Meltrozo", "Bea Satula", "Benjamin Castro", "German Diaz", "Maria Stark", "Rosa Vera", "Aquiles Castro", "Aquiles Zanartu", "Jose Diaz", "Maria Meltrozo", "Pedro Raydas", "Rosa Zanartu", "Paz Raydas", "German Paredes", "Paz Castro", "Rosa Ferrada", "Rosa Castro", "Bea Naranjo", "Jaime Naranjo", "German Meltrozo", "Pedro Castro", "Jaime Meyer", "Bea Stark", "Rosa Ferrada", "Aquiles Naranjo", "Benjamin Vairetti", "Paz Meltrozo", "Maria Ferrada", "Andres Contardo", "Rosa Satula", "Jaime Satula", "Andres Zanartu", "Carmen Diaz", "Carmen Mitri", "Carmen Soto", "Pedro Castro", "Aquiles Meltrozo", "Benjamin Vairetti", "Pichu Naranjo", "Rosa Soto", "Jaime Meltrozo", "Devora Mitri", "Rosa Vairetti", "German Castro", "Andres Satula", "German Ferrada", "Jose Naranjo", "Bea Diaz", "Jaime Ferrada", "Aquiles Contardo", "German Satula", "Cata Meltrozo", "Pichu Vera", "Benjamin Castro", "Juan Mitri", "Maria Contardo", "Benjamin Raydas", "Benjamin Diaz", "Carmen Mitri", "The God Fuc%@* Naranjo", "Carla Lazo", "Devora Ferrada", "Pedro Stark", "Jose Meltrozo", "Cata Contardo", "Aquiles Lazo", "Pichu Soto", "Andres Vera", "Jaime Ferrada", "Juan Zanartu", "Juan Vera", "The God Fuc%@* Meyer", "Cata Zanartu", "Jaime Raydas", "Devora Diaz", "Maria Lazo", "Pichu Castro", "The God Fuc%@* Vera", "Andres Mitri", "Andres Zanartu", "Carmen Zanartu", "Rosa Stark", "Devora Meltrozo", "Jaime Sepulveda", "Pedro Naranjo", "Benjamin Mitri", "Carmen Lazo", "Carla Vairetti", "Benjamin Naranjo", "Carmen Vairetti", "Carmen Lazo", "Cata Castro", "Paz Ferrada", "Juan Mitri", "Andres Raydas", "Bea Soto", "Carmen Soto", "Andres Meltrozo", "Bea Naranjo", "Benjamin Mitri", "Carmen Stark", "Quecu Soto", "Carmen Mitri", "Pichu Mitri", "Paz Satula", "Maria Meltrozo", "Carmen Castro", "Jaime Ferrada", "Carmen Soto", "Quecu Naranjo", "The God Fuc%@* Contardo", "Paz Naranjo", "Carla Stark", "German Meyer", "Aquiles Naranjo", "Carla Paredes", "Paz Raydas", "Carmen Zanartu", "Devora Vairetti", "The God Fuc%@* Sepulveda", "Devora Castro", "Pedro Mitri", "Paz Satula", "Devora Zanartu", "Jose Ferrada", "Pedro Zanartu", "Pedro Vera", "Carmen Lazo", "Carmen Paredes", "Jaime Naranjo", "Cata Raydas", "Benjamin Sepulveda", "Carla Diaz", "Juan Sepulveda", "German Vera", "Jose Stark", "Jose Meltrozo", "Maria Castro", "Cata Contardo", "The God Fuc%@* Castro", "Bea Zanartu", "Aquiles Stark", "Cata Diaz", "Devora Sepulveda", "Carmen Ferrada", "Bea Vera", "Paz Diaz", "Pichu Mitri", "Pedro Meyer", "Maria Contardo", "The God Fuc%@* Raydas", "Quecu Soto", "Jose Zanartu", "Devora Castro", "Jose Meyer", "Aquiles Raydas", "The God Fuc%@* Zanartu", "Jose Naranjo", "Carla Naranjo", "Paz Contardo", "Pichu Soto", "Rosa Stark", "Quecu Diaz", "Carmen Meltrozo", "Carmen Soto", "Jaime Sepulveda", "Andres Stark", "Andres Vairetti", "Juan Meltrozo", "Aquiles Zanartu", "The God Fuc%@* Raydas", "The God Fuc%@* Naranjo", "Jaime Meltrozo", "Paz Vairetti", "Quecu Soto", "Andres Sepulveda", "Jose Sepulveda", "Maria Meyer", "Paz Sepulveda", "Jose Vera", "Bea Diaz", "German Raydas", "Pichu Meyer", "Benjamin Mitri", "German Diaz", "Aquiles Meltrozo", "Andres Mitri", "Juan Raydas", "Cata Soto", "German Soto", "Carla Stark", "The God Fuc%@* Stark", "German Paredes", "Paz Paredes", "Carmen Lazo", "Maria Vairetti", "Benjamin Diaz", "Carla Naranjo", "Aquiles Satula", "Bea Satula", "Paz Raydas", "Aquiles Naranjo", "Carla Mitri", "Devora Vairetti", "Aquiles Ferrada", "Pedro Zanartu", "Maria Meltrozo", "Bea Zanartu", "Maria Meltrozo", "Quecu Castro", "Rosa Mitri", "German Vera", "Jaime Satula", "Rosa Meltrozo", "Maria Soto", "Quecu Soto", "Devora Soto", "German Contardo", "Maria Meyer", "Devora Meyer", "Maria Meyer", "Quecu Mitri", "Andres Castro", "Quecu Castro", "Cata Mitri", "Pedro Lazo", "Devora Meyer", "Bea Contardo", "German Naranjo", "Jaime Castro", "Carmen Naranjo", "Aquiles Satula", "Aquiles Mitri", "Jose Satula", "Andres Vairetti", "Benjamin Raydas", "Jose Satula", "Aquiles Zanartu", "Jose Ferrada", "Cata Ferrada", "German Meyer", "Maria Castro", "Jaime Contardo", "Rosa Vairetti", "Benjamin Stark", "Rosa Vairetti", "Carla Satula", "Juan Naranjo", "German Sepulveda", "Carla Stark", "Paz Vera", "Carla Satula", "Maria Mitri", "Paz Lazo", "Juan Ferrada", "Jose Sepulveda", "The God Fuc%@* Raydas", "Juan Raydas", "Devora Ferrada", "Carmen Naranjo", "The God Fuc%@* Mitri", "Aquiles Lazo", "Carmen Vairetti", "Paz Diaz", "The God Fuc%@* Zanartu", "Jaime Sepulveda", "Maria Meltrozo", "Rosa Satula", "Quecu Naranjo", "Carmen Stark", "Rosa Ferrada", "Jose Soto", "Aquiles Meltrozo", "Carla Satula", "Bea Stark", "Rosa Meyer", "Bea Diaz", "Bea Meyer", "Quecu Mitri", "Quecu Meltrozo", "Maria Stark", "German Stark", "Cata Raydas", "Jaime Stark", "Jose Castro", "Pichu Ferrada", "Jaime Satula", "Rosa Ferrada", "Jose Vairetti", "Pedro Castro", "German Soto", "Carla Contardo", "Pichu Castro", "Cata Satula", "Cata Naranjo", "Carla Zanartu", "Benjamin Contardo", "Juan Sepulveda", "Devora Meltrozo", "Andres Raydas", "Pedro Vairetti", "Carla Naranjo", "Andres Stark", "Maria Stark", "Jose Contardo", "Maria Meltrozo", "Aquiles Vairetti", "Carmen Meltrozo", "Pichu Castro", "Aquiles Soto", "Aquiles Stark", "Juan Diaz", "Pichu Satula", "Benjamin Stark", "Rosa Sepulveda", "Pichu Raydas", "Devora Castro", "Bea Contardo", "Jaime Castro", "German Meyer", "Jaime Naranjo", "Aquiles Satula", "Bea Vera", "Carla Naranjo", "Pichu Lazo", "Andres Raydas", "Jose Mitri", "Carmen Vairetti", "Quecu Contardo", "Pichu Ferrada", "Pichu Contardo", "Andres Sepulveda", "The God Fuc%@* Raydas", "Jose Zanartu", "Bea Satula", "Bea Vera", "Bea Mitri", "Bea Stark", "Devora Paredes", "Juan Contardo", "German Raydas", "Paz Soto", "Paz Diaz", "Paz Meltrozo", "Carla Lazo", "Bea Paredes", "Juan Ferrada", "Aquiles Raydas", "Quecu Meltrozo", "Devora Vairetti", "Quecu Lazo", "Bea Meyer", "Pichu Castro", "Carla Lazo", "Carmen Raydas", "Juan Sepulveda", "Rosa Ferrada", "Aquiles Meyer", "Carmen Naranjo", "Cata Stark", "Bea Vera", "The God Fuc%@* Satula", "Juan Naranjo", "Pichu Sepulveda", "Maria Zanartu", "Pedro Zanartu", "Carla Mitri", "Jose Satula", "Maria Sepulveda", "Bea Stark", "Carla Mitri", "Pedro Vera", "The God Fuc%@* Raydas", "Carla Soto", "Cata Paredes", "Carla Vairetti", "Bea Contardo", "Benjamin Soto", "Cata Castro", "Jose Vera", "The God Fuc%@* Ferrada", "Pichu Contardo", "Pichu Meltrozo", "Andres Meyer", "Devora Sepulveda", "Andres Meltrozo", "Rosa Paredes", "German Zanartu", "Pedro Diaz", "Benjamin Meyer", "Pedro Satula", "Pedro Meltrozo", "Juan Castro", "Devora Paredes", "Benjamin Soto", "The God Fuc%@* Naranjo", "Quecu Stark", "Andres Contardo", "Jaime Castro", "Juan Vera", "Andres Naranjo", "Juan Satula", "Maria Contardo", "Benjamin Castro", "Aquiles Satula", "Carmen Vera", "Paz Lazo", "Carla Diaz", "Pedro Contardo", "Carmen Paredes", "Maria Stark", "German Zanartu", "Maria Lazo", "Bea Meltrozo", "Maria Soto", "Aquiles Zanartu", "Cata Contardo", "Cata Raydas", "The God Fuc%@* Meltrozo", "Maria Vera", "Benjamin Meyer", "Carla Paredes", "Jose Raydas", "Bea Vairetti", "Jaime Naranjo", "Carmen Contardo", "Quecu Vairetti", "Carla Raydas", "Benjamin Soto", "Aquiles Satula", "Aquiles Diaz", "Jaime Diaz", "Andres Naranjo", "Quecu Zanartu", "Benjamin Diaz", "Devora Lazo", "Paz Meltrozo", "Rosa Meyer", "Pedro Vera", "Jose Zanartu", "Benjamin Zanartu", "Jose Vairetti", "Jose Sepulveda", "German Naranjo", "Juan Vera", "Andres Lazo", "The God Fuc%@* Diaz", "Maria Raydas", "Paz Meyer", "The God Fuc%@* Mitri", "Jaime Zanartu", "Quecu Meltrozo", "Pedro Raydas", "The God Fuc%@* Stark", "Carla Meyer", "Juan Meyer", "Pichu Satula", "Quecu Diaz", "Andres Naranjo", "German Zanartu", "The God Fuc%@* Vairetti", "Pedro Satula", "Jaime Meltrozo", "Jose Contardo", "Paz Stark", "Quecu Zanartu", "Paz Meltrozo", "Jaime Diaz", "Paz Meltrozo", "Pedro Vera", "Andres Contardo", "Cata Raydas", "Quecu Raydas", "Pedro Paredes", "Juan Meyer", "Maria Mitri", "Aquiles Vairetti", "Benjamin Vairetti", "Jose Mitri", "Jose Naranjo", "Rosa Castro", "Quecu Zanartu", "Quecu Vera", "Maria Meyer", "Aquiles Lazo", "Devora Mitri", "Jaime Zanartu", "Paz Soto", "Cata Vera", "Carla Mitri", "Andres Satula", "Bea Sepulveda", "Rosa Vera", "Juan Naranjo", "Benjamin Satula", "Juan Zanartu", "Bea Satula", "Pedro Vairetti", "Cata Mitri", "Carla Meyer", "Carmen Mitri", "Cata Paredes", "Benjamin Meltrozo", "Jose Zanartu", "Maria Vera", "German Castro", "Aquiles Ferrada", "Jose Vairetti", "Andres Sepulveda", "German Naranjo", "Bea Sepulveda", "Devora Satula", "Rosa Contardo", "The God Fuc%@* Paredes", "Carmen Contardo", "Quecu Satula", "Benjamin Lazo", "Andres Vera", "Juan Sepulveda", "Pichu Lazo", "Paz Lazo", "Rosa Zanartu", "Devora Paredes", "Benjamin Ferrada", "Andres Diaz", "Jaime Lazo", "Benjamin Paredes", "Aquiles Stark", "Carmen Vera", "Pedro Raydas", "Jose Meltrozo", "Cata Vera", "Quecu Mitri", "Juan Castro", "Juan Mitri", "Paz Diaz", "Rosa Ferrada", "Pichu Meyer", "Andres Paredes", "Pichu Lazo", "The God Fuc%@* Sepulveda", "German Meltrozo", "Devora Vairetti", "Jaime Vera", "Pichu Contardo", "Carmen Mitri", "Pichu Diaz", "Jaime Vera", "Cata Raydas", "Paz Stark", "Cata Meltrozo", "Maria Diaz", "Cata Contardo", "Pichu Satula", "Andres Satula", "Pedro Diaz", "Andres Meyer", "Maria Contardo", "The God Fuc%@* Vera", "Jose Zanartu", "Paz Castro", "Carmen Paredes", "Aquiles Contardo", "Benjamin Zanartu", "Carla Castro", "Cata Vera", "Carla Meltrozo", "Benjamin Zanartu", "Cata Meyer", "Benjamin Lazo", "Pedro Ferrada", "Devora Satula", "Benjamin Diaz", "Devora Soto", "The God Fuc%@* Vera", "German Castro", "Rosa Vairetti", "Pichu Ferrada", "German Lazo", "Andres Diaz", "Bea Sepulveda", "Jose Castro", "Pichu Contardo", "Jaime Castro", "Andres Castro", "Jaime Vairetti", "Cata Vera", "Jose Vairetti", "Cata Naranjo", "Jaime Vairetti", "Bea Contardo", "Jaime Meyer", "Devora Castro", "Carmen Meyer", "Rosa Castro", "Andres Meltrozo", "Quecu Zanartu", "Benjamin Meltrozo", "Bea Vairetti", "Jose Soto", "The God Fuc%@* Mitri", "Carla Vairetti", "Paz Paredes", "Cata Diaz", "Andres Stark", "Carla Soto", "Jose Vera", "Paz Satula", "Jose Sepulveda", "Jaime Vera", "Benjamin Paredes", "German Meltrozo", "Benjamin Ferrada", "Andres Diaz", "Juan Soto", "Bea Satula", "German Ferrada", "Pichu Mitri", "Juan Raydas", "Rosa Stark", "Pichu Meltrozo", "Jose Ferrada", "Quecu Lazo", "Jaime Meltrozo", "Rosa Diaz", "Aquiles Contardo", "Paz Vera", "Carla Ferrada", "Jose Contardo", "Cata Raydas", "Aquiles Vera", "Juan Paredes", "German Stark", "German Satula", "German Sepulveda", "Andres Soto", "Carmen Meyer", "Quecu Sepulveda", "Maria Zanartu", "Aquiles Raydas", "Carla Meyer", "Quecu Contardo", "Carla Diaz", "Pichu Naranjo", "Maria Diaz", "Bea Sepulveda", "Pedro Meltrozo", "Cata Sepulveda", "German Meyer", "Cata Lazo", "Devora Diaz", "Carmen Zanartu", "Aquiles Diaz", "Carla Contardo", "Carla Meltrozo", "German Contardo", "German Paredes", "Bea Meltrozo", "The God Fuc%@* Contardo", "Carmen Diaz", "Jaime Castro", "Juan Lazo", "Jaime Raydas", "Paz Castro", "Jaime Vairetti", "Pichu Sepulveda", "Aquiles Naranjo", "Pedro Contardo", "Jose Mitri", "Quecu Contardo", "Andres Raydas", "Pichu Vairetti", "Maria Soto", "Maria Vera", "Rosa Zanartu", "Carmen Diaz", "Pedro Meyer", "Aquiles Satula", "Cata Diaz", "Aquiles Contardo", "Andres Castro", "German Meyer", "Bea Stark", "Pichu Castro", "Jaime Ferrada", "German Raydas", "Cata Vera", "Benjamin Stark", "Jaime Lazo", "Cata Raydas", "Aquiles Mitri", "Rosa Diaz", "Aquiles Meyer", "Andres Mitri", "Rosa Lazo", "Quecu Raydas", "German Zanartu", "Carla Mitri", "Jaime Sepulveda", "Juan Vera", "Juan Stark", "Andres Ferrada", "Rosa Vera", "Maria Vairetti", "Aquiles Contardo", "Bea Stark", "Jose Castro", "Paz Mitri", "Jose Soto", "Quecu Meltrozo", "Cata Paredes", "Pichu Ferrada", "Pedro Paredes", "Pichu Paredes", "Carmen Contardo", "Andres Vera", "Quecu Raydas", "Paz Mitri", "The God Fuc%@* Soto", "Andres Zanartu", "Cata Paredes", "Juan Meltrozo", "Maria Ferrada", "German Vairetti", "Paz Castro", "Quecu Ferrada", "Jose Naranjo", "Pichu Paredes", "Carmen Lazo", "Jaime Vera", "The God Fuc%@* Stark", "Carla Castro", "Benjamin Paredes", "Jose Naranjo", "Jose Ferrada", "Jaime Castro", "Cata Meyer", "The God Fuc%@* Paredes", "Devora Meltrozo", "Quecu Meyer", "Quecu Soto", "Jaime Vairetti", "Benjamin Castro", "Pichu Zanartu", "Maria Vera", "German Vera", "Cata Meltrozo", "Andres Vera", "Carla Mitri", "Cata Sepulveda", "German Contardo", "Benjamin Zanartu", "Rosa Mitri", "Benjamin Lazo", "Andres Mitri", "Devora Vairetti", "The God Fuc%@* Contardo", "Quecu Zanartu", "Maria Naranjo", "Pichu Diaz", "Pedro Zanartu", "German Stark", "Juan Mitri", "Juan Castro", "Benjamin Ferrada", "Carla Naranjo", "Rosa Meyer", "Quecu Ferrada", "Carla Soto", "Carmen Soto", "Rosa Vera", "Maria Stark", "Devora Naranjo", "Devora Ferrada", "Jose Meltrozo", "Juan Naranjo", "Paz Zanartu", "Benjamin Castro", "Paz Satula", "Jose Meltrozo", "Jose Stark", "Carmen Diaz", "Devora Raydas", "German Meltrozo", "Benjamin Paredes", "Paz Soto", "The God Fuc%@* Diaz", "Benjamin Sepulveda", "Juan Soto", "Jose Raydas", "Jaime Lazo", "Carmen Satula", "German Paredes", "Aquiles Naranjo", "Bea Meyer", "Pichu Zanartu", "Bea Vera", "Carla Castro", "Jaime Vera", "Carla Vairetti", "Maria Ferrada", "Cata Sepulveda", "Andres Raydas", "Aquiles Meltrozo", "German Lazo", "Quecu Zanartu", "Benjamin Sepulveda", "Pichu Zanartu", "Jose Vairetti", "Devora Raydas", "Maria Raydas", "The God Fuc%@* Raydas", "Quecu Vera", "The God Fuc%@* Meyer", "Carmen Soto", "Jaime Lazo", "Carla Meyer", "Quecu Lazo", "Benjamin Meyer", "Aquiles Naranjo", "Cata Meltrozo", "The God Fuc%@* Zanartu", "Paz Paredes", "Bea Zanartu", "Aquiles Soto", "Juan Sepulveda", "Juan Meyer", "Andres Contardo", "Benjamin Meltrozo", "The God Fuc%@* Raydas", "German Mitri", "Devora Meltrozo", "Devora Diaz", "Benjamin Meltrozo", "Juan Lazo", "Carla Diaz", "German Mitri", "Paz Mitri", "Devora Raydas", "Jaime Vera", "Carmen Satula", "Cata Satula", "Benjamin Naranjo", "Carmen Paredes", "Rosa Raydas", "Juan Soto", "Devora Contardo", "Devora Vairetti", "Pichu Ferrada", "Aquiles Meltrozo", "Maria Meltrozo", "The God Fuc%@* Soto", "The God Fuc%@* Ferrada", "Aquiles Ferrada", "Rosa Soto", "German Sepulveda" };
        public List<Cliente> Clientes = new List<Cliente>();
        public List<string> StoresNames = new List<string> { "Accenture", "Wells Fargo", "Estee Lauder", "ING", "Dell", "Hyundai", "Allianz", "Lexus", "Mastercard", "Colgate", "Nintendo", "Home Depot", "UPS", "Kraft", "IKEA", "Nestle", "ESPN", "Facebook", "Mercedes-Benz", "BMW,Subway", "Porsche", "Dell", "Sony", "Rolex", "Bank of America", "Caterpillar", "Canon", "Zara", "Louis Vuitton", "Samsung", "McDonald’s", "Microsoft", "Apple", "Armani", "Versace", "Gucci", "Burberry", "Ermenegildo Zegna", "Omega", "Tiffany & Co.", "Dolce & Gabbana ", "Carolina Herrera", "Longchamp", "Salvatore Ferragamo", "Louis Vuitton", "Tory Burch, ", "Jimmy Choo", "Ralph Lauren", "Michael Kors", "Jumbo", "Abcdin", "Tricot", "Johnson", "La Polar", "Homecenter Sodimac", "Tottus", "Falabella", "Armani Exchange", "Banana Republic", "Hugo Boss", "The North Face", "Kipling", "Gap", "Swarovski ", "Zara", "H&M", "París", "Ripley", "Nike", "Rosen", "Colun", "Carozzi", "Soprole", "Nestle", "Teleton", "Iansa", "Cav", "Mac", "Burger King", "Lee", "OPV", "Place Vandome", "Farmacia Ahumada", "Lider", "Wallmart", "Sparta", "Doite", "Tip y Tap", "Asus", "MSI", "Columbia", "Ruby Tuesday", "Mr Jack", "LG", "Bianchi", "SHot", "Cuncuna", "Emporio de la rosa", "Lapiz Lopez ", "Sex Shop", "Lucas Bar", "We Play", "Aliexpress", "Latam", "Microplay", "Ripcurl", "CineHoyts", "Cineplanet", "Sushisan", "Maldito sushi", "Swaroski" };
        public List<string> Reportes = new List<string>();
        public string reporte = "";
        public Mall mall;
        public int DiaActual = 1;
        public int aux = 0;

        public Mall Mall { get => mall; set => mall = value; }

        public void CrearClientes(List<string> Nombres, List<Tienda> Tiendas, List<Piso> Pisos)
        {
            Random random = new Random();
            int CantidadClientes = random.Next(4000, 25000);
            for (int i = 0; i <= CantidadClientes; i++)
            {
                List<Piso> aux = new List<Piso>();
                foreach (Piso piso in Pisos)
                {
                    aux.Add(piso);
                }
                string nombre = Nombres[random.Next(Nombres.Count())];
                int presupuesto = random.Next(5000, 20000);
                List<bool> autos = new List<bool> { true, false };
                bool auto = autos[random.Next(autos.Count())];
                int pisornd = 0;
                if (aux.Count() == 1)
                {
                    pisornd = 0;
                    Cliente cliente = new Cliente(nombre, presupuesto, auto, aux[pisornd]);
                    Plan_de_Compras Plan = new Plan_de_Compras();
                    Plan.GenerarPlan(Tiendas, Pisos, cliente);
                    cliente.Plan = Plan;
                    Clientes.Add(cliente);
                }
                if (aux.Count() > 1)
                {
                    pisornd = random.Next(aux.Count());
                    Cliente cliente = new Cliente(nombre, presupuesto, auto, aux[pisornd]);
                    Plan_de_Compras Plan = new Plan_de_Compras();
                    Plan.GenerarPlan(Tiendas, Pisos, cliente);
                    cliente.Plan = Plan;
                    Clientes.Add(cliente);
                }

            }

        }
        public void CrearTrabajadores(List<string> Nombres, List<Tienda> Tiendas)
        {
            foreach (Tienda tienda in Tiendas)
            {
                Random random = new Random();
                int MaxTrabajadores = random.Next(10);
                for (int i = 0; i <= MaxTrabajadores; i++)
                {
                    string nombre = Nombres[random.Next(Nombres.Count())];
                    Trabajadores trabajador = new Trabajadores(nombre, tienda);
                    tienda.AgregarTrabajador(trabajador);
                }
            }
        }
        public void CrearPisos(int Cantidad, List<int> Area)
        {
            for (int i = 1; i <= Cantidad; i++)
            {
                Piso piso = new Piso(Area[i - 1], 100, i);
                AllFloors.Add(piso);
            }
        }

        public void CrearLocalesPorPiso(int Area, Piso piso)
        {


            List<string> Comercial = new List<string> { "Ropa", "Hogar", "Alimento", "Ferreteria", "Tecnologia" };
            List<string> Comida = new List<string> { "Rapida", "Restaurant" };
            List<string> Entretencion = new List<string> { "Cine", "Juegos", "Bowling" };
            List<string> Tipo = new List<string> { "Comercial", "Comida", "Entretencion" };
            Random random = new Random();
            int b = random.Next(Comercial.Count());
            int c = random.Next(Comida.Count());
            int d = random.Next(Entretencion.Count());
            int preciominimo = random.Next(2000);
            int preciomaximo = random.Next(2000, 10000);
            
            if (Tipo[aux] == "Comercial")
            {
                string nombre = StoresNames[random.Next(StoresNames.Count())];
                LocalComercial local = new LocalComercial(Comercial[b], Area, nombre, preciominimo, preciomaximo, piso);
                StoresNames.Remove(nombre);
                piso.AgregarTienda(local, Area);
                AllStores.Add(local);
                MessageBox.Show(Tipo[aux]);
            }
            if (Tipo[aux] == "Entretencion")
            {
                string nombre = StoresNames[random.Next(StoresNames.Count())];
                LocalEntretencion local = new LocalEntretencion(Comercial[b], Area, nombre, preciominimo, preciomaximo, piso);
                StoresNames.Remove(nombre);
                piso.AgregarTienda(local, Area);
                AllStores.Add(local);
                MessageBox.Show(Tipo[aux]);
                aux = 0;
            }
            if (Tipo[aux] == "Comida")
            {
                string nombre = StoresNames[random.Next(StoresNames.Count())];
                LocalComida local = new LocalComida(Comercial[b], Area, nombre, preciominimo, preciomaximo, piso);
                StoresNames.Remove(nombre);
                piso.AgregarTienda(local, Area);
                AllStores.Add(local);
                MessageBox.Show(Tipo[aux]);
                
                
            }
            
            aux += 1;
            

        }
        public void EntradaAlMall(List<Cliente> Clientes, Mall mall)
        {
            Random random = new Random();
            int cantidad = random.Next(4, 10);
            for (int i = 0; i <= cantidad; i++)
            {
                if (Clientes.Count() == 1)
                {
                    int clientepos = 0;
                    Cliente cliente = Clientes[clientepos];
                    cliente.EntrarMall(cliente.PisoEntrar, mall);
                    cliente.RecorrerPlan(cliente.Plan);
                    Clientes.Remove(cliente);
                }
                if (Clientes.Count() > 1)
                {
                    int clientepos = random.Next(Clientes.Count());
                    Cliente cliente = Clientes[clientepos];
                    cliente.EntrarMall(cliente.PisoEntrar, mall);
                    cliente.RecorrerPlan(cliente.Plan);
                    Clientes.Remove(cliente);
                }
            }
        }
        public void Reporte1(Mall mall, int dia)
        {
            reporte += "Cantidad de Clientes recepcionados en el dia " + dia.ToString() + " es de " + mall.TotalDeClientes.ToString() + "\n";
            mall.ClientesPorDia.Add(mall.TotalDeClientes);
            mall.TotalDeClientes = 0;
        }
        public void Reporte2(Mall mall, int dias)
        {
            int Total = 0;
            foreach (int clientes in mall.ClientesPorDia)
            {
                Total += clientes;
            }
            double Promedio = Total / dias;
            reporte += "Promedio de clientes Hasta el dia " + dias.ToString() + " es de: " + Promedio.ToString() + "\n";
        }
        public void Reporte3(List<Tienda> Tiendas, int dias)
        {
            int Total = 0;
            foreach (Tienda tienda in Tiendas)
            {
                foreach (int ganancia in tienda.GananciasDiarias)
                {
                    Total += ganancia;
                }
            }
            reporte += "La ganancia total de todas las Tiendas hasta el dia " + dias.ToString() + " es de: " + Total.ToString() + "\n";
        }
        public void Reporte4(List<Tienda> Tiendas, int dia)
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
            reporte += "La ganancia promedio para el dia " + dia.ToString() + " es de: " + promedio.ToString() + "\n";
        }
        public void Reporte5(List<Tienda> Tiendas)
        {
            int GananciaMaxima = 0;
            Tienda TiendaMax = null;
            foreach (Tienda tienda in Tiendas)
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
            try { reporte += "La tienda con la mayor ganancia total es " + TiendaMax.Nombre + " y su ganancia total es de: " + GananciaMaxima.ToString() + "\n"; }
            catch
            {
                reporte += "No ,todos tienen ganancias negativas para este dia" + "\n";
            }
        }
        public void Reporte6(List<Tienda> Tiendas)
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
            reporte += "La tienda con la menor ganancia total es " + TiendaMin.Nombre + " y su ganancia total es de: " + GananciaMinima.ToString() + "\n";
        }
        public void Reporte7(List<Tienda> Tiendas, int dia)
        {
            int ClientesAtendidos = 0;
            Tienda LocalMax = null;
            foreach (Tienda tienda in Tiendas)
            {
                if (ClientesAtendidos <= tienda.ContadorClientes)
                {
                    ClientesAtendidos = tienda.ContadorClientes;
                    LocalMax = tienda;
                }
            }
            reporte += "El local con mayor cantidad de clientes antendidos este dia fue " + LocalMax.Nombre + " con una cantidad de " + ClientesAtendidos.ToString() + " clientes" + "\n";
        }
        public void Reporte8(List<Tienda> Tiendas)
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
            reporte += "El local con menor cantidad de clientes antendidos este dia fue " + LocalMin.Nombre + " con una cantidad de " + ClientesAtendidos.ToString() + " clientes" + "\n";
        }

    }

}