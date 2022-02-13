using System;

namespace DisHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEMES:FISICA,QUIMICA,BIOLOGIA
        }
        //EXECUTA EL TEST DE PREGUNTES SOBRE FISICA
        public static void DoFisica(ConsoleKey Tecla)
        {
            string r1, r2, r3, r4, r5;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P1- QUINA ÉS LA VELOCITAT DE LA LLUM?");
            Console.WriteLine("1- 300.000 KM/S");
            Console.WriteLine("2- 300.000 M/S");
            Console.WriteLine("3- 152.243 BAGUETTE/S");
            Console.WriteLine("4- 300 M/S");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r1 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P2- QUE PESA MÉS, 1 TONA DE PLOMES O 1 TONA D'ACER?");
            Console.WriteLine("1- LES PLOMES");
            Console.WriteLine("2- L'ACER");
            Console.WriteLine("3- PESEN IGUAL");
            Console.WriteLine("4- VISCA EL BETIS");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r2 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P3- QUANTES LLEIS VA REDACTAR ISAAC NEWTON?");
            Console.WriteLine("1- 10");
            Console.WriteLine("2- 24");
            Console.WriteLine("3- 4");
            Console.WriteLine("4- 3");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r3 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P4- SI ESTANT DINS D'UN TREN QUE VIATJA A LA VELOCITAT DE LA LLUM, LLENÇO UNA UNA PILOTA, QUE PASSARA?");
            Console.WriteLine("1- LA PILOTA SUPERARÀ LA VEL. DE LA LLUM");
            Console.WriteLine("2- LA PILOTA VIATJARÀ A LA VEL. DE LA LLUM");
            Console.WriteLine("3- LA PILOTA EXPLOTARÀ");
            Console.WriteLine("4- LA PILOTA ES FARÀ FAN DEL BETIS");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r4 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P5- SI ES LLENÇA UNA MONEDA DES DE L'EDIFICI MÉS ALT DEL MÓN, POT MATAR A UNA PERSONA SI LI CAU A SOBRE?");
            Console.WriteLine("1-SI, DEGUT A QUE LA FORÇA CINÈTICA QUE ACUMULA ÉS SUFICIENT COM PER PERFORAR EL CRANI HUMÀ");
            Console.WriteLine("2-SI, DEGUT A QUE LA MONEDA FARÀ COM SI FOS UNA BALA PERÒ PROPULSADA PER LA GRAVETAT");
            Console.WriteLine("3-NO, LA FRICCIÓ AMB L'AIRE FRENARÀ LA MONEDA FINS A UN PUNT EN EL QUAL NO ÉS CAPAÇ DE PERFORAR UN CAP");
            Console.WriteLine("4-NO, JA QUE LA AERODINÀMICA DE LA MONEDA FARÀ QUE GIRI MASSA RÀPID I ES DESVÏI DE LA PERSONA");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r5 = Console.ReadLine();
        }
}
