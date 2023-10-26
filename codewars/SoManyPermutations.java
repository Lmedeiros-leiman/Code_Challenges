// https://www.codewars.com/kata/5254ca2719453dcc0b00027d/train/csharp

// a ideia é pegar a string original e mostrar todas as permutações possiveis.
// obrigatório remover as permutações duplicadas
// ("ab" => ["ab","ba"] )
//
//
//
//

import java.util.*;

public class SoManyPermutations {

    public static void main(String[] args) {
        String str = "ABC";
        List<String> permutations = singlePermutations(str);
        for (String permutation : permutations) {
            System.out.println(permutation);
        }
    }

    public static List<String> singlePermutations(String s) {
        List<String> result = new ArrayList<>();
        permute(s.toCharArray(), 0, s.length() - 1, result);
        return result;
    }

    private static void permute(char[] str, int l, int r, List<String> result) {
        if (l == r) {
            result.add(new String(str));
        } else {
            for (int i = l; i <= r; i++) {
                str = swap(str, l, i);
                permute(str, l + 1, r, result);
                str = swap(str, l, i);
            }
        }
    }

    private static char[] swap(char[] a, int i, int j) {
        char temp = a[i];
        a[i] = a[j];
        a[j] = temp;
        return a;
    }

}
// This code is contributed by mits