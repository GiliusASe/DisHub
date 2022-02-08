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
    }
}
