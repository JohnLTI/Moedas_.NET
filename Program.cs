using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //var valor = 10.25;
            decimal valor = 10.25m; //OPÇÃO MAIS VIÁVEL

            //CONVERSÃO PARA A NOTAÇÃO BRASILEIRA, UTILIZANDO VIRGULA PARA CASAS DECIMAIS
            //UTILIZANDO C(CURRENT) COMO PARÂMETRO, O VALOR JÁ EXIBIDO EM MOEDA
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("es-US"))); //Inglês
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); //Português
        }
    }
}