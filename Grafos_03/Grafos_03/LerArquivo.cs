using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grafos_03 {
    public class LerArquivo {
        public static List<String> carregar() {
            // cria uma lista para armazenar os dados encontrados no doc;
            List<String> dados = new List<string>();
            string file = "dados.txt";
            string linha; // que vai armazenar os dados linha por linha
            try {
                
                if (File.Exists(file)){
                    StreamReader entrada = new StreamReader(file);
                    while ((linha = entrada.ReadLine()) != null) { // linha recebe os dados;
                        dados.Add(linha); // ao receber os dados, são armazenados na lista;
                    }
                    return dados;
                } else
                    return null;
            } catch (ArgumentException arg) {

                Console.WriteLine("Erro " + arg.Message);
            }
            return dados;
        }
    }
}
