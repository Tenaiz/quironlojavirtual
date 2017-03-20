using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        /// <summary>
        /// o Take é um operador utilizado para selecionar os primeiros objetos de uma coleção
        /// </summary>
        [TestMethod]
        public void Take()
        {
            // Neste teste estou comparando o primeiro Array com o segundo...
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // ... utilizando essa Query. Linqued SQL
            var resultado = from num in numeros.Take(5) select num;

            // Estou falando que como teste eu tenho que ter nesse array os mesmos primeiros 5 números do array de cima, caso contrário, dará erro. O índice 4 que está com o 8, vai dar falha.
            //int[] teste = { 5, 4, 1, 3, 8 };

            int[] teste = { 5, 4, 1, 3, 9 };

            // Compara se os resultados são iguais
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        /// <summary>
        /// O Skip é um operador utilizado para ignorar o(os) primeiro(s) objetos de uma coleção.
        /// </summary>
        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Take 5 = Pega os 5 primeiros / Skip 2 = Ignora os 2 primeiros
            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }
}
