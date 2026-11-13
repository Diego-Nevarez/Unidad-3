using Proyecto1_Clinica;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Proyecto1_Clinica
{
    internal class Cola
    {
        private Nodo Frente;
        private Nodo final;
        public Cola()
        {
            Frente = null;
            final = null;

        }
        public void Encolar(Paciente paciente)
        {
            Nodo nuevo = new Nodo(paciente);
            if (Frente == null)
            {
                Frente = nuevo;
                final = nuevo;

            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }
        public Paciente Desencolar(); {

        
        if (Frente == null)
            return null;
            return Paciente;
}
    public void Mostrar()
        {
            if (frente == null)
        }
        Console.WriteLine("No hay pacientes registrados");
        return;
        }
Nodo aux = frente;
while (aux != null) {

    Console.WriteLine(aux.Datos);
    aux = (aux.Siguiente);
}



