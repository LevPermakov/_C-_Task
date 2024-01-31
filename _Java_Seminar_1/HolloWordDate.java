package Seminar_1;

import java.time.LocalDateTime;
import java.util.Scanner;

// Настроить проект, вывести в консоль “Hello world!”.
// Вывести в консоль системные дату и время.

public class HolloWordDate {

    public static void main(String[] args) {
        System.out.println("Hello, world!");
        System.out.println(LocalDateTime.now());

        // Ввод данных
        Scanner scanner = new Scanner(System.in,"ibm866");   // ввод с Консоли
        //                                          подгружаем, чтобы  выводить Кириллицой, напр., "Привет!"
        String text = scanner.nextLine();
        System.out.println(text);
        scanner.close();

        System.out.println();


        // Типы данных
        int num = 2023; // - целочисленный
        double numD = 5.56; // - вещественный (дробное число)
        // float                // - это double меньше точности (singl)
        String str = "Привет!";  // строковый (Ссылочный тип - с Большой буквы)
        char ch = 'r';           // символьный (в 'к' одинарных кавычках)
                                // - неявно этот тип является ЧИСЛОВЫМ

        // boolean b = true;
        // boolean b = 5 > 3;     // true

        // Структуры данных
        while (true) {         // бесконечный цыкл (без break)
            break;     // - остановка цикла
        }

        for (int i = 0; i < 10; i++) {    // fori
        }


        // создаем массив 
        int[] array = new int[8];  // пустой массив, 8 элементов
        int[] array1 = {5, 53, 5, 7, 2, 5};  //массив заполненный
 
        // for (iterable_type iterable_element : iterable) {   // foreach
        //        тип               для работы с коллекциями
        // }

        for (int elem : array1) {
            // System.out.println(elem);  // вывод с новой строоки
            System.out.print(elem + " ");  // вывод строкой с пробелом (через конкотенацию)   5 53 5 7 2 5
        }

        System.out.println();   // пустой вывод - перевод строки
        System.out.printf( "Уходящий год: %d" , num);  // фоматированный вывод   
        //   %d - вывод символьного типа
        //   %s - строка
        //   %f - вещественного типа



    }

}