package Seminar_3;

// import java.util.Arrays;
// import java.util.HashSet;
// import java.util.ArrayList;
// import java.util.Iterator;
// import java.util.List;
// import java.util.Random;
// import java.util.stream.Stream;

// Дан произвольный массив целых чисел. Создайте список ArrayList, 
// заполненный данными из этого массива. 
// Необходимо удалить из списка четные числа и вернуть результирующий.

// Напишите свой код в методе removeEvenNumbers класса Answer. 
// Метод removeEvenNumbers принимает на вход один параметр: 
// Integer[] arr - список целых чисел, 
// возвращает список ArrayList<Integer>

import java.util.Arrays;
import java.util.ArrayList;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class EvenInt_Printer{ 
    public static void main(String[] args) { 
      Integer[] arr = {};
      
      if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
        arr = new Integer[]{1, 2, 3, 4, 5, 6, 7, 8, 9};
        // arr = new Integer[]{2, 4, 6, 8};
      }
      else{
        arr = Arrays.stream(args[0].split(", "))
                        .map(Integer::parseInt)
                        .toArray(Integer[]::new);
      }     
      
      Answer ans = new Answer();      
      ans.removeEvenNumbers(arr);
    }
}

class Answer {
    public static void removeEvenNumbers(Integer[] arr) {
      // Введите свое решение ниже
      ArrayList <Integer> numbers = new ArrayList<>();
        int number = 0;
        for (int i = 0; i < arr.length; i++) {
            number = arr[i];
            if (number % 2 != 0) {
                numbers.add(number);
            }
        }
         PrintArray(numbers);
    }

    public static void PrintArray(ArrayList<Integer> arr){ //Печать списка
        System.out.println();
        System.out.print('[');
        int flag = 0;
        for(int element: arr) {
          if (flag != 0) {
            System.out.print(',');
          }
          // System.out.printf("Привет, %s!", name); 
          if (flag == 0) {
            System.out.print(element );
            flag = 1;
          }
            else {
              System.out.print(" " + element );
            }
        }
        System.out.println(']');
        System.out.println();
    }

    public static void DeleteEvenNumber(ArrayList<Integer> list) {
        int i = 0;
        while (i < list.size()) {
            if (list.get(i) % 2 == 0)
                list.remove(i);
            else
                i++;
        }
    }

}

// Эталонное решение
// import java.util.Arrays;
// import java.util.ArrayList;

// class Answer {
//     public static ArrayList<Integer> removeEvenNumbers(Integer[] arr) {
//       // Введите свое решение ниже
//       ArrayList<Integer> nums = new ArrayList<>(Arrays.asList(arr));
//         for (int i = 0; i < nums.size(); i++) {
//             if (nums.get(i) % 2 == 0) {
//                 nums.remove(i);
//                 i--;
//             }
//         }
//         return nums;
//     }
// }

// // Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
// public class Printer{ 
//     public static void main(String[] args) { 
//       Integer[] arr = {};

//       if (args.length == 0) {
//         // При отправке кода на Выполнение, вы можете варьировать эти параметры
//         arr = new Integer[]{1, 2, 3, 4, 5, 6, 7, 8, 9};
//       }
//       else{
//         arr = Arrays.stream(args[0].split(", "))
//                         .map(Integer::parseInt)
//                         .toArray(Integer[]::new);
//       }     

//       Answer ans = new Answer();      
//       ArrayList<Integer> nums = ans.removeEvenNumbers(arr);
//       System.out.println(nums);
//     }
// }