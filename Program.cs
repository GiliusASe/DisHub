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
        
        
        // Accio que fa preguntes matemàtiques
        public static void DoMatematiques()
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5;
            Console.WriteLine("Si tinc 3 pomes i hem menjo 2,5 quantes pomes tinc ?");
            resposta1 = Console.ReadLine();
            Console.WriteLine("Si en pep li costa produir llet 50€ el litre i la ven per 75€ el litre quin benefici tindra ?");
            resposta2 = Console.ReadLine();
            Console.WriteLine("si tinc 6 amics i 5 galete quantes galetes pertoquen a cadaescu ?");
            resposta3 = Console.ReadLine();
            Console.WriteLine("si 1 + 1 es 2 calcula quina es la massa del sol  ?");
            resposta4 = Console.ReadLine();
            Console.WriteLine("Resol P = NP ");
            resposta5 = Console.ReadLine();
            DoClear();

        }
    }
}
