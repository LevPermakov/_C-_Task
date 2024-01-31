package Seminar_1;

// Вычислить n-ое треугольного число(сумма чисел от 1 до n)

import java.io.*;
import java.util.*;

public class HW_11_Sum1toN {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        // int n = scan.nextInt();
        int m = 1;
        System.out.print("Введите число n: ");
        int n = scan.nextInt();
        int i = 1;
        i = (n * (n+1) / 2);
        // if (n > m) {
        //     while (m < n) {
        //         m++;
        //         i += m;
        //     }
            System.out.println(i);
        }

    }


