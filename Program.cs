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
        
        // Accio que fa preguntes sobre informatica
         public static void DoInformatica()
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5;
            Console.WriteLine("Qina es la part fisica d'una computadora ?");
            Console.WriteLine("A) Hardware");
            Console.WriteLine("B) Software");
            Console.WriteLine("C) El betis");
            Console.WriteLine("D) L'ordinador");
            resposta1 = Console.ReadLine();
            if (resposta1 == "A") Console.WriteLine("Correcte");

            Console.WriteLine("Quina es la part logica d'una computadora ?");
            Console.WriteLine("A) Hardware");
            Console.WriteLine("B) Software");
            Console.WriteLine("C) El betis");
            Console.WriteLine("D) L'ordinador");
            resposta2 = Console.ReadLine();
            if (resposta2 == "B") Console.WriteLine("Correcte");
            Console.WriteLine("Que volen dir les sigles de RAM ?");
            Console.WriteLine("A) Reunion de Alcholicos Moteros");
            Console.WriteLine("B) Read Acces Memory");
            Console.WriteLine("C) Random Acces Memory");
            Console.WriteLine("D) Ni ver** no se ingles");
            resposta3 = Console.ReadLine();
            if (resposta3 == "C") Console.WriteLine("Correcte");
            Console.WriteLine("Que indica la mascara de xarxa ?");
            Console.WriteLine("A) Quina part de la IP pertany a xarxa i quina al numero identificatiu de l'ordinador en aquesta");
            Console.WriteLine("B) Read Only Memory");
            Console.WriteLine("C) si has anat a caminar");
            Console.WriteLine("D) que es carnaval");
            resposta4 = Console.ReadLine();
            if (resposta4 == "C") Console.WriteLine("Correcte");
            Console.WriteLine("Que es la ROM ?");
            Console.WriteLine("A) Beguda alcholica que bebien els pirates");
            Console.WriteLine("B) Read Only Memory");
            Console.WriteLine("C) Ritual informatic");
            Console.WriteLine("D) Es un protocol de xarxa");
            resposta5 = Console.ReadLine();
            if (resposta5 == "B") Console.WriteLine("Correcte");
            DoClear();
        }
        
        
        // Accio que fa preguntes sobre automovils
        public static void DoAutomovils()
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5;
            Console.WriteLine("Quina es la teva marca preferida ?");
            Console.WriteLine("A) Audi");
            Console.WriteLine("B) BMW");
            Console.WriteLine("C) Mercedes");
            Console.WriteLine("D) Altres");
            resposta1 = Console.ReadLine();
            if (resposta1 == "B" || resposta1 == "A" || resposta1 == "C" || resposta1 == "D") Console.WriteLine("Correcte");
            Console.WriteLine("Per on es condueix el cotxe ?");
            Console.WriteLine("A) Per la dreta de la via");
            Console.WriteLine("B) Per el centre de la via");
            Console.WriteLine("C) Per l'esquerra de la via");
            Console.WriteLine("D) Per fora de la via");
            resposta2 = Console.ReadLine();
            if (resposta2 == "A") Console.WriteLine("Correcte");
            Console.WriteLine("Que has de fer si veus un semafor en groc ?");
            Console.WriteLine("A) Accelerar");
            Console.WriteLine("B) Desaccelerar");
            Console.WriteLine("C) Parar en sec");
            Console.WriteLine("D) Que es un semafor?");
            resposta3 = Console.ReadLine();
            if (resposta3 == "B") Console.WriteLine("Correcte");
            Console.WriteLine("En una autopista a quina velocitat has d'anar ?");
            Console.WriteLine("A) La maxima possible");
            Console.WriteLine("B) 130");
            Console.WriteLine("C) 100");
            Console.WriteLine("D) 120");
            resposta3 = Console.ReadLine();
            if (resposta3 == "D") Console.WriteLine("Correcte");
            Console.WriteLine("En un encreuament tu giraras a l'esquerra mentre que el cotxe parat devant teu seguira recte, per on hos creuareu ?");
            Console.WriteLine("A) Per devant");
            Console.WriteLine("B) Per derrere");
            Console.WriteLine("C) No ens creurarem");
            Console.WriteLine("D) cap de les anterirors");
            resposta3 = Console.ReadLine();
            if (resposta3 == "B") Console.WriteLine("Correcte");
            DoClear();

        }
        
        
        // Accio que fa preguntes matemàtiques
        public static void DoMatematiques()
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5;
            Console.WriteLine("Si tinc 3 pomes i hem menjo 2,5 quantes pomes tinc ?");
            Console.WriteLine("A) 0'5");
            Console.WriteLine("B) 1");
            Console.WriteLine("C) 2");
            Console.WriteLine("D) 8");
            resposta1 = Console.ReadLine();
            if (resposta1 == "A") Console.WriteLine("Correcte");
            Console.WriteLine("Si en pep li costa produir llet 50€ el litre i la ven per 75€ el litre quin benefici tindra ?");
            Console.WriteLine("A) 20€");
            Console.WriteLine("B) 30€");
            Console.WriteLine("C) 25€");
            Console.WriteLine("D) 0€");
            resposta2 = Console.ReadLine();
            if (resposta2 == "C") Console.WriteLine("Correcte");
            Console.WriteLine("si tinc 6 amics i 6 galete quantes galetes pertoquen a cadaescu ?");
            Console.WriteLine("A) 1");
            Console.WriteLine("B) 2");
            Console.WriteLine("C) 0");
            Console.WriteLine("D) 9");
            resposta3 = Console.ReadLine();
            if (resposta3 == "A") Console.WriteLine("Correcte");
            Console.WriteLine("si 1 + 1 es 2 calcula 8*90  ?");
            Console.WriteLine("A) 700");
            Console.WriteLine("B) 420");
            Console.WriteLine("C) 1060");
            Console.WriteLine("D) 720");
            resposta4 = Console.ReadLine();
            if (resposta4 == "A") Console.WriteLine("Correcte");
            Console.WriteLine("Es sabuda la solucio de  P = NP ");
            Console.WriteLine("A) Si");
            Console.WriteLine("B) No");
            Console.WriteLine("C) La conec");
            Console.WriteLine("D) Cap de les anteriors");
            resposta4 = Console.ReadLine();
            if (resposta4 == "B") Console.WriteLine("Correcte");
            DoClear();

        }
    }
}
