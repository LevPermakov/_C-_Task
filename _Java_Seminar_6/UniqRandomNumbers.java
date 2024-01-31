package Seminar_6;

// Задание №1
// 1. Напишите метод, который заполнит массив из 
// 1000 элементов случайными цифрами от 0 до 24. 

// 2. Создайте метод, в который передайте заполненный выше массив и с 
// помощью Set вычислите процент уникальных значений в данном массиве и 
// верните его в виде числа с плавающей запятой.

// Для вычисления процента используйте формулу:
// процент уникальных чисел = количество уникальных чисел * 100 / общее 
// количество чисел в массиве.

import java.util.Random;
import java.util.HashSet;


public class UnicRandomNumbers {
    public static void main(String[] args) {
        int size = 100;
        int[] array = new int[size];
        fillArrayRandomNum(array, 100);
        System.out.println(getPercentUniqNum(array));
    }

    public static void fillArrayRandomNum(int[] array, int max) {
        Random rnd = new Random();
        for (int i = 0; i < array.length; i++) {
            array[i] = rnd.nextInt(max);
        }
    }

    public static double getPercentUniqNum(int[] array) {
        HashSet<Integer> uniqNums = new HashSet<>();
        for (int num : array) {
            uniqNums.add(num);
        }  
        double percentUniqNums = (double)uniqNums.size() * 100 / array.length;
        return percentUniqNums;
    }

}

