using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaTopCoders.Easy
{
    #region Problema AB: Descrição
    /// Problem Statement
    //      You are given two s: N and K. Lun the dog is interested in strings that satisfy the following conditions:
    //          The string has exactly N characters, each of which is either 'A' or 'B'.
    //          The string s has exactly K pairs (i, j) (0 <= i < j <= N-1) such that s[i] = 'A' and s[j] = 'B'.
    //      If there exists a string that satisfies the conditions, find and return any such string. Otherwise, return an empty string.
    #endregion

    public class ProblemAb
    {
        /// <summary>
        /// Método que recebe uma string com As e Bs e retorna o número de pares válidos
        /// </summary>
        /// <param name="cadeia">string de As e Bs. Exemplo: "BAABBBAB"</param>
        /// <returns>retorna o número de pares válidos encontrados. Exemplo: "BAABBBAB" => 9</returns>
        public int RetornaNumeroParesValidos(string cadeia)
        {
            var contador = 0;

            for (int i = 0; i < cadeia.Length; i++)
            {
                if (cadeia[i].Equals('A'))
                {
                    contador += cadeia.Substring(i + 1).Replace("A", "").Length;
                }
            }

            return contador;
        }

        /// <summary>
        /// Método responsável por criar uma string no formato AB
        /// com n caracteres e K pares válidos
        /// </summary>
        /// <param name="n">tamanho da string que será criada</param>
        /// <param name="k">número de pares AB válidos</param>
        /// <returns></returns>
        public string CriaString(int n, int k)
        {
            var resultado = "";

            if (n <= 0)
                return resultado;

            if (k <= 0)
            {
                resultado = "B";
                return resultado.PadRight(n, 'A');
            }

            var metade = Convert.ToInt32(n/2);
            var melhorCaso = metade * (n - metade);

            if (k > melhorCaso)
                return resultado;

            if (k == melhorCaso)
            {
                resultado = resultado.PadRight(metade, 'A');
                resultado = resultado.PadRight(n, 'B');

                return resultado;
            }

            if (k < n)
            {
                resultado = "A" + new string('B', k);
                resultado = resultado.PadRight(n, 'A');

                return resultado;
            }

            resultado = resultado.PadRight(k / 2, 'A');
            resultado = resultado.PadRight((k / 2) + 2, 'B');

            if (k % 2 == 0)
                resultado = resultado.PadRight(n, 'A');

            if (k % 2 == 0)
            {
                resultado = resultado.PadRight(k / 2, 'A');
                resultado = resultado.PadRight((k / 2) + 2, 'B');
                resultado = resultado.PadRight(n, 'A');

                return resultado;
            }
            else
            {
                resultado = "ABA";
                resultado = resultado.PadRight(n, 'B');

                return resultado;
            }

            return resultado;
        }

    }
}
