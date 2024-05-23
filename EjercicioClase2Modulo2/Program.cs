using System.Linq;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25, 10, 99, 105, 1, 84, 22 };


            Console.WriteLine("EJERCICIO 1 ------------------------");
            Console.WriteLine(lstNumeros.Max());

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            lstNombres.Sort();


            Console.WriteLine("EJERCICIO 2 ------------------------");
            foreach (var nombre in lstNombres)
            {
                Console.WriteLine($"{nombre}");
            }
            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola

            var clientesVip = lstClientes.Where(cliente => cliente.Vip);

            Console.WriteLine("EJERCICIO 3 ------------------------");
            foreach ( var cliente in clientesVip)
            {
                Console.WriteLine($"{cliente.Nombre}");
            }

            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            var nuevaLista = lstClientes.Select(s => s.Nombre).ToList();

            Console.WriteLine("EJERCICIO 4 ------------------------");
            foreach ( var nombre  in nuevaLista)
            {
                Console.WriteLine($"{nombre}");
            }
            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"


            Console.WriteLine("EJERCICIO 5 ------------------------");

            var datosModificados = lstClientes.Select(cliente => new { Nombre = cliente.Nombre.ToUpper(), Apellido = cliente.Apellido.ToUpper(), Vip = cliente.Vip == true ? "Premium" : "Normal" });
            foreach(var cliente  in datosModificados)
            {
                Console.WriteLine($"Nombre del cliente: {cliente.Nombre}, apellido: {cliente.Apellido} y rango: {cliente.Vip}");
            }
            #endregion
        }
    }
}