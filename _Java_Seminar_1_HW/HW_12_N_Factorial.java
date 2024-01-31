package Seminar_1;

// Вычислить n! (произведение чисел от 1 до n) 

import java.io.*;
import java.util.*;

public class HW_12_N_Factorial {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int result = 0;
        System.out.print("Введите число n: ");
        int value = scan.nextInt();
        for (int i = 1; i <= value; i++) {
            result += i;
        }
        System.out.println(result);
    
    }
}
