// Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.
// Напишите свой код в методе sort класса BubbleSort. Метод sort принимает на вход один параметр:

// int[] arr - числовой массив

// После каждого прохода по массиву ваш код должен делать запись в лог-файл 'log.txt' в формате год-месяц-день час:минуты 
// {массив на данной итерации}. Для логирования использовать логгер logger класса BubbleSort.

// arr = new int[]{9, 4, 8, 3, 1};
// sort(arr)

// // При чтении лог-файла получим:
// 2023-05-19 07:53 [4, 8, 3, 1, 9]
// 2023-05-19 07:53 [4, 3, 1, 8, 9]
// 2023-05-19 07:53 [3, 1, 4, 8, 9]
// 2023-05-19 07:53 [1, 3, 4, 8, 9]
// 2023-05-19 07:53 [1, 3, 4, 8, 9]

import java.io.File;
import java.io.FileWriter;
import java.io.FileReader;
import java.io.BufferedReader;
import java.io.IOException;
import java.util.Arrays;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.io.PrintWriter;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class BubbleSort_Printer {
  public static void main(String[] args) {
    int[] arr = {};

    if (args.length == 0) {
      // При отправке кода на Выполнение, вы можете варьировать эти параметры
      arr = new int[] { 9, 4, 8, 3, 1 };
      // arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      // arr = new int[] {9, 3, 4, 8, 2, 5, 7, 1, 6, 10};
      

    } else {
      arr = Arrays.stream(args[0].split(", "))
          .mapToInt(Integer::parseInt)
          .toArray();
    }

    BubbleSort ans = new BubbleSort();
    ans.sort(arr);

    try (BufferedReader br = new BufferedReader(new FileReader("log.txt"))) {
      String line;
      while ((line = br.readLine()) != null) {
        System.out.println(line);
      }
    } catch (IOException e) {
      e.printStackTrace();
    }
  }
}

class BubbleSort {
  private static File log;
  private static FileWriter fileWriter;

  public static void sort(int[] mas) {
    int n = mas.length;
    DateTimeFormatter dtf = DateTimeFormatter.ofPattern("YYYY-MM-DD HH:mm");
    try (PrintWriter writer = new PrintWriter(new FileWriter("log.txt"))) { // открываем файл для записи
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n - i - 1; j++) {
          if (mas[j] > mas[j + 1]) {
            int temp = mas[j];
            mas[j] = mas[j + 1];
            mas[j + 1] = temp;
          } else {
            if (j == n-i-2) {
              n--;
            }
          }
        }
        writer.println(dtf.format(LocalDateTime.now()) + " " + arrayToString(mas)); // записываем текущее состояние
      }
    } catch (IOException e) {
      e.printStackTrace();
    }
  }

  private static String arrayToString(int[] arr) {
    StringBuilder sb = new StringBuilder();
    sb.append("[");
    for (int i = 0; i < arr.length; i++) {
      sb.append(arr[i]);
      if (i != arr.length - 1) {
        sb.append(", ");
      }
    }
    sb.append("]");
    return sb.toString();
  }
}

// //Эталонноке решиние 
// import java.io.IOException;
// import java.util.Arrays;
// import java.util.logging.FileHandler;
// import java.util.logging.Logger;

// class BubbleSort {
//     // Создание логгера с нужным форматом вывода 
//     private static Logger logger = null;

//     static {
//         System.setProperty("java.util.logging.SimpleFormatter.format",
//                 "%1$tF %1$tR %5$s %n");
//         logger = Logger.getLogger(BubbleSort.class.getName());
//     }

//     public void sort(int[] mas) {

//         configureLogger();
//         bubbleSort(mas);
//     }

//     private int[] bubbleSort(int[] mas) {
//         boolean isSorted = false;
//         int buffer;

//         while (!isSorted) {
//             isSorted = true;
//             for (int i = 0; i < mas.length - 1; i++) {
//                 if (mas[i] > mas[i + 1]) {
//                     isSorted = false;

//                     buffer = mas[i];
//                     mas[i] = mas[i + 1];
//                     mas[i + 1] = buffer;
//                 }
//             }
//             logger.info(Arrays.toString(mas));
//         }
//         return mas;
//     }

//     public void configureLogger() {
//         try {
//             FileHandler fileHandler = new FileHandler("log.txt");
//             logger.addHandler(fileHandler);
//         SimpleFormatter formatter = new SimpleFormatter();
//             fileHandler.setFormatter(formatter);
//         } catch (IOException ex) {
//             ex.printStackTrace();
//         }
//     }
// }

// public class Printer {
//     public static void main(String[] args) {
//         int[] arr = {};

//         if (args.length == 0) {
//             arr = new int[] { 9, 4, 8, 3, 1 };
//         } else {
//             arr = Arrays.stream(args[0].split(", "))
//                     .mapToInt(Integer::parseInt)
//                     .toArray();
//         }

//         BubbleSort ans = new BubbleSort();
//         ans.sort(arr);
//     }
// }

// 💡 Поделиться мнением
// 🔥 Заряжено 
// GeekBrains
//  & 
// IT Resume