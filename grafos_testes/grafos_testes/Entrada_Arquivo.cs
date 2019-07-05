using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace grafos_testes {
    class Entrada_Arquivo {
        public static List<string> carregar() {
            // cria uma lista para armazenar os dados encontrados no doc;
            List<string> dados = new List<string>();
            string file = "dados.txt";
            //declara uma variavel para receber linha por linha do arq;
             string linha;
                if (File.Exists(file)) {
                    using (StreamReader leitura = new StreamReader(file)) {
                        while ((linha = leitura.ReadLine()) != null) {
                            dados.Add(linha);

                        }
                        return dados;
                    }
                } else {
                    // caso não seja localizado o arquivo
                    Console.WriteLine("Arquivo não encontrado.");
                    return null;
                }
            
            

        }
    }
}
