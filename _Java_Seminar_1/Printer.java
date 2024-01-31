package Seminar_1;

//  import java.util.Scanner;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer {
    public static void main(String[] args) {
        int a = 0;
        char op = '*';
        int b = 0;

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            a = 14;
            op = '/';
            b = 2;
        } else {
            a = Integer.parseInt(args[0]);
            op = args[1].charAt(0);
            b = Integer.parseInt(args[2]);
        }

        if (op == '+' | op == '-' | op == '*' | op == '/') {
            if (op == '/' & b == 0) {
                b = -a;
                System.out.println("Ошибка! Деление на ноль.");
            }
            Calculator calculator = new Calculator();
            float result = calculator.calculate(op, a, b);
            System.out.println(result);
        }
        else {
        System.out.printf("Некорректный оператор: %s", op);
        }
    }
}

class Calculator {
    public int calculate(char op, int a, int b) {
        // Введите свое решение ниже
        // double num1;
        // double num2;
        int res = 0;
        //String ans;
        // boolean flag = true;
        // char op;
        // Scanner reader = new Scanner(System.in);
        // System.out.print("Введите первое число: ");
        // num1 = reader.nextDouble();
        // System.out.print("Введите второе число: ");
        // num2 = reader.nextDouble();
        // System.out.print("\nВведите оператор (+, -, *, /): ");
        // op = reader.next().charAt(0);
        switch (op) {
            case '+':
                res = a + b;
                break;
            case '-':
                res = a - b;
                break;
            case '*':
                res = a * b;
                break;
            case '/':
                res = a / b;
                break;
            default:
                // System.out.printf("Некорректный оператор: %s", op);
                // ans = ("Некорректный оператор: " + op);
                break;
        }
        // System.out.print("\nРезультат:\n");
        // System.out.printf(s + " " + op + " " + b + " = " + ans);
        // int value = (int) doubleValue;
        return(res);
    }
    // int res = 0;
    // public int summa_2_int(char op, int a, int b) {
    //     res = a + b;
}


// // Эталонное решение
// class Calculator {
//     public double calculate(char op, int a, int b) {
//         // Введите свое решение ниже
//         double result = 0;
//         switch (op) {
//             case '+':
//                 result = add(a, b);
//                 break;
//             case '-':
//                 result = minus(a, b);
//                 break;
//             case '*':
//                 result = mult(a, b);
//                 break;
//             case '/':
//                 result = divide(a, b);
//                 break;
//         }
//         return result;
//     }

//     private double divide(int a, int b) {
//         if (b != 0)
//             return (double) a / b;
//         return -1;
//     }

//     private int mult(int a, int b) {
//         return a * b;
//     }

//     private int minus(int a, int b) {
//         return a - b;
//     }

//     private int add(int a, int b) {
//         return a + b;
//     }
// }

// // Не удаляйте этот класс!
// // Он нужен для вывода результатов на экран и проверки
// public class Printer {
//     public static void main(String[] args) {
//         int a = 0;
//         char op = ' ';
//         int b = 0;

//         if (args.length == 0) {
//             // При отправке кода на Выполнение, вы можете варьировать эти параметры
//             a = 7;
//             op = '+';
//             b = 3;
//         } else {
//             a = Integer.parseInt(args[0]);
//             op = args[1].charAt(0);
//             b = Integer.parseInt(args[2]);
//         }

//         // Ниже добавить проверку оператора на корректность
//         if (op != '+' && op != '-' && op != '*' && op != '/') {
//             System.out.println("Некорректный оператор: " + op);
//             return;
//         }

//         Calculator calculator = new Calculator();
//         double result = calculator.calculate(op, a, b);
//         System.out.println(result);
//     }
// }