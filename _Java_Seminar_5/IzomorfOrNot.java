package Seminar_5;

import java.util.HashMap;

// Задание №1
// Даны 2 строки, написать метод, который вернет true, если эти строки являются изоморфными
// и false, если нет. Строки изоморфны, если одну букву в первом слове можно заменить на
// некоторую букву во втором слове, при этом
// 1. повторяющиеся буквы одного слова меняются на одну и ту же букву с сохранением
// порядка следования. (Например, add - egg изоморфны)
// 2. буква может не меняться, а остаться такой же. (Например, note - code)
// Пример 1:
// Input: s = "foo", t = "bar"
// Output: false
// Пример 2:
// Input: s = "paper", t = "title"
// Output: true

public class IzomorfOrNot {
    public static void main(String[] args) {
        String wordOne = "foo", wordTwo = "bar";
        // String wordOne = "paper", wordTwo = "title";

        System.out.println(checkToIsomorph(wordOne, wordTwo)); 
        
    }

    public static boolean checkToIsomorph (String textOne, String textTwo) {
        if (textOne.length() !=  textTwo.length()) {
            return false;
        }
        if (textOne.equals(textTwo)) {
            return true;
        }

        HashMap <Character, Character> hashMap = new HashMap<>();

        for (int i = 0; i < textOne.length(); i++) {
            char key = textOne.charAt(i);
            char value = textTwo.charAt(i);
            if (hashMap.containsKey(key)) {
                if (hashMap.get(key) != value) {
                    return false;
                }
            }
            else {
                hashMap.put(key, value);
            }
        }
        return true;

    }

}
