using System;

namespace DisHub
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                DoMenu();
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.D0:
                        Console.WriteLine("");
                        Console.WriteLine("Finalitzacio del programa");
                        break;
                    case (ConsoleKey.D1):
                        Console.WriteLine("");
                        DoInformatica();
                        break;
                    case (ConsoleKey.D2):
                        Console.WriteLine("");
                        DoAutomovils();
                        break;
                    case (ConsoleKey.D3):
                        Console.WriteLine("");
                        DoMatematiques();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Inserta una tecla valida");
                        break;

                }

            } while (tecla.Key != ConsoleKey.D0);
        }




        public static void DoMenu()
        {
            Console.WriteLine("Sobre quin tema li agradaria que li fessim preguntes ?");
            Console.WriteLine("0- Sortir del programa");
            Console.WriteLine("1- Informatica");
            Console.WriteLine("2- Automovils");
            Console.WriteLine("3- Problemes matemàtics");
        }

        public static void DoClear()
        {
            ConsoleKeyInfo tecla;
            Console.WriteLine("1- tornar al menu");
            Console.WriteLine("0- sortir del programa");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D0)
            {
                System.Environment.Exit(1);
            }
            else if (tecla.Key == ConsoleKey.D1)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Error, tecla no acceptada, torna a introduir una tecla valida");
                DoClear();
            }
        public static void MostrarOpcions()
        {
            Console.WriteLine("---ESCULL EL TEMA PER RESPONDRE LES PREGUNTES---)
            Console.WriteLine("1- HISTORIA");
            Console.WriteLine("2- GEOGRAFIA");
            Console.WriteLine("3- ART");
    }
}
