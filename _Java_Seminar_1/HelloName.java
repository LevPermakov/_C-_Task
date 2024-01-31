package Seminar_1;

// Задание №1
// Написать программу, которая запросит пользователя ввести
// <Имя> в консоли.
// Получить введенную строку и выведет в консоль сообщение
// “Привет, <Имя>!”

import java.util.Scanner;

public class HelloName {
    public static void main(String[] args) {
        // Ввод данных
        System.out.print("Введите Ваше имя, пожалуйста: ");
        Scanner scanner = new Scanner(System.in,"ibm866");   // ввод с Консоли
        //                                         подгружаем, чтобы  выводить Кириллицой, напр., "Привет!"
        String name = scanner.nextLine();
        // System.out.println("Привет, " + name + "!");    // через конкатенацию
        System.out.printf("Привет, %s!", name);     // через форматирование (предпочтительнее - экономнее испольование памяти)

        scanner.close();

    }
}
