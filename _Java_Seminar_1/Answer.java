package Seminar_1;

// class Answer {
//     public int countNTriangle(int n) {

//         // Введите свое решение ниже
//         int m = 1;

//         int i = 1;
//         if (n > m) {
//             while (m < n) {
//                 m++;
//                 i += m;
//             }
//         }
//         return (m);
//     }


// // Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
// public class Printer_ {
//     public static void main(String[] args) {
//         int n = 0;

//         if (args.length == 0) {
//             // При отправке кода на Выполнение, вы можете варьировать эти параметры
//             n = 4;
//         } else {
//             n = Integer.parseInt(args[0]);
//         }

//         // Вывод результата на экран
//         Printer_ ans = new Printer_();
//         int itresume_res = ans.countNTriangle(n);
//         System.out.println(itresume_res);
//     }
// } }




// Эталонное решение
// class Answer {
//     public int countNTriangle(int n){
// if (n < 1) return -1;
//     int sum = 0;
//     for(int i = 1; i <= n; i++){
//           sum += i;
//     }
//     return sum;
//     }
// }

// public class Printer{ 
//     public static void main(String[] args) { 
//       int n = 0;

//       if (args.length == 0) {
//         n = 4;
//       }
//       else{
//         n = Integer.parseInt(args[0]);
//       }     

//       Answer ans = new Answer(); 
//       int itresume_res = ans.countNTriangle(n);     
//       System.out.println(itresume_res);
//     }
// }