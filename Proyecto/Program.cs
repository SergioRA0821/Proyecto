using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        public enum Menu
        {
            Consultar = 1, Agregar, Actualizar, Eliminar, Salir
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.Consultar:
                        var lista = acciones.Consultar();
                        foreach (var l in lista)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine($"Nombre: {l.Nombre}");
                            Console.WriteLine($"Edad: {l.Edad}");
                            Console.WriteLine($"Matricula: {l.Matricula}");
                            Console.WriteLine("------------");
                        }
                        break;
                    case Menu.Agregar:
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula: ");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        acciones.Agregar(nombre, edad, matricula);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame matricula para actualizar: ");
                        int matr = Convert.ToInt32(Console.ReadLine());

                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Ingresa matricula a elmimnar: ");
                        int mat = Convert.ToInt32(Console.ReadLine());
                        acciones.Eliminar(mat);
                        break;
                    default:
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1) Consultar");
            Console.WriteLine("2) Agregar");
            Console.WriteLine("3) Actualizar");
            Console.WriteLine("4) Eliminar");
            Console.WriteLine("5) Salir");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
