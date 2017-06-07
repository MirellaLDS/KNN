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

                ind.a = double.Parse(split[0]);
                ind.b = double.Parse(split[1]);
                ind.c = double.Parse(split[2]);
                ind.d = double.Parse(split[3]);
                ind.classe = split[4];

                individuos.Add(ind);
            }
        }

        private void lerArquivo(System.IO.StreamReader fileClassificado)
        {
            //read data into unknown customerset
            //read information in customer file
            string line;

            while ((line = fileClassificado.ReadLine()) != null)
            {
                string[] split = line.Split(' ');

                Individuo ind = new Individuo();

                ind.a = double.Parse(split[0]);
                ind.b = double.Parse(split[1]);
                ind.c = double.Parse(split[2]);
                ind.d = double.Parse(split[3]);
                ind.classe = split[4];

                individuos.Add(ind);
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

    }
}
