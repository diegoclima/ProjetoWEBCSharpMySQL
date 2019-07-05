using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grafo_02 {
    class Program {
        public static Vertice [] array;
        public static void LerArquivos(String nomeArq) {
            StreamReader arq = new StreamReader(nomeArq);
            string aux = arq.ReadLine();
            string[] dados;
            int tamVertice;
            int cont = 0;
            bool read = true;
            while (aux != null) {
                dados = aux.Split(';');

                tamVertice = int.Parse(dados[0]);

                if (read) {
                    array = new Vertice[tamVertice];
                    
                    read = false;
                } else {
                    int aux1 = VerificaAdjacente(int.Parse(dados[0]));
                    if (aux1 == -1) {
                        Vertice v = new Vertice(int.Parse(dados[0]));
                        v.Vertices.Add(new Vertice(int.Parse(dados[1])));
                        aux1 = VerificaAdjacente(int.Parse(dados[1]));
                        if (aux1 == -1) {
                            v = new Vertice(int.Parse(dados[1]));
                            v.Vertices.Add(new Vertice(int.Parse(dados[0])));
                        } else {
                            array[aux1].Vertices.Add(new Vertice(int.Parse(dados[0])));
                        }
                       array[cont] = v;
                        cont++;
                    } else {
                        array[aux1].Vertices.Add(new Vertice(int.Parse(dados[1])));
                      
                    }

                }
            }
        }

        public static int VerificaAdjacente(int pos) {
            for (int i = 0; i < array.Length; i++) {
                if (pos==array[i].Id_vertice) {
                    return pos;
                } 
            }
            return -1;
        }
        static void Main(string[] args) {

            LerArquivos("dados.txt");
            for (int i = 0; i < Program.array.Length; i++) {
                Console.WriteLine(array[i].Id_vertice);
                foreach (var item in array[i].Vertices) {
                    Console.WriteLine(item.Id_vertice);
                }
            }
            Console.ReadKey();            

        }
    }
}
