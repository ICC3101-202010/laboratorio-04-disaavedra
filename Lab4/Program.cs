using System;

namespace Lab4
{
    class Program
    {

        static void Main(string[] args)
        {
            ComputadorCentral central = new ComputadorCentral();

            String eleccion; 

            Console.WriteLine("Ejecutar:");

            Console.WriteLine("[1]Control Automatico");

            Console.WriteLine("[2]Control Manual");

            eleccion = Console.ReadLine();

            if (eleccion != "1" || eleccion != "2")
            {
                Console.WriteLine("No se puede ejecutar esa accion");
            }

            switch (eleccion)
            {
                case "1":

                    int hora = 7;

                    central.EncendidoMaquinas();

                    Console.WriteLine($"Inicio del dia a las {hora}:00");

                    central.ReinicioAutomatico();

                    while (true)
                    {
                        if (hora == 24)
                        {
                            Console.WriteLine("Fin de la jornada laboral 00:00am");

                            break;
                        }

                        Console.WriteLine($"\nHora {hora}:00");

                        central.ReinicioAutomatico();

                        hora++;
                    }

                    central.ApagadoMaquinas();

                    break;

                case "2":

                    int horaManual = 7;

                    String eleccionMaquina;

                    central.EncendidoMaquinas();

                    Console.WriteLine($"Inicio del dia a las {horaManual}:00");

                    while (true)
                    {
                        if (horaManual == 24)
                        {
                            Console.WriteLine("Fin de la jornada laboral 00:00am");                           

                            break;
                        }

                        Console.WriteLine($"\nHora {horaManual}:00");

                        central.MemoriaManual();

                        Console.WriteLine("Borror Memoria:");

                        Console.WriteLine("[1]Recepcion");

                        Console.WriteLine("[2]Almacenamiento");

                        Console.WriteLine("[3]Ensamblaje");

                        Console.WriteLine("[4]Verificacion");

                        Console.WriteLine("[5]Empaque");

                        Console.WriteLine("[6]Salir");

                        eleccionMaquina = Console.ReadLine();

                        switch (eleccionMaquina)
                        {
                            case "1":

                                central.ReinicioManualCentral(eleccionMaquina);

                                break;

                            case "2":

                                central.ReinicioManualCentral(eleccionMaquina);

                                break;

                            case "3":

                                central.ReinicioManualCentral(eleccionMaquina);

                                break;

                            case "4":

                                central.ReinicioManualCentral(eleccionMaquina);

                                break;

                            case "5":

                                central.ReinicioManualCentral(eleccionMaquina);

                                break;

                            case "6":

                                break;
                        }

                        horaManual++;
                    }

                    central.ApagadoMaquinas();

                    break;
            }        
        }
    }
}
