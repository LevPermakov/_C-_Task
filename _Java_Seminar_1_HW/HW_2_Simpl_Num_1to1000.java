package Seminar_1;

// Вывести все простые числа от 1 до 1000 

import java.io.*;
import java.util.*;

public class HW_2_Simpl_Num_1to1000 {
    public static void main(String[] args) {
        // System.out.println("Введите положительное число: ");
        // Scanner in = new Scanner(System.in);
        // int input = in.nextInt();
        int input = 1000;
        boolean b = true;
        for (int P = 2; P <= input; P++) {
            for (int i = 2; i < P; i++) {
                if (P % i == 0) {
                    b = false;
                    break;
                }
            }
            if (b) System.out.println(P);
            else b = true;
        }
    } 
}

// Эталонное решение
// class Answer {
//        public static void printPrimeNums() {
//         // Напишите свое решение ниже

//         // Проход начинается с 2, т.к. это число является наименьшим простым
//         for (int i = 2; i <= 1000; i++) {

//             boolean isPrime = true;

//             // Проверка, является ли число i простым
//             // Проход по циклу до корня числа,
//             // т.к. дальше нет смысла искать, делителей нет.
//             for (int j = 2; j <= Math.sqrt(i); j++) {
//                 if (i % j == 0) {
//                     isPrime = false;
//                     break;
//                 }
//             }
//             // Если число i простое, вывод его на экран
//             if (isPrime)
//                 System.out.println(i);
//         }
//     }
// }

// public class Printer{ 
//     public static void main(String[] args) { 

//       Answer ans = new Answer();      
//       ans.printPrimeNums();
//     }
// }