package Seminar_2;
// Задание №2
// Напишите метод, который сжимает строку. 
// Пример: вход aaaabbbcdd.

public class CountSimv {
    public static void main(String[] args) {
        String str = "aaaabbbcdd";
        System.out.println(compressString(str));
    }

    public static String compressString(String str) {
        StringBuilder sb = new StringBuilder();
        int count = 1;
        char sim = str.charAt(0);
        for (int i = 1; i < str.length(); i++) { // здесь length() - метод, когда массив - как свойство (без скобок)
            if (str.charAt(i) == sim) {
                count ++;
            }
            else {
                sb.append(sim).append(count);
                count = 1;
                sim = str.charAt(i);
            }
        }
        sb.append(sim).append(count);
        return sb.toString();
    }

}
