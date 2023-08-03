using System;
using System.Globalization;

namespace Moedas {
    class Program {
        static void Main(string[] args) {
            Console.Clear();
            //var valor = 10.25;
            decimal valor = 10.25m; //OPÇÃO MAIS VIÁVEL

            //CONVERSÃO PARA A NOTAÇÃO BRASILEIRA, UTILIZANDO VIRGULA PARA CASAS DECIMAIS
            //UTILIZANDO C(CURRENCY) COMO PARÂMETRO, O VALOR JÁ EXIBIDO EM MOEDA
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-US"))); //Inglês
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); //Português
            Console.WriteLine(Math.Round(valor)); //MÉTODO PARA ARRENDONDAR
            Console.WriteLine(Math.Ceiling(valor)); //MÉTODO PARA ARRENDONDAR PARA CIMA
            Console.WriteLine(Math.Floor(valor)); //MÉTODO PARA ARRENDONDAR PARA BAIXO
        }
    }
}