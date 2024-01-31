package Seminar_3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

// Задание №1
// Заполнить список десятью случайными числами.
// Отсортировать список методом sort() и вывести его на
// экран.

public class SortList {
    public static void main(String[] args) {
        int count = 10;
        ArrayList<Integer> list = getRndList(count);
        
        System.out.println(list);
        Collections.sort(list);
        System.out.println(list);
    }

    private static ArrayList<Integer> getRndList(int count) {
        ArrayList <Integer> list = new ArrayList<>();
        Random rnd = new Random();

        for (int i = 0; i < count; i++) {
            list.add(rnd.nextInt(1, 10));
        }
        return list;
    }
}

// // До Рефакторинга
// public class SortList {
//     public static void main(String[] args) {
//         int count = 10;
//         ArrayList <Integer> list = new ArrayList<>();
//         Random rnd = new Random();

//         for (int i = 0; i < count; i++) {
//             list.add(rnd.nextInt(1, 10));
//         }
        
//         System.out.println(list);
//         Collections.sort(list);
//         System.out.println(list);
//     }
// }

