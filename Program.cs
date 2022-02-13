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
    }
}
