using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program
{
    public partial class Form1 : Form
    {
        string iresFile; //file to classify
        List<Individuo> individuos;
        System.IO.StreamReader file;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            individuos = new List<Individuo>();
            OpenFileDialog cFile = new OpenFileDialog();//open file windows
            cFile.Filter = "classify customer file|*.txt";//filter only open .txt file

            cFile.ShowDialog();

            if (cFile != null)
            {
                iresFile = cFile.FileName;
                this.txtFile.Text = cFile.FileName;//get path file

                //read data into unknown customerset
                //read information in customer file
                string line;

                // Read the file and display it line by line.
                file = new System.IO.StreamReader(iresFile);

                while ((line = file.ReadLine()) != null)
                {
                    string[] split = line.Split(' ');

                    Individuo ind = new Individuo();

                    ind.a = double.Parse(split[0].Replace(".", ","));
                    ind.b = double.Parse(split[1].Replace(".", ","));
                    ind.c = double.Parse(split[2].Replace(".", ","));
                    ind.d = double.Parse(split[3].Replace(".", ","));
                    ind.classe = split[4];

                    individuos.Add(ind);
                }

                //Processamento.normilizeFileData(individuos, null);

                button1.Enabled = true;
            }
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            /*
		        o K é a quantidade de vizinhos que serão
		        levados em conta para classificação de um
		        novo dado, é recomendável que seja ímpar
		        para que não possa haver empate
	        */
            int K = Int32.Parse(txtNumber.Text);

            // tamanho do conjunto de dados de treinamento
            int tam_treinamento = Int32.Parse(txtQtdItens.Text); //Total 150 usar no maximo uns 70% para obter um melhor resultado.

            int acertos = 0;
            int tam_testes = 150 - tam_treinamento;

            // processo de classificação
            for (int i = 0; i < tam_testes; i++)
            {
                string classe = individuos[i].classe;
                string classe_obtida = Processamento.classificarAmostra(individuos, individuos[i], K);

                if (classe == classe_obtida)
                {
                    acertos++;
                }
            }

            label3.Text = "Número de acertos: " + acertos;
        }

        private void insertRow(Individuo ind, int K)
        {
            dataGrid.Rows.Clear();

            Dictionary<int, double> minValues = Processamento.findMinValeus(Processamento.findValuesWithDistance(individuos, ind, K), K);
           
            int index = 0;

            foreach (var item in minValues)
            {
                index = index + 1;

                string[] column = new string[7];
                column[0] = index.ToString();
                column[1] = item.Key.ToString();
                column[2] = individuos[item.Key].a.ToString();
                column[3] = individuos[item.Key].b.ToString();
                column[4] = individuos[item.Key].c.ToString();
                column[5] = individuos[item.Key].d.ToString();
                column[6] = individuos[item.Key].classe;

                dataGrid.Rows.Add(column);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int K = Int32.Parse(txtNumber.Text);

            Individuo ind = new Individuo(textBox1.Text.Replace(".", ","), textBox2.Text.Replace(".", ","), textBox4.Text.Replace(".", ","), textBox3.Text.Replace(".", ","), "");

            //Individuo ind2 = new Individuo();
            //ind2.a = 7.0;
            //ind2.b = 2.8;
            //ind2.c = 1.3;
            //ind2.d = 4.1;
            //ind2.classe = "Iris-versicolor";

            //double dist2 = Processamento.obterDistEuclidiana(ind2, ind);
            //ind2.distancia = dist2;
            //List<Individuo> list = new List<Individuo>();
            //list.Add(ind2);
            //int i = 0;
            //if (i >= 0)
            //{
            //    i++;
            //    Console.Write("Mirella: " + Processamento.classificarAmostra(list, ind, K));
            //}

            //Processamento.normilizeFileData(individuos, ind);

            insertRow(ind, K);

            label10.Text = Processamento.classificarAmostra(individuos, ind, K);
        }

    }
}
