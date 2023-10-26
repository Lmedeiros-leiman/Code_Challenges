import java.util.*;

public class CountChars {
    public static Map<Character, Integer> count(String str) {

        Map<Character, Integer> dict = new HashMap<>();

        char[] charList = str.toCharArray();

        for (int i = 0; i < str.length(); i++) {
            if (dict.containsKey(charList[i])) {
                int dictvalue = dict.get(charList[i]);
                dict.put(charList[i], dictvalue + 1);
            } else {
                dict.put(charList[i], 1);
            }
        }
        // Happy coding!
        return dict;
    }
}