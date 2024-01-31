package Seminar_2;
// Задание №3
// Напишите метод, который принимает на вход строку (String) и 
// определяет является ли строка палиндромом (возвращает 
// boolean значение).
public class Polindrome {
    public static void main(String[] args) {
        String str = "анфна";                // --> true ?? Сделать проверку длины слова на четность
        System.err.println(isPalendrome(str.toLowerCase()));
    }

    public static boolean isPalendrome(String str) {
        int leftChar = 0;
        int rightChar = str.length() - 1;
        while (leftChar < rightChar) {
            if (str.charAt(leftChar) != str.charAt(rightChar)) {
                return false;
            }
            leftChar++;
            rightChar--;
        }
        return true;
    }
}
