using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Proyecto1_Clinica
{
    internal class Menu
    {
        static Cola pacientes = new Cola();
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("=====CLINICA=====");
                Console.WriteLine("1. Registrar pacientes ");
                Console.WriteLine("2. Atender pacientes");
                Console.WriteLine("3. Mostrar pacientes");
                Console.WriteLine("0. Salir ");
                Console.WriteLine("Opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Registrar();
                        break;

                    case 2:
                        Atender();
                        break;

                    case 3:
                        pacientes.mostrar();
                        Console.ReadKey();
                        break;
                }

            } while (opcion!= 0);
    }
        static void Registrar() {
            Console.WriteLine("Expediente");
            int expediente = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre");
            int nombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("prioridad");
            int prioridad = int.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(expediente, nombre, edad, prioridad);

            pacientes.Encolar(paciente);

            Console.WriteLine("Expediente");
            Console.ReadKey();

            static void Atender()
            {
                Paciente paciente = pacientes.Desencolar();

                if (paciente == null )
                    Console.WriteLine("No hay pacientes");
                else

                    Console.WriteLine("Atendido");
                if (paciente != null) {

            }

        }
