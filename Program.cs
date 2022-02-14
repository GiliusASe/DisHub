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
        
        public static void DoMusica()
        {
            char resposta;

            // Pregunta 1
            Console.WriteLine("Quin es el album mes venut de la Historia?");
            Console.WriteLine("A) Thriller");
            Console.WriteLine("B) Back in Black");
            Console.WriteLine("C) Bat out of Hell");
            Console.WriteLine("D) The Dark side of the Moon");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'A') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 2
            Console.WriteLine("Quin es la canço principal de la pelicula Armageddon");
            Console.WriteLine("A) I Don't Want to Miss a Thing");
            Console.WriteLine("B) Crazy");
            Console.WriteLine("C) Cryin'");
            Console.WriteLine("D) Amazing");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'A') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 3
            Console.WriteLine("Qui ha sigut el artista mes escoltat de Spotify 2021?");
            Console.WriteLine("A) Charlie Puth");
            Console.WriteLine("B) Bad Bunny");
            Console.WriteLine("C) Drake");
            Console.WriteLine("D) Ariana Grande");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'B') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 4
            Console.WriteLine("Qui va guanyar el premi al millor Artista dels premis MTV? ");
            Console.WriteLine("A) Doja Cat");
            Console.WriteLine("B) Lady Gaga");
            Console.WriteLine("C) Lil Nas X");
            Console.WriteLine("D) Ed Sheeran");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'D') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 5
            Console.WriteLine("Quin de aquests Grups o Artistes te un Disc d'Urani");
            Console.WriteLine("A) Queen");
            Console.WriteLine("B) Pink Floyd");
            Console.WriteLine("C) BTS");
            Console.WriteLine("D) Gun's and Roses");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'A') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();
        }
        
        public static void DoAnime()
        {
            char resposta;

            // Pregunta 1
            Console.WriteLine("Qui es el Protagonista de Kimetsu no Yaiba?");
            Console.WriteLine("A) Gonpanchiro Kamaboko");
            Console.WriteLine("B) Itadaki Tontaro");
            Console.WriteLine("C) Inosuke Hashibira");
            Console.WriteLine("D) Monjiro Masado");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'C') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 2
            Console.WriteLine("Quantes partes te JoJo's Bizzare Adventure");
            Console.WriteLine("A) 9");
            Console.WriteLine("B) 8");
            Console.WriteLine("C) 6");
            Console.WriteLine("D) 5");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'B') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 3
            Console.WriteLine("Quin estudi es el creador de la obra Koe no Katachi");
            Console.WriteLine("A) Clover Works");
            Console.WriteLine("B) MAPPA");
            Console.WriteLine("C) Ufotable");
            Console.WriteLine("D) Kyoto Animation");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'D') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 4
            Console.WriteLine("Quin instrument toca el personatge Tsumugi Kotobuki");
            Console.WriteLine("A) Teclat");
            Console.WriteLine("B) Guitarra");
            Console.WriteLine("C) Baix");
            Console.WriteLine("D) Bateria");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'A') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 5
            Console.WriteLine("Qui es el protagonista de principal de Haikyuu!!");
            Console.WriteLine("A) Hinata Shouyo");
            Console.WriteLine("B) Yuu Nishinoya");
            Console.WriteLine("C) Daichi Sawamura");
            Console.WriteLine("D) Cap es Correcta");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'A') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();
        }
        
         public static void DoVideojocs()
        {
            char resposta;

            // Pregunta 1
            Console.WriteLine("Quin va ser el últim lloc de treball que va ocupar Satoru Iwata a l'empresa Nintendo?");
            Console.WriteLine("A) President");
            Console.WriteLine("B) Desenvolupador de Pokemon");
            Console.WriteLine("C) Dissenyador Grafic");
            Console.WriteLine("D) Cap de les Anteriors");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'A') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            // Pregunta 2
            Console.WriteLine("Qui es el Director de la saga Dark Souls, Bloodborne, Sekiro Shadows Die Twice entre altres?");
            Console.WriteLine("A) Yoko Taro");
            Console.WriteLine("B) Tetsuya Nomura");
            Console.WriteLine("C) Hidetaka Miyazaki");
            Console.WriteLine("D) Hideaki Itsuno");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'C') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();
               
            /// Pregunta 3
            Console.WriteLine("Quina ha sigut la primer entrega de Pokemon aquest any (2020) ?");
            Console.WriteLine("A) Pokemon Negro ");
            Console.WriteLine("B) Pokemon Leyendas: Arceus");
            Console.WriteLine("C) Pokemon Mundo Misterioso 2");
            Console.WriteLine("D) Pokemon Leyendas: Rek'Sai");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'B') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            //Pregunta 4
            Console.WriteLine("Quina de aquestes empresas forma part de Tencent?");
            Console.WriteLine("A) Epic Games");
            Console.WriteLine("B) Blizzard");
            Console.WriteLine("C) Supercell");
            Console.WriteLine("D) Totes son correcres");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'D') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();

            //Pregunta 5
            Console.WriteLine("Quin joc va ser el GOTY de 2020?");
            Console.WriteLine("A) Deathloop");
            Console.WriteLine("B) Undertale");
            Console.WriteLine("C) Sekiro: Shadows Die Twice");
            Console.WriteLine("D) The last of us II");
            resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'D') Console.WriteLine("Resposa Correcta");
            else Console.WriteLine("Resposta Incorrecta");

            Console.WriteLine("CLIC ALGUNA TECLA PER PASSAR DE PREGUNTA");
            Console.ReadKey();
            Console.Clear();
           
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
