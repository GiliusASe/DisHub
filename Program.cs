using System;

namespace DisHub
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                //limpia la pantalla per a que els altres menus no es quedin a sobre
                MostrarOpcions();
                tecla = Console.ReadKey();
                switch (tecla.Key)
                //la propietat key es un enum que pot valer tota la llista tant de teclats estandard com teclats especials
                {
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        //en cas de pulsar el digit 0 o numpad 0
                        MissatgeSeguentPantalla("ESTAS SEGUR QUE VOLS SORTIR? 0 PER CONFIRMAR");
                        break;
                    //break es per acabar la comanda del case
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        DoAnyTraspas();
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENÚ");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        DoMCD();
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENÚ");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        DoMCM() ;
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENU");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        DoValidarData();
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENU");
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        DoNumeroPrimer();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        MostrarOpcions2();
                        break;
        }
        public static void MostrarOpcions()
        {
            Console.WriteLine("1- ANY DE TRASPAS");
            Console.WriteLine("2- CALCULAR MCD");
            Console.WriteLine("3- CALCULAR MCM");
            Console.WriteLine("4- VALIDAR DATA");
            Console.WriteLine("5- SABER SI # ES PRIMER")
            Console.WriteLine("0- EXIT");
        }
        public static void MostrarOpcions2()
        {
            Console.WriteLine("1- ANY DE TRASPAS");
            Console.WriteLine("2- CALCULAR MCD");
            Console.WriteLine("3- CALCULAR MCM");
            Console.WriteLine("4- VALIDAR DATA");
            Console.WriteLine("5- SABER SI # ES PRIMER")
            Console.WriteLine("0- EXIT");
        }
        public static void MostrarOpcions3()
        {
            Console.WriteLine("1- ANY DE TRASPAS");
            Console.WriteLine("2- CALCULAR MCD");
            Console.WriteLine("3- CALCULAR MCM");
            Console.WriteLine("4- VALIDAR DATA");
            Console.WriteLine("5- SABER SI # ES PRIMER")
            Console.WriteLine("0- EXIT");
        }
    }
}
