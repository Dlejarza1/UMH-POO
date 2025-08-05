using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoHoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("* Calculadora de Salario Semanal de Trabajador *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("\nEsta aplicación calcula el salario semanal basado en el costo por hora y las horas trabajadas.");

            Console.WriteLine("También muestra el total devengado ingresado como referencia.");


            decimal costoPorHora;
            decimal cantidadHorasTrabajadas;
            decimal totalDevengado;

            // Bucle para obtener y validar el costo por hora trabajada
            while (true)
            {
                Console.Write("\nIngrese el costo de hora trabajada (ej. 50.50): ");
                string inputCosto = Console.ReadLine();
                if (decimal.TryParse(inputCosto, out costoPorHora))
                {
                    if (costoPorHora >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: El costo por hora no puede ser negativo.Por favor, ingrese un valor válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Por favor, ingrese un valor numérico válido para el costo por hora.");
                }
            }

            // Bucle para obtener y validar la cantidad de horas trabajadas
            while (true)
            {
                Console.Write("Ingrese la cantidad de horas trabajadas (ej. 1.30): ");

                string inputHoras = Console.ReadLine();
                if (decimal.TryParse(inputHoras, out cantidadHorasTrabajadas))
                {
                    if (cantidadHorasTrabajadas >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: La cantidad de horas trabajadas no puede ser negativa.Por favor, ingrese un valor válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Por favor, ingrese un valor numérico válido para las horas trabajadas.");
                }
            }

            // Bucle para obtener y validar el total devengado
            while (true)
            {
                Console.Write("Ingrese el total devengado (ej. 600.00): ");
                string inputDevengado = Console.ReadLine();
                if (decimal.TryParse(inputDevengado, out totalDevengado))
                {
                    if (totalDevengado >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: El total devengado no puede ser negativo.Por favor, ingrese un valor válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada inválida. Por favor, ingrese un valor numérico válido para el total devengado.");
                }
            }

            // Cálculo del salario semanal
            decimal salarioSemanalCalculado = costoPorHora * cantidadHorasTrabajadas;

            // Mostrar los resultados
            Console.WriteLine("\n--- Resumen del Cálculo de Salario Semanal ---");
            Console.WriteLine($"Costo por hora trabajada: {costoPorHora}");
            Console.WriteLine($"Cantidad de horas trabajadas:{cantidadHorasTrabajadas} horas");
            Console.WriteLine($"Total devengado (ingresado): {totalDevengado}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"El salario semanal calculado es:{salarioSemanalCalculado}");
            Console.WriteLine("---------------------------------------------");

            // Opcional: Comparación simple del total devengado con el calculado
            if (totalDevengado != salarioSemanalCalculado)
            {
                Console.WriteLine("\nAdvertencia: El 'Total devengado'ingresado no coincide con el 'Salario semanal calculado'.");

                Console.WriteLine($"Diferencia: {(salarioSemanalCalculado - totalDevengado)}");
            }

            // Pausar la consola para que el usuario pueda ver la salida
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
