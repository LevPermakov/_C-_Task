package Seminar_4;

import java.util.LinkedList;

public class HW_41_Printer {
    public static void main(String[] args) {
        // LinkedList<Object> ll = fillList();
        LinkedList<Object> ll = new LinkedList<>();

        if (args.length == 0 || args.length != 4) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            ll.add(1);
            ll.add("One");
            ll.add(2);
            ll.add("Two");
        } else {
            ll.add(Integer.parseInt(args[0]));
            ll.add(args[1]);
            ll.add(Integer.parseInt(args[2]));
            ll.add(args[3]);
        }

        LLTasks answer = new LLTasks();

        System.out.println(ll);

        LinkedList<Object> reversedList = answer.revert(ll);
        System.out.println(reversedList);
    }

}

class LLTasks {
    public static LinkedList<Object> revert(LinkedList<Object> ll) {
        // Напишите свое решение ниже
        int n = ll.size() / 2;
        int m = ll.size();
        for (int i = 0; i < n; i++) {
            Object temp = ll.get(i);
            ll.set(i, ll.get(m - i - 1));
            ll.set(m - i - 1, temp);
        }
        return ll;
    }

}

// Эталонное решение


// import java.util.LinkedList;

// class LLTasks {
//     public static void revertLL(LinkedList<Object> ll) {
//         // Напишите свое решение ниже
//         int size = ll.size();
//         for (int i = 0; i < size / 2; i++) {
//             Object temp = ll.get(i);
//             ll.set(i, ll.get(size - i - 1));
//             ll.set(size - i - 1, temp);
//         }
//     }
// }

// // Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
// public class Printer{ 
//     public static void main(String[] args) { 
//         LinkedList<Object> ll = new LinkedList<>();

//         if (args.length == 0 || args.length != 4) {
//         // При отправке кода на Выполнение, вы можете варьировать эти параметры
//             ll.add(1);
//             ll.add("One");
//             ll.add(2);
//             ll.add("Two");
//         } else {
//             ll.add(Integer.parseInt(args[0]));
//             ll.add(args[1]);
//             ll.add(Integer.parseInt(args[2]));
//             ll.add(args[3]);
//         }

//         LLTasks answer = new LLTasks();
//         System.out.println(ll);
//         answer.revertLL(ll);
//         System.out.println(ll);
//     }
// }
