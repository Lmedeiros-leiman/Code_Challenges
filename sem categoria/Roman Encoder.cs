using System.Collections.Generic;

public class Solution
{
    public string IntToRoman(int num)
    {
        // originalmente eu queria utilizar um loop while para construir
        // utilizando um dicionário para colocar os elementos.
        // 
        // porem após uma análisada na lógica, o resultado ficou meio... diferente do esperado.
        // 
        // essa solução podia ser melhor: implementando um dicionário unico de lista de strings.
        // dai podia só criar uma função que que chama esses dicionários na sequencia certa, com o cheque de modulo sendo automatizado
        // com auxilio de algumas variaveis e if statements.
        //
        // e sim, essa solução é horrivel se a questão é "memória", mas é 2023... memória é básicamente piada.
        //
        // o problema dessa solução é que qualquer coisa acima da casa de 1000 é preciso modificar o código inteiro,
        // diferente do modo com while que só precisaria modificar o dicionário.
        // a parte boa é que ela é básicamente O(1).
        //

        string[] unidade = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] dezena = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] centena = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] mils = { "", "M", "MM", "MMM" };

        return mils[num / 1000] + centena[(num % 1000) / 100] + dezena[(num % 100) / 10] + unidade[num % 10];

    }
}