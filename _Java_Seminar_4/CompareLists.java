package Seminar_4;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

// Задание №0
// 1) Замерьте время, за которое в ArrayList добавятся 10000 элементов.
// 2) Замерьте время, за которое в LinkedList добавятся 10000 элементов. 
// Сравните с предыдущим.

// Добавление элементов в начало списка:
// int size = 100_000;
//
// Добавление элементов в начало списка:
// ArrayList: 578
// LinkedList: 16

// Добавление элементов в конец списка:
// ArrayList: 8
// LinkedList: 0

// Добавление элементов в середину списка:
// ArrayList: 240
// LinkedList: 8447

public class CompareLists {
    public static void main(String[] args) {
        int size = 100_000;

        System.out.println();
        System.out.println("Добавление элементов в начало списка:");
        long start = System.currentTimeMillis();
        fillArrayListFirst(size);
        System.out.println("ArrayList: " + (System.currentTimeMillis() - start));

        start = System.currentTimeMillis();
        fillLinkedListFirst(size);
        System.out.println("LinkedList: " + (System.currentTimeMillis() - start));
        System.out.println();


        System.out.println("Добавление элементов в конец списка:");
        start = System.currentTimeMillis();
        fillArrayListLast(size);
        System.out.println("ArrayList: " + (System.currentTimeMillis() - start));

        start = System.currentTimeMillis();
        fillLinkedListLast(size);
        System.out.println("LinkedList: " + (System.currentTimeMillis() - start));
        System.out.println();


        System.out.println("Добавление элементов в середину списка:");
        start = System.currentTimeMillis();
        fillArrayListMedium(size);
        System.out.println("ArrayList: " + (System.currentTimeMillis() - start));

        start = System.currentTimeMillis();
        fillLinkedListMedium(size);
        System.out.println("LinkedList: " + (System.currentTimeMillis() - start));
        System.out.println();

    }

    public static List<Integer> fillArrayListFirst(int size) {
        List<Integer> arrayList = new ArrayList<>();

        for (int i = 0; i < size; i++) {
            // arrayList.add(0, i);
            arrayList.addFirst(i);  // по индуксу - добавляем в начало
        }
        return arrayList;
    }

    public static List<Integer> fillLinkedListFirst(int size) {
        List<Integer> linkedList = new LinkedList<>();

        for (int i = 0; i < size; i++) {
            // arrayList.add(0, i);
            linkedList.addFirst(i);  // по индуксу - добавляем в начало
        }
        return linkedList;
    }

    public static List<Integer> fillArrayListLast(int size) {
        List<Integer> arrayList = new ArrayList<>();

        for (int i = 0; i < size; i++) {
            // arrayList.add(0, i);
            arrayList.addLast(i);  // по индуксу - добавляем в начало
        }
        return arrayList;
    }

    public static List<Integer> fillLinkedListLast(int size) {
        List<Integer> linkedList = new LinkedList<>();

        for (int i = 0; i < size; i++) {
            // arrayList.add(0, i);
            linkedList.addLast(i);  // по индуксу - добавляем в начало
        }
        return linkedList;
    }

    public static List<Integer> fillArrayListMedium(int size) {
        List<Integer> arrayList = new ArrayList<>();

        for (int i = 0; i < size; i++) {
            // arrayList.add(0, i);
            arrayList.add(arrayList.size()/2, i);  // по индуксу - добавляем в начало
        }
        return arrayList;
    }

    public static List<Integer> fillLinkedListMedium(int size) {
        List<Integer> linkedList = new LinkedList<>();

        for (int i = 0; i < size; i++) {
            // arrayList.add(0, i);
            linkedList.add(linkedList.size()/2, i);  // по индуксу - добавляем в начало
        }
        return linkedList;
    }

}


