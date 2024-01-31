package Seminar_2;

//    Теория.
//    Как работает: String, StringBuilder

// Задание №1
// Дано четное число N (>0) и символы c1 и c2. 
// Написать метод, который вернет строку длины N, которая 
// состоит из чередующихся символов c1 и c2, начиная с c1

 public class AlternatingChars {
    public static void main(String[] args) {
        int n = 500_000;
        char c1 = 'x';
        char c2 = 'y';
        // char c1 = 'x', c2 = 'y';

        // запоминаем стартовое время:
        long start = System.currentTimeMillis();
        // System.out.println(alternatingCharsStr(n, c1, c2));
        // System.out.println(alternatingCharsSb(n, c1, c2));
        alternatingCharsStr(n, c1, c2);
        System.out.println(System.currentTimeMillis() - start);  // 7853 ms

        System.out.println();

        start = System.currentTimeMillis();
        alternatingCharsSb(n, c1, c2);
        System.out.println(System.currentTimeMillis() - start);  // 16 ms
        // StringBuilder работет в 490 раз быстрее

    }

    // Метод 1.  Собирать String
    public static String alternatingCharsStr(int n, char c1, char c2) {
        String str = "";
        for (int i = 0; i < n / 2; i++) {
            // str += c1 + c2;
            // символьный тип данных не поддерживает конкатенацию - слияние 
            // (в отличиие от строк), например: 'Hello' + 'Wold'
            // Сначала преобразовываем символ в строку
            str += Character.toString(c1) + Character.toString(c2);
        }
        return str;
    }

    
    // Метод 2.  Собирать StringBuilder
    public static String alternatingCharsSb(int n, char c1, char c2) {
        StringBuilder sb = new StringBuilder();
        // String - неизменяемый тип данных - монолит
        // StringBuilder - изменяемый тип данных - изменяемая строка
        // StringBuilder основан на массиве символов
        // кроме этого, т.к. это массив, то это динамический тип данных.
        // Первоначально выделяется массив под 16 символов (либо фиксируем n).
        for (int i = 0; i < n / 2; i++) {
            // sb.append(c1 + c2); - так нельзя. Получим сумму кодов этих символов.
            sb.append(c1).append(c2);
        }
        return sb.toString();  // по условию надо вернуть строку
    }
}
