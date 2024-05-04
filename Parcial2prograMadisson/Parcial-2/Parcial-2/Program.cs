using System;
using System.Collections.Generic;
using System.IO;

namespace Parcial_2
{
    internal class Program
    {
        static List<Empleado> empleados = new List<Empleado>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n1. Agregar empleado");
                Console.WriteLine("2. Listar empleados");
                Console.WriteLine("3. Calcular salario total");
                Console.WriteLine("4. Guardar datos");
                Console.WriteLine("5. Cargar datos");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;
                    case "2":
                        ListarEmpleados();
                        break;
                    case "3":
                        CalcularSalarioTotal();
                        break;
                    case "4":
                        GuardarDatos();
                        break;
                    case "5":
                        CargarDatos();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        static void AgregarEmpleado()
        {
            Console.WriteLine("\nAgregar empleado:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Tipo de empleado (1: Tiempo Completo, 2: Por Horas): ");
            string tipoEmpleado = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (tipoEmpleado == "1")
            {
                empleados.Add(new EmpleadoTiempoCompleto(nombre, salario));
            }
            else if (tipoEmpleado == "2")
            {
                Console.Write("Horas trabajadas: ");
                int horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salario por hora: ");
                double salarioPorHora = Convert.ToDouble(Console.ReadLine());
                empleados.Add(new EmpleadoPorHoras(nombre, salarioPorHora, horasTrabajadas));
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido.");
            }
        }

        static void ListarEmpleados()
        {
            Console.WriteLine("\nLista de empleados:");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }

        static void CalcularSalarioTotal()
        {
            double salarioTotal = 0;
            foreach (var empleado in empleados)
            {
                salarioTotal += empleado.CalcularSalario();
            }
            Console.WriteLine($"\nSalario total pagado a todos los empleados: {salarioTotal:C}");
        }

        static void GuardarDatos()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("empleados.txt"))
                {
                    foreach (var empleado in empleados)
                    {
                        if (empleado is EmpleadoPorHoras)
                        {
                            EmpleadoPorHoras empleadoPorHoras = (EmpleadoPorHoras)empleado;
                            sw.WriteLine("EmpleadoPorHoras");
                            sw.WriteLine(empleadoPorHoras.Nombre);
                            sw.WriteLine(empleadoPorHoras.Salario);
                            sw.WriteLine(empleadoPorHoras.HorasTrabajadas);
                            sw.WriteLine(empleadoPorHoras.SalarioPorHora);
                        }
                        else if (empleado is EmpleadoTiempoCompleto)
                        {
                            EmpleadoTiempoCompleto empleadoTiempoCompleto = (EmpleadoTiempoCompleto)empleado;
                            sw.WriteLine("EmpleadoTiempoCompleto");
                            sw.WriteLine(empleadoTiempoCompleto.Nombre);
                            sw.WriteLine(empleadoTiempoCompleto.Salario);
                        }
                    }
                }
                Console.WriteLine("\nDatos guardados en empleados.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError al guardar datos: " + ex.Message);
            }
        }

        static void CargarDatos()
        {
            empleados.Clear(); 
            try
            {
                using (StreamReader sr = new StreamReader("empleados.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string tipoEmpleado = line;
                        string nombre = sr.ReadLine();
                        double salario = Convert.ToDouble(sr.ReadLine());
                        if (tipoEmpleado == "EmpleadoPorHoras")
                        {
                            int horasTrabajadas = Convert.ToInt32(sr.ReadLine());
                            double salarioPorHora = Convert.ToDouble(sr.ReadLine());
                            empleados.Add(new EmpleadoPorHoras(nombre, salarioPorHora, horasTrabajadas));
                        }
                        else if (tipoEmpleado == "EmpleadoTiempoCompleto")
                        {
                            empleados.Add(new EmpleadoTiempoCompleto(nombre, salario));
                        }
                    }
                }
                Console.WriteLine("\nDatos cargados correctamente.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("\nEl archivo de datos no existe.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError al cargar datos: " + ex.Message);
            }
        }
    }

    
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public abstract double CalcularSalario();

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Salario: {Salario:C}";
        }
    }

   
    class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, double salario) : base(nombre, salario)
        {
        }

        public override double CalcularSalario()
        {
            return Salario;
        }
    }

  
    class EmpleadoPorHoras : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double SalarioPorHora { get; set; }

        public EmpleadoPorHoras(string nombre, double salarioPorHora, int horasTrabajadas) : base(nombre, 0)
        {
            SalarioPorHora = salarioPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularSalario()
        {
            return SalarioPorHora * HorasTrabajadas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Horas trabajadas: {HorasTrabajadas}, Salario por hora: {SalarioPorHora:C}";
        }
    }
}
