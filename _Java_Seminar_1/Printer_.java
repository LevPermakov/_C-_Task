package Seminar_1;

// import java.io.*;
// import java.util.*;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer_ {
    public static void main(String[] args) {
        int n = 0;

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            n = 8;
        } else {
            n = Integer.parseInt(args[0]);
        }

        // Вывод результата на экран
        Answer ans = new Answer();
        int itresume_res = ans.countNTriangle(n);
        System.out.println(itresume_res);
    }

    
}

class Answer {
        public int countNTriangle(int n) {

            // Введите свое решение ниже
            return (n * (n + 1) / 2);
        }
}
