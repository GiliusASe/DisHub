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

        
        public static void DoHistoria1()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("A QUIN ANY VA ARRIBAR LA HUMANITAT A LA LLUNA?");
            Console.WriteLine("1 - 1969");
            Console.WriteLine("2 - 1824");
            Console.WriteLine("3 - 1999");
            Console.WriteLine("4 - 2004");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoHistoria2();
                    break;
                case ConsoleKey.D2:

                    DoHistoria2();
                    break;
                case ConsoleKey.D3:
                    DoHistoria2();
                    break;
                case ConsoleKey.D4:
                    DoHistoria2();
                    break;
            }

        }
        public static void DoHistoria2()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("DE QUINA NACIONALITAT ERA JUANA D'ARC?");
            Console.WriteLine("1 - ANGLESA");
            Console.WriteLine("2 - FRANCESA");
            Console.WriteLine("3 - ESPANYOLA");
            Console.WriteLine("4 - ITALIANA");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoHistoria3();
                    break;
                case ConsoleKey.D2:

                    DoHistoria3();
                    break;
                case ConsoleKey.D3:
                    DoHistoria3();
                    break;
                case ConsoleKey.D4:
                    DoHistoria3();
                    break;
            }
        }
        public static void DoHistoria3()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("A QUIN ANY VA COMENÇAR LA SEGONA GUERRA MUNDIAL?");
            Console.WriteLine("1 - 1939");
            Console.WriteLine("2 - 1912");
            Console.WriteLine("3 - 1898");
            Console.WriteLine("4 - 2005");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoHistoria4();
                    break;
                case ConsoleKey.D2:

                    DoHistoria4();
                    break;
                case ConsoleKey.D3:
                    DoHistoria4();
                    break;
                case ConsoleKey.D4:
                    DoHistoria4();
                    break;
            }
        }
        public static void DoHistoria4()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("QUI VA SER L'ÙLTIM TZAR RUS");
            Console.WriteLine("1 - NIKOLAI II");
            Console.WriteLine("2 - PERE I EL GRAN");
            Console.WriteLine("3 - ALEXANDER II");
            Console.WriteLine("4 - JOSEPH STALIN I");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoHistoria5();
                    break;
                case ConsoleKey.D2:

                    DoHistoria5();
                    break;
                case ConsoleKey.D3:
                    DoHistoria5();
                    break;
                case ConsoleKey.D4:
                    DoHistoria5();
                    break;
            }
        }
        public static void DoHistoria5()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("DE QUINA NACIONALITAT ERA JUANA D'ARC?");
            Console.WriteLine("1 - ANGLESA");
            Console.WriteLine("2 - FRANCESA");
            Console.WriteLine("3 - ESPANYOLA");
            Console.WriteLine("4 - ITALIANA");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D2:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D3:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D4:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;
            }
        }
        public static void DoGeografia1()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("QUIN D'AQUESTS RIUS NO PERTANY A ESPANYA?");
            Console.WriteLine("1 - NIL");
            Console.WriteLine("2 - EBRE");
            Console.WriteLine("3 - GUADALQUIVIR");
            Console.WriteLine("4 - ONYAR");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoGeografia2();
                    break;

                case ConsoleKey.D2:
                    DoGeografia2();
                    break;

                case ConsoleKey.D3:
                    DoGeografia2();
                    break;

                case ConsoleKey.D4:
                    DoGeografia2();
                    break;
            }
        }
        public static void DoGeografia2()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("COM ES DIU EL DESERT QUE HI HA A MÉXIC");
            Console.WriteLine("1 - SAHARA");
            Console.WriteLine("2 - SONORA");
            Console.WriteLine("3 - MURCIA");
            Console.WriteLine("4 - MOJAVE");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoGeografia3();
                    break;

                case ConsoleKey.D2:
                    DoGeografia3();
                    break;

                case ConsoleKey.D3:
                    DoGeografia3();
                    break;

                case ConsoleKey.D4:
                    DoGeografia3();
                    break;
            }
        }
        public static void DoGeografia3()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("QUIN ES L'ESTAT MÉS GRAN D'ESTATS UNITS");
            Console.WriteLine("1 - TEXAS");
            Console.WriteLine("2 - CALIFORNIA");
            Console.WriteLine("3 - GIRONA");
            Console.WriteLine("4 - ALASKA");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoGeografia4();
                    break;

                case ConsoleKey.D2:
                    DoGeografia4();
                    break;

                case ConsoleKey.D3:
                    DoGeografia4();
                    break;

                case ConsoleKey.D4:
                    DoGeografia4();
                    break;
            }
        }
        public static void DoGeografia4()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("ON ES TROBA TUMBUCTÚ");
            Console.WriteLine("1 - AFRICA");
            Console.WriteLine("2 - ASIA");
            Console.WriteLine("3 - AMERICA DEL SUD");
            Console.WriteLine("4 - EUROPA");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoGeografia5();
                    break;

                case ConsoleKey.D2:
                    DoGeografia5();
                    break;

                case ConsoleKey.D3:
                    DoGeografia5();
                    break;

                case ConsoleKey.D4:
                    DoGeografia5();
                    break;
            }
        }
        public static void DoGeografia5()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("DE QUIN PAIS ES CRACKOVIA");
            Console.WriteLine("1 - RUSIA");
            Console.WriteLine("2 - POLONIA");
            Console.WriteLine("3 - ALEMANYA");
            Console.WriteLine("4 - UCRANIA");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D2:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D3:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D4:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;
            }
        }
        public static void DoArt1()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("QUI VA PINTAR LA MONA LISA?");
            Console.WriteLine("1 - Leonardo da Vinci");
            Console.WriteLine("2 - Napoleon Bonaparte");
            Console.WriteLine("3 - Salvador Dalí");
            Console.WriteLine("4 - Pablo Picasso");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoArt2();
                    break;

                case ConsoleKey.D2:
                    DoArt2();
                    break;

                case ConsoleKey.D3:
                    DoArt2();
                    break;

                case ConsoleKey.D4:
                    DoArt2();
                    break;
            }
        }
        public static void DoArt2()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("A QUIN ANY L'ART VA PROVOCAR UN CONFLICTE INTERNACIONAL?");
            Console.WriteLine("1 - 1911");
            Console.WriteLine("2 - 1054");
            Console.WriteLine("3 - 1492");
            Console.WriteLine("4 - 1939");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoArt3();
                    break;

                case ConsoleKey.D2:
                    DoArt3();
                    break;

                case ConsoleKey.D3:
                    DoArt3();
                    break;

                case ConsoleKey.D4:
                    DoArt3();
                    break;
            }
        }
        public static void DoArt3()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("QUANTES PINTURES, OFICIALMENT, VA FIRMAR I ACABAR LEONARDO DA VINCI?");
            Console.WriteLine("1 - 15");
            Console.WriteLine("2 - 1");
            Console.WriteLine("3 - 8");
            Console.WriteLine("4 - Cap");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoArt4();
                    break;

                case ConsoleKey.D2:
                    DoArt4();
                    break;

                case ConsoleKey.D3:
                    DoArt4();
                    break;

                case ConsoleKey.D4:
                    DoArt4();
                    break;
            }
        }
        public static void DoArt4()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("EN QUINA CIUTAT ES VA INSPIRAR VAN GOGH PER FER EL SEU FAMOS QUADRE 'CIUTAT PLASMADA'?");
            Console.WriteLine("1 - Sant remy de Provence");
            Console.WriteLine("2 - Paris");
            Console.WriteLine("3 - Londres");
            Console.WriteLine("4 - Salamanca");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoArt5();
                    break;

                case ConsoleKey.D2:
                    DoArt5();
                    break;

                case ConsoleKey.D3:
                    DoArt5();
                    break;

                case ConsoleKey.D4:
                    DoArt5();
                    break;
            }
        }
        public static void DoArt5()
        {
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey();

            Console.WriteLine("QUI VA PINTAR EL CUADRE 'LAS MENINAS'");
            Console.WriteLine("1 - VINCENT VAN GOGH");
            Console.WriteLine("2 - PABLO PICASSO");
            Console.WriteLine("3 - VELAZQUEZ");
            Console.WriteLine("4 - GOYA");
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D2:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D3:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;

                case ConsoleKey.D4:
                    MissatgeSeguentPantalla("PREMEU QUALSEVOL TECLA PER TORNAR AL MENU");
                    break;
            }
        }

        public static void DoMenu()
        

            } while (tecla.Key != ConsoleKey.D0);
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
        //EXECUTA EL TEST DE PREGUNTES SOBRE FISICA


        

}
