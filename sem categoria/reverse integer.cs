
using System;
using System.Linq;
using Internal;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            //
            // a ideia é que o computador não gosta de quando passamos do limite de 32 bits.
            // e se utilizarmos matemática para inverter o numero, temos nosso algoritmo!
            // para inverter básicamente pegamos o módulo do numero por 10: isso sempre pegara o ultimo digito do numero.
            // então somamos este módulo e multiplicamos por 10. 
            // enquanto isso o numero original é divido por 10, podemos ignorar valores fracionais.
            // assim o ultimo numero eventualmente irá virar o primeiro.
            // conforme o novo numero é criado, o computador irá calcula-lo, se o computador gostar do numero ele irá ser calculado
            // se ele não gostar, significa que passou do limite de 32 Bits e provavelmente não foi calculado o resultado esperado.
            //

            int result = 0;
            while (x != 0)
            {
                Int32 remainder = x % 10;
                Int32 temp = result * 10 + remainder;

                if ((temp - remainder) / 10 != result)
                {
                    return 0;
                }

                result = temp;
                x = x / 10;



            }

            return result;

        }
    }
}