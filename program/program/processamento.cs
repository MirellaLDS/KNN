using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public static class Processamento
    {
        // função que retorna a distância euclidiana entre 2 indivíduos
        public static double obterDistEuclidiana(Individuo ind1, Individuo ind2)
        {
            /*
                a distância euclidiana é a raiz quadrada da soma das
                diferenças dos valores dos atributos elevado ao quadrado
            */

            double soma = Math.Pow((ind1.a - ind2.a), 2) +
                          Math.Pow((ind1.b - ind2.b), 2) +
                          Math.Pow((ind1.c - ind2.c), 2) +
                          Math.Pow((ind1.d - ind2.d), 2);

            double distancia = Math.Sqrt(soma);
            ind1.distancia = distancia;

            return distancia;

        }

        public static void normilizeFileData(List<Individuo> individuos, Individuo individuo)
        {
            if (individuo == null)
            {
                foreach (var item in individuos)
                {
                    item.a = Processamento.normalizarEntradas(item.a, individuos.OrderByDescending(x => x.a).First().a);
                    item.b = Processamento.normalizarEntradas(item.b, individuos.OrderByDescending(x => x.b).First().b);
                    item.c = Processamento.normalizarEntradas(item.c, individuos.OrderByDescending(x => x.c).First().c);
                    item.d = Processamento.normalizarEntradas(item.d, individuos.OrderByDescending(x => x.d).First().d);
                }
            }
            else
            {
                individuo.a = Processamento.normalizarEntradas(individuo.a, individuos.OrderByDescending(x => x.a).First().a);
                individuo.b = Processamento.normalizarEntradas(individuo.b, individuos.OrderByDescending(x => x.b).First().b);
                individuo.c = Processamento.normalizarEntradas(individuo.c, individuos.OrderByDescending(x => x.c).First().c);
                individuo.d = Processamento.normalizarEntradas(individuo.d, individuos.OrderByDescending(x => x.d).First().d);
            }
        }

        private static double normalizarEntradas(double newItem, double oldItem)
        {
            return newItem / oldItem;
        }

        public static double normalizarEntradas(double amostra1, double amostraMin2, double amostraMax2)
        {
            return (amostra1 - amostraMin2) / (amostraMax2 - amostraMin2);
        }

        public static string classificarAmostra(List<Individuo> individuos, Individuo novo_exemplo, int K)
        {

            Dictionary<int, double> dist_individuos = findValuesWithDistance(individuos, novo_exemplo, K);
          
            /*
	            para decidir a qual classe pertence o novo exemplo,
	            basta verificar a classe mais frequente dos K
	            vizinhos mais próximos
	        */

            Dictionary<string, int> class_individuos = new Dictionary<string, int>();
            class_individuos.Add("Iris-setosa", 0);
            class_individuos.Add("Iris-versicolor", 0);
            class_individuos.Add("Iris-virginica", 0);

            foreach (var item in findMinValeus(dist_individuos, K))
            {
                string classe = individuos[item.Key].classe;

                if (classe == "Iris-setosa")
                {
                    class_individuos["Iris-setosa"] += 1;
                }
                else if (classe == "Iris-versicolor")
                {
                    class_individuos["Iris-versicolor"] += 1;
                }
                else
                {
                    class_individuos["Iris-virginica"] += 1;
                }
            }

            // Pega a classe que mais se repete e retorna

            return findClass(class_individuos);

        }

        public static Dictionary<int, double> findMinValeus(Dictionary<int, double> dist_individuos, int K)
        {
            //Retorna uma lista com os K itens que tenham a menor distância.
            var items = dist_individuos.OrderBy(x => x.Value).Take(K);

            return items.ToDictionary(t => t.Key, t => t.Value);
        }

        private static string findClass(Dictionary<string, int> class_individuos)
        {
            var items = class_individuos.OrderByDescending(x => x.Value).First();

            return items.Key;
        }

        public static Dictionary<int, double> findValuesWithDistance(List<Individuo> individuos, Individuo novo_exemplo, int K)
        {
            // se o K for par decrementa, privilegiar impar.
            if (K % 2 == 0)
            {
                K--;
                if (K <= 0)
                    K = 1;
            }

            // Obtém o tamanho do vetor
            int tam_vet = individuos.Count;

            Dictionary<int, double> dist_individuos = new Dictionary<int, double>();

            /*
		        calcula-se a distância euclidiana do novo exemplo
		        para cada amostra do conjunto de treinamento
	        */

            for (int position = 0; position < tam_vet; position++)
            {
                double dist = obterDistEuclidiana(individuos[position], novo_exemplo);
                dist_individuos.Add(position, dist);
            }

            return dist_individuos;
        }

    }
}
