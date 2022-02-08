using System;

namespace DisHub
{
    class Program
    {
        // EN el main hi hauria un menu pero al fusionar les diferents accions s'adaptaran al menu del main de la branca master
        static void Main(string[] args)
        {
            
        }
        
        // Accio que fa preguntes sobre informatica
        public static void DoInformatica()
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5;
            Console.WriteLine("Qina es la part fisica d'una computadora ?");
            resposta1 = Console.ReadLine();
            Console.WriteLine("Quina es la part logica d'una computadora ?");
            resposta2 = Console.ReadLine();
            Console.WriteLine("Que volen dir les sigles de RAM ?");
            resposta3 = Console.ReadLine();
            Console.WriteLine("Que indica la mascara de xarxa ?");
            resposta4 = Console.ReadLine();
            Console.WriteLine("Com funciona el subneting ?");
            resposta5 = Console.ReadLine();
            DoClear();
        }
        
        
        // Accio que fa preguntes sobre automovils
        public static void DoAutomovils()
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5;
            Console.WriteLine("Quina es la teva marca preferida ?");
            resposta1 = Console.ReadLine();
            Console.WriteLine("Qin es el teu cotxe preferit ?");
            resposta2 = Console.ReadLine();
            Console.WriteLine("Que has de fer si veus un semafor en groc ?");
            resposta3 = Console.ReadLine();
            Console.WriteLine("En una autopista a quina velocitat has d'anar ?");
            resposta4 = Console.ReadLine();
            Console.WriteLine("En un encreuament tu giraras a l'esquerra mentre que el cotxe parat devant teu seguira recte, per on hos creuareu ?");
            resposta5 = Console.ReadLine();
            DoClear();

        }
    }
}
