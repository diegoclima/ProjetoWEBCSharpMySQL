using System;
using System.Collections.Generic;
using System.Text;

namespace POO_02.Entidades.System {
    class Post {
        

        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        // associacao de post com varios comentários. Post tem muitos comentários. Na classe post
        // declarar uma lista de comentários.
        public List<Comment> Comentarios { get; set; } = new List<Comment>(); // garante que seja iniciada

        public Post(DateTime dateTime, string titulo, string content, int likes) {
            this.Momento = dateTime;
            Titulo = titulo;
            Content = content;
            Likes = likes;
        }

        public void AddComentario(Comment comentario) {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comment comentario) {
            Comentarios.Remove(comentario);
        }
        /// <summary>
        /// Usando o StringBuilder responsavel por montar uma string de forma eficiente
        /// pega o resultado em forma de string
        /// </summary>
        /// <returns></returns>
        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            //sb.Append - adiciona no inicio
            //sb.AppendLine - addiciona linha no final.
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comentários: ");
            // Para percorrer a lista, colocar como variavel o item passado como parametro 
            // na lista, nesse caso Comment;
            foreach (Comment item in Comentarios) {
                sb.AppendLine(item.Texto);
            }
            return sb.ToString();
        }

    }
}
