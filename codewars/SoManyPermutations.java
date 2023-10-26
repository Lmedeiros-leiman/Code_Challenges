// https://www.codewars.com/kata/5254ca2719453dcc0b00027d/train/csharp

import java.util.*;

public class SoManyPermutations {

    public static void generate(String seq, String out, List<String> list) {
        if (seq.isEmpty()) {
            if (!list.contains(out))
                list.add(out);
        } else
            for (int i = 0; i < seq.length(); i++)
                generate(remove(seq, i), out + seq.charAt(i), list);
    }

    public static String remove(String str, int idx) {
        return str.substring(0, idx) + str.substring(idx + 1);
    }

    public static List<String> singlePermutations(String s) {
        List<String> list = new ArrayList<>();
        for (int i = 0; i < s.length(); i++) {
            generate(remove(s, i), "" + s.charAt(i), list);
        }
        return list;
    }

}