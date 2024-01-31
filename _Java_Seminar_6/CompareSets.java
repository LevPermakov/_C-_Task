package Seminar_6;

// Задание №0

// 1. Создайте HashSet, заполните его следующими числами: 
// {1, 6, 3, 2, 4, 5, 2, 3}. 
// Распечатайте содержимое данного множества.

// 2. Создайте LinkedHashSet, заполните его следующими числами: 
// {1, 6, 3, 2, 4, 5, 2, 3}. 
// Распечатайте содержимое данного множества.

// 3. Создайте TreeSet, заполните его следующими числами: 
// {1, 2, 3, 2, 4, 5, 6, 3}. 
// Распечатайте содержимое данного множества.

import java.util.Arrays;
import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.TreeSet;


public class CompareSets {
    public static void main(String[] args) {
        // Set<Integer> hashSet = new HashSet<>();
        Set<Integer> hashSet = new HashSet<>(Arrays.asList(3, 6, 43, 8, 11, 7, 33, 3, 4, 8));
        // hashSet.add(2);   // набор Методов
        System.out.println(hashSet);

        Set<Integer> linkedhashSet = new LinkedHashSet<>(Arrays.asList(3, 6, 43, 8, 11, 7, 33, 3, 4, 8));
        System.out.println(linkedhashSet);

        Set<Integer> treeSet = new TreeSet<>(Arrays.asList(3, 6, 43, 8, 11, 7, 33, 3, 4, 8));
        System.out.println(treeSet);

        // [1, 2, 3, 4, 5, 6] - не сохраняет порядок, дубликаты убирает
        // [1, 6, 3, 2, 4, 5] - сохраняет порядок 
        // [1, 2, 3, 4, 5, 6] - сортирует

        //  3, 6, 43, 8, 11, 7, 33, 3, 4, 8   - исходный набор
        // [33, 3, 4, 6, 7, 8, 43, 11]
        // [3, 6, 43, 8, 11, 7, 33, 4]
        // [3, 4, 6, 7, 8, 11, 33, 43]


        
    }
}
