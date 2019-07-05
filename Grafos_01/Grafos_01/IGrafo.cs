namespace Grafos_01 {
    using System.Collections.Generic;
    public interface IGrafo<T,K> {
        /// <summary>
        /// Adiciona os Vértices.
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        bool addVertice(T vertice);
        void addVertice(IEnumerable<T> verticeSet);
        /// <summary>
        /// Remove os vértices;
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        bool removeVertice(T vertice);
        void removeVertice(IEnumerable<T> verticeSet);
        bool addAresta(T v1, T v2, K peso);
        /// <summary>
        /// Obtém o peso das arestas;
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        K getPeso(T v1, T v2);
        bool removeAresta(T v1, T v2);
        /// <summary>
        /// Verifica se é adjacente 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        bool isAdjacente(T v1, T v2);
        /// <summary>
        /// Define o grau do vértice
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        int Grau(T vertice);
        int grauChegada(T vertice);
        int grauSaida(T vertice);
        /// <summary>
        /// Define a quantidade de arestas;
        /// </summary>
        /// <returns></returns>
        int numArestas();
        /// <summary>
        /// Define o núermo de vertices;
        /// </summary>
        /// <returns></returns>
        int numVertices();
        /// <summary>
        /// Retorna os vertices adjacentes especificados no argumento
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        IEnumerable<T> verticeAdjacente(T vertice);
        /// <summary>
        /// Retorna um IEnumerable contendo os conjuntos de vertices do grafo
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> getVerticeSet();
        /// <summary>
        /// retorna um elemento comentndo o numero de arestas do grafo
        /// representando sua ligacao.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        IEnumerable<IValues<T>> getArestasSet();
        



    }
}
