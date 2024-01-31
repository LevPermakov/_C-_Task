package Seminar_4;

import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

// Задание №1
// Реализовать консольное приложение, которое:
// 1. Принимает от пользователя строку вида 
// text~num
// 2. Нужно рассплитить строку по ~, сохранить text в связный список на 
// позицию num.
// 3. Если введено print~num, выводит строку из позиции num в связном 
// списке и удаляет её из списка

public class UserList {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<String> list = new LinkedList<>();

        while (true) {
            System.out.println();
            System.out.println("Введите строку вида:");
            System.out.println("text~num - для добавления элемента,");
            System.out.println("print~num - для вывода элемента и его удаления,");
            System.err.println("exit - для завершения программы.");
            String input = scanner.nextLine();
            if (input.toLowerCase().equals("exit"))
                break;

            String[] inputSplit = input.split("~");
            String text = inputSplit[0];
            int pos = Integer.parseInt(inputSplit[1]);

            if (text.toLowerCase().equals("print")) {
                if (pos >= 0 && pos <= list.size()) {
                    System.out.println(list.get(pos));
                    list.remove(pos);
                    System.out.println(list);
                }
                
            } else {
                if (pos >= 0 && pos <= list.size()) {
                list.add(pos, text);
                System.out.println(list);
                }   
            }
        }
        scanner.close();
    }
}
