using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class MaquinaVerificacion : Maquina
    {
        public int memoriaVerificacion = 0;

        public override void Encendido()
        {
            Console.WriteLine("Encendido de maquina de Verificacion");
        }

        public override void Reinicio()
        {
            Console.WriteLine("Memoria de Verificacion llena");

            Console.WriteLine("Reinicio de maquina de Verificacion");

            memoriaVerificacion = 0;
        }

        public override void Apagado()
        {
            Console.WriteLine("Apagado de maquina de Verificacion");
        }

        public override void ReinicioManual()
        {
            memoriaVerificacion = 0;

            Console.WriteLine("Memoria Verificacion reiniciada");
        }
    }
}
