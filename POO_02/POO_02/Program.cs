using System;
using POO_02.Entidades.System;

namespace POO_02 {
    /// <summary>
    /// Usar StringBuilder;
    /// </summary>
    class Program {
        static void Main(string[] args) {
            Comment c1 = new Comment("Tenha uma boa viagem! ");
            Comment c2 = new Comment("Wow isso é muito bom!! ");
            Post p1 = new Post(
                DateTime.Parse("21/06/218 13:05:10"),
                "Viagem para nova Zelandia",
                "Estou indo para visitar esse maravilhoso país",
                12

                );
            p1.AddComentario(c1);
            p1.AddComentario(c2);
            Comment c3 = new Comment("Tenha uma boa viagem! ");
            Comment c4 = new Comment("Wow isso é muito bom!! ");
            Post p2 = new Post(
                DateTime.Parse("20/07/218 18:45:10"),
                "Boa noite Galera",
                "Vejo Vocês amanhã",
                5);
            p2.AddComentario(c3);//associacao dos comentários com post.
            p2.AddComentario(c4);
            // impirmir na tela
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadKey();

        }
    }
}
