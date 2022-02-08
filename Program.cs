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
                        DoHistoria();
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENÚ");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        DoGeografia();
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENÚ");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        DoArt() ;
                        MissatgeSeguentPantalla("PREM UNA TECLA PER TORNAR AL MENU");
                        break;



        }
        public static void MostrarOpcions()
        {
            Console.WriteLine("---ESCULL EL TEMA PER RESPONDRE LES PREGUNTES---)
            Console.WriteLine("1- HISTORIA");
            Console.WriteLine("2- GEOGRAFIA");
            Console.WriteLine("3- ART");

        }
        public static void DoHistoria()
                              {}
                                 
    }
}
