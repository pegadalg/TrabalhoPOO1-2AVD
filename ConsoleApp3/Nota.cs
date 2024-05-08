using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Instituicao
{
    public class Nota
    {
        // Atributo de classe
        private static float mediaAprovacao = 6;

        // Propriedades encapsuladas
        private float nota1;
        private float nota2;
        private float media;
        //Propriedades
        public float Nota1
        {
            get { return nota1; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota1 = value;
                }
                else
                {
                    Console.WriteLine("Nota inválida. A nota deve estar entre 0 e 10.");
                }
            }
        }
        
        public float Nota2
        {
            get { return nota2; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota2 = value;
                }
                else
                {
                    Console.WriteLine("Nota inválida. A nota deve estar entre 0 e 10.");
                }
            }
        }
        //Método para calcular a média
        public float CalcularMedia()
        {
            return media = (Nota1 + Nota2) / 2;
        }
        //Método para exibir a média
        public void ExibirMedia()
        {
            Console.WriteLine("A média do aluno é: " + media);
        }

        //sobrecarga de metodo
        // Método para verificar a situação do aluno
        public string Situacao()
        {
            if (CalcularMedia() >= mediaAprovacao)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
        //sobrecarga de metodo
        // Método para verificar a situação do aluno com base em uma média específica
        public string Situacao(float media)
        {
            if (CalcularMedia() >= media)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }



    }
}
