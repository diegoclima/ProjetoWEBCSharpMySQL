using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;


namespace Grafos_01 {
    class GrafosDirigidos<T, K>: Grafo_abst<T, K> {

        public override bool addAresta(T v1, T v2, K peso) {
            if (v1 ==null || v2 == null || peso == null ) {
                throw new ArgumentNullException();
            }
            if (!VerticeSet.Contains(v1) ||!VerticeSet.Contains(v2) ) {
                return false;
            }
            IValues<T> vlr = new PairValueImplementaion<T>(v1, v2);
            if (arestaSet.Contains(vlr)) {
                return false;
            }
            arestaSet.Add(vlr);
            pesoAresta[vlr] = peso;
            return true;
        }

        public override K getPeso(T v1, T v2) {
            if (v1 == null || v2 == null) {
                throw new ArgumentNullException();
            }
            IValues<T> vl = new PairValueImplementaion<T>(v1, v2);
            if (!pesoAresta.ContainsKey(vl)) {
                throw new ArgumentNullException();
            }
            return pesoAresta[vl];

        }

        public override int Grau(T vertice) {
            if (vertice == null) {
                throw new ArgumentNullException();
            }
            if (!VerticeSet.Contains(vertice)) {
                throw new ArgumentNullException();
            }
            return grauChegada(vertice) + grauSaida(vertice);
        }

        public override int grauChegada(T vertice) {
            if (vertice== null) {
                throw new ArgumentNullException();
            }
            if (!VerticeSet.Contains(vertice)) {
                throw new ArgumentNullException();
            }
            int cont = 0;
            foreach (var v in arestaSet) {
                if (v.getPrimeiro().Equals(vertice)) {
                    cont++;
                }
            }
            return cont;
        }

        public override int grauSaida(T vertice) {
            if (vertice == null) {
                throw new ArgumentNullException();
            }
            if (!VerticeSet.Contains(vertice)) {
                throw new ArgumentNullException();
            }
            int cont = 0;
            foreach (var v in arestaSet) {
                if (v.getSegundo().Equals(vertice)) {
                    cont++;
                }
            }
            return cont;
        }

        public override bool isAdjacente(T v1, T v2) {
            if (v1 == null || v2 == null) {
                throw new ArgumentNullException();
            }
            if(!VerticeSet.Contains(v1) || !VerticeSet.Contains(v2)) {
                throw new ArgumentNullException();
            }
            return arestaSet.Contains(new PairValueImplementaion<T>(v1, v2));
        }

        public override bool removeAresta(T v1, T v2) {
            if (v1 == null || v2 == null) {
                throw new ArgumentNullException();
            }
            IValues<T> vl = new PairValueImplementaion<T>(v1, v2);
            if (arestaSet.Contains(vl)) {
                arestaSet.Remove(vl);
                pesoAresta.Remove(vl);
                return true;
            }
            return false;
        }

        public override IEnumerable<T> verticeAdjacente(T vertice) {
            foreach (IValues<T> p in arestaSet) {
                if (p.getPrimeiro().Equals(vertice)) {
                    yield return p.getSegundo();
                }
            }
        }
    }
}
