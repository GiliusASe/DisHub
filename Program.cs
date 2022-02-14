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
                    case (ConsoleKey.D4):
                        Console.WriteLine("");
                        DoHistoria1();
                        DoHistoria2();
                        DoHistoria3();
                        DoHistoria4();
                        DoHistoria5();
                        break;
                    case (ConsoleKey.D5):
                        Console.WriteLine("");
                        DoGeografia1();
                        DoGeografia2();
                        DoGeografia3();
                        DoGeografia4();
                        DoGeografia5();
                        break;
                    case (ConsoleKey.D6):
                        Console.WriteLine("");
                        DoArt1();
                        DoArt2();
                        DoArt3();
                        DoArt4();
                        DoArt5();
                        break;
                    case (ConsoleKey.D7):
                        Console.WriteLine("");
                        DoMusica();
                        break;
                    case (ConsoleKey.D8):
                        Console.WriteLine("");
                        DoAnime();
                        break;
                    case (ConsoleKey.D9):
                        Console.WriteLine("");
                        DoVideojocs();
                        break;
                    case (ConsoleKey.F):
                        Console.WriteLine("");
                        DoFisica();
                        break;
                    case (ConsoleKey.Q):
                        Console.WriteLine("");
                        DoQuimica();
                        break;
                    case (ConsoleKey.B):
                        Console.WriteLine("");
                        DoBiologia();
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
            Console.Writeline("4- Test d'història");
            Console.Writeline("5- Test de geografia");
            Console.Writeline("6- Test d'art");
            Console.Writeline("7- Musica");
            Console.Writeline("8- Anime");
            Console.Writeline("9- Videojocs");
            Console.Writeline("F- Fisica");
            Console.Writeline("Q- Quimica");
            Console.Writeline("B- Biologia");
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
        
            public static void MissatgeSeguentPantalla(String elMissatge)
       
            {
            Console.WriteLine(elMissatge);
            Console.ReadKey();
            //Mostra un missatge personalitzat i obliga a pulsar una tecla
            }
        }
    }
}
