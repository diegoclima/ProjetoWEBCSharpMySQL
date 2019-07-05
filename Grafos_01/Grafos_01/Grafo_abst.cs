
using System.Collections.Generic;
using System;
using System.Text;

namespace Grafos_01 {
    public abstract class Grafo_abst<T, K>: IGrafo<T, K> {
        protected List<T> VerticeSet = new List<T>();
        protected List<IValues<T>> arestaSet = new List<IValues<T>>();
        protected Dictionary<IValues<T>, K> pesoAresta = new Dictionary<IValues<T>, K>();
        public abstract bool addAresta(T v1, T v2, K peso);
          
        public bool addVertice(T vertice) {
            if (vertice == null) {
                throw new ArgumentNullException();
            }
            if (VerticeSet.Contains(vertice))
                return false;
            VerticeSet.Add(vertice);
             return true;
        }

        public void addVertice(IEnumerable<T> verticeSet) {
            if (verticeSet == null) {
                throw new ArgumentNullException();
            }
            using (var obj = VerticeSet.GetEnumerator()) {
                while (obj.Current != null && !VerticeSet.Contains(obj.Current)) {
                    VerticeSet.Add(obj.Current);
                }
            }
        }

        public IEnumerable<IValues<T>> getArestasSet() {
            return arestaSet;
        }

        public abstract K getPeso(T v1, T v2);

        public IEnumerable<T> getVerticeSet() {
            return VerticeSet;
        }

        public abstract int Grau(T vertice);
        public abstract int grauChegada(T vertice);

        public abstract int grauSaida(T vertice);

        public abstract bool isAdjacente(T v1, T v2);

        public int numArestas() {
            return arestaSet.Count;
        }

        public int numVertices() {
            return VerticeSet.Count;
        }
        /// <summary>
        /// Remove o vertice, checa se o valor passado como argumento
        /// é nulo, envia uma exceção.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public abstract bool removeAresta(T v1, T v2);

        public bool removeVertice(T vertice) {
            if (vertice == null) {
                throw new ArgumentNullException();
            }
            else if (!VerticeSet.Contains(vertice)) {
                return false;
            }
            VerticeSet.Remove(vertice);
            return true;
        }
        /// <summary>
        /// Remove um conjunto de vertices 
        /// </summary>
        /// <param name="verticeSet"></param>
        public void removeVertice(IEnumerable<T> verticeSet) {
            if (verticeSet == null) {
                throw new ArgumentNullException();
            }
            using (var ob = verticeSet.GetEnumerator()) {
                while(ob.MoveNext())
                    if (ob.Current!=null) {
                        VerticeSet.Remove(ob.Current);
                    }
            }
        }

        public abstract IEnumerable<T> verticeAdjacente(T vertice);
       
    }
}
