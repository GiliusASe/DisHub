using System;

namespace DisHub
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
        
        //EXECUTA EL TEST DE LES PREGUNTES SOBRE QUÍMICA
        public static void DoQuimica(ConsoleKey Tecla)
        {
            string r1, r2, r3, r4, r5;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P1- QUANTS ELEMENTS HI HA A LA TAULA PERIÒDICA?");
            Console.WriteLine("1- 118");
            Console.WriteLine("2- 138");
            Console.WriteLine("3- 256");
            Console.WriteLine("4- Masses elements");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r1 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P2- Quin és el nombre d'Avogadro?");
            Console.WriteLine("1- 5.023 x 10^23");
            Console.WriteLine("2- 6.203 x 10^23");
            Console.WriteLine("3- 6.023 x 10^23");
            Console.WriteLine("4- 972.20.94.58");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r2 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P3- QUINS SON ELS ELEMENTS MÉS COMUNS A LA QUIMICA ORGANICA?");
            Console.WriteLine("1- CARBONI I HIDROGEN");
            Console.WriteLine("2- AIGUA I OLI");
            Console.WriteLine("3- SOFRE I NITROGEN");
            Console.WriteLine("4- URANI I PLUTONI");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r3 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P4- QUANTS ESTATS DE LA MATÈRIA EXISTEIXEN?");
            Console.WriteLine("1- 2");
            Console.WriteLine("2- 3");
            Console.WriteLine("3- INFINITS");
            Console.WriteLine("4- 4");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r4 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P5- COM S'ANOMENA EL PROCÉS DE PASSAR D'ESTAT SÒLID A GAS DIRECTAMENT?");
            Console.WriteLine("1- SUMIMACIÓ");
            Console.WriteLine("2- SUMIMACIÓ INVERSA");
            Console.WriteLine("3- SUBLIMACIÓ INVERSA");
            Console.WriteLine("4- SUBLIMACIÓ");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r5 = Console.ReadLine();
        }
        //ACCIÓ QUE EXECUTA EL TEST RELACIONAT AMB BIOLOGIA
        public static void DoBiologia(ConsoleKey Tecla)
        {
            string r1, r2, r3, r4, r5;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P1- QUANTS CROMOSOMES TÉ UN SER HUMÀ");
            Console.WriteLine("1- 23");
            Console.WriteLine("2- 46");
            Console.WriteLine("3- 12");
            Console.WriteLine("4- MES QUE TU");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r1 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P2- APROXIMADAMENT, CADA QUAN ES RENOVA EL SISTEMA INMUNOLÒGIC?");
            Console.WriteLine("1- 9 ANYS");
            Console.WriteLine("2- 18 ANYS");
            Console.WriteLine("3- 3 DIES");
            Console.WriteLine("4- CADA LLUNA PLENA");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r2 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P3- QUINS SON ELS DOS GRANS TIPUS DE CÈL·LULES?");
            Console.WriteLine("1- EUCARIOTES I POCAHONTAS");
            Console.WriteLine("2- EUCLIDES I POKEMON");
            Console.WriteLine("3- EUCARIOTES I PROCARIOTES");
            Console.WriteLine("4- LES DEL BARÇA I DEL MADRID");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r3 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P4- QUE SIGNIFICA ADN?");
            Console.WriteLine("1- ACID DESINFECTA NUCLIS");
            Console.WriteLine("2- ACCIDENT DESASTROSAMENT NOCIU");
            Console.WriteLine("3- ACCENT DEL NORD");
            Console.WriteLine("4- ACID DESOXIRIBO-NUCLEIC");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r4 = Console.ReadLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("P5- QUE ES LA HOMEOSTASIS?");
            Console.WriteLine("1- ESTAT D'EQUILIBRI ENTRE MASSA CORPORAL I ALTURA");
            Console.WriteLine("2- ESTAT DE BENESTAR PRODUIT PER VEURE EL BETIS GUANYAR");
            Console.WriteLine("3- ESTAT D'EQUILIBRI I ESTABILITAT INTERN");
            Console.WriteLine("4- ESTAT DE FELICITAT PRODUIT PER UN CAP DE SETMANA SENSE PRÀCTIQUES I UNA BOSSA DE CHETTOS");
            Console.WriteLine(" ");
            Console.Write("RESPOSTA: ");
            r5 = Console.ReadLine();
        }

}
