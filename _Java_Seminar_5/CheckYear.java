package Seminar_5;

// Задание №3
// Написать метод, который переведет число из римского формата записи в арабский.
// Например, MMXXIV = 2024

// Соответствия:
// 'I' 1
// 'V' 5
// 'X' 10
// 'L' 50
// 'C' 100
// 'D' 500
// 'M' 1000


import java.util.Map;
import java.util.HashMap;

public class CheckYear {
    public static void main(String[] args) {
        System.out.println(ConvertRomanToArabic("MMXXIV"));
    }

    public static Map<Character, Integer> DictionaryRomanToArabic() {
        Map<Character, Integer> hashMapDict = new HashMap<>();
        hashMapDict.put('I', 1);
        hashMapDict.put('V', 5);
        hashMapDict.put('X', 10);
        hashMapDict.put('L', 50);
        hashMapDict.put('C', 100);
        hashMapDict.put('D', 500);
        hashMapDict.put('M', 1000);
        return hashMapDict;
    }

    public static int ConvertRomanToArabic(String romanNum) {
        Map<Character, Integer> mapDict = DictionaryRomanToArabic();
        int result = 0;
        int prevValue = 0;

        for (int i = romanNum.length() -1; i >= 0; i--) {
            int value = mapDict.get(romanNum.charAt(i));
            if (value < prevValue) {
                result -= value;
            }
            else {
                result += value;
            }
            prevValue = value;
        }
        return result;
    }
}