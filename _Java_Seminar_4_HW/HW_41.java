package Seminar_4;

// 1. Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет 
// “перевернутый” список.

import java.util.LinkedList;

public class HW_41 {
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
        // printList(ll);
        // replaceList(ll);
        // System.out.println();
        // printList(ll);
        LinkedList<Object> reversedList = answer.revert(ll);
        System.out.println(reversedList);
    }

    public static void printList(LinkedList<Object> list) {
        for (Object el : list) {
            System.out.printf(el + " ");
        }
    }
    // public static LinkedList<Object> fillList(){
    // LinkedList<Object> ll = new LinkedList<>();
    // // LinkedList<Object> list = new LinList<>();
    // // list.add("Старт");
    // // list.add("один");
    // // list.add("два");
    // // list.add("три");
    // // list.add("четыре");
    // // list.add("пять");
    // // list.add(6);
    // // list.add("конец");
    // // return list;

    // ll.add(1);
    // ll.add("One");
    // ll.add(2);
    // ll.add("Two");
    // return ll;
    // }

    // public static void replaceList(LinkedList<Object> list) {
    //     int n = list.size() / 2;
    //     int m = list.size();
    //     for (int i = 0; i < n; i++) {
    //         Object temp = list.get(i);
    //         list.set(i, list.get(m - i - 1));
    //         list.set(m - i - 1, temp);
    //     }
    // }

    

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
