// https://leetcode.com/problems/car-fleet/

public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    { // retornar quantas "ilhas" de carros irão chegar no destino.
      // básicamente calcular a velocidade do carro atual e do traseiro. 
      // encontrar onde eles se encontram e caso seja antes da linha de chegada aumentar o numero de ilhas em 1.
      // 
	
	var pair = new(int, int)[position.Length];
	for (var i=0; i < position.Length; i++)
	{ // juntamos para poder organizar mais tarde.
	    pair[i] = (position[i], speed[i]);
	}
	
	var stack = new Stack<double>(); // não sabemos se os valores serão garantidamente inteiros.
	// básicamente começamos pelos veiculos mais pertos do destino:
	// em seguida colocamos no stack o momento (tempo) que ele chegara no destino.
	// como estamos medindo o tempo e não a velocidade, a checagem será invertida.
	// checamos se possuimos mais de 1 veiculo.
	// checamos se o tempo para chegar é menor que o carro da frente
	// se for, temos outra ilha.
	
	
	foreach (var (p, s) in pair.OrderByDescending(i => i.Item1))
	{
	    	stack.Push((target - p) / (double)s);
		if (stack.Count >= 2 && stack.Peek() <= stack.Skip(1).First() )  
		{
			stack.Pop();
		}
		
	}

	return stack.Count;

    }
}


