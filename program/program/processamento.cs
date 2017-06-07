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

            return Math.Sqrt(soma);
        }

        public static double normalizarEntradas()
        {
            // Elaborar lógica.
            return 0;
        }

        public static string classificarAmostra(List<Individuo> individuos, Individuo novo_exemplo, int K)
        {
            // se o K for par decrementa
            if (K % 2 == 0)
            {
                K--;
                if (K <= 0)
                    K = 1;
            }

            // obtém o tamanho do vetor
            int tam_vet = individuos.Count;

            Dictionary<int, Individuo> dist_individuos = new Dictionary<int, Individuo>();

            /*
		        calcula-se a distância euclidiana do novo exemplo
		        para cada amostra do conjunto de treinamento
	        */

            for (int position = 0; position < tam_vet; position++)
            {
                double dist = obterDistEuclidiana(individuos[position], novo_exemplo);
                dist_individuos.Add(position, individuos[position]);
            }

            /*
	            para decidir a qual classe pertence o novo exemplo,
	            basta verificar a classe mais frequente dos K
	            vizinhos mais próximos
	        */

            int[] cont_classes = new int[3];
            int contK = 0;

            for (int contador = 0; contador < dist_individuos.Count; contador++)
            {
                if (contK == K)
                    break;
                Individuo ind = individuos[contador];
                string classe = ind.classe;

                if (classe == "Iris-setosa")
                {
                    cont_classes[0]++;
                }
                else if (classe == "Iris-versicolor")
                {
                    cont_classes[1]++;
                }
                else
                {
                    cont_classes[2]++;
                }

                contK++;
            }

            string classe_classificacao;

            if (cont_classes[0] >= cont_classes[1] && cont_classes[0] >= cont_classes[2])
            {
                classe_classificacao = "Iris-setosa";
            }
            else if (cont_classes[1] >= cont_classes[0] && cont_classes[1] >= cont_classes[2])
            {
                classe_classificacao = "Iris-versicolor";
            }
            else
            {
                classe_classificacao = "Iris-virginica";
            }

            return classe_classificacao;

        }

    }
}
