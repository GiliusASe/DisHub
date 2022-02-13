using System;

namespace DisHub
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMusica();
            DoAnime();
            DoVideojocs();
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
    }
}
