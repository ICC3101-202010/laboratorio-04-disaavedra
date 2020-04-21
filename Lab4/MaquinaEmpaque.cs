using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class MaquinaEmpaque : Maquina
    {
        public int memoriaEmpaque = 0;

        public override void Encendido()
        {
            Console.WriteLine("Encendido de maquina de Empaque");
        }

        public override void Reinicio()
        {
            Console.WriteLine("Memoria de Empaque llena");

            Console.WriteLine("Reinicio de maquina de Empaque");

            memoriaEmpaque = 0;
        }

        public override void Apagado()
        {
            Console.WriteLine("Apagado de maquina de Empaque");
        }

        public override void ReinicioManual()
        {
            memoriaEmpaque = 0;

            Console.WriteLine("Memoria Empaque reiniciada");
        }
    }
}
