package Seminar_4;

import java.util.LinkedList;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class HW_42_Printer {
    public static void main(String[] args) {
        MyQueue<Integer> queue;
        queue = new MyQueue<>();

        if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
            queue.enqueue(1);
            queue.enqueue(10);
            queue.enqueue(15);
            queue.enqueue(5);
        } else {
            queue.enqueue(Integer.parseInt(args[0]));
            queue.enqueue(Integer.parseInt(args[1]));
            queue.enqueue(Integer.parseInt(args[2]));
            queue.enqueue(Integer.parseInt(args[3]));
        }

        System.out.println(queue.getElements());

        queue.dequeue();
        queue.dequeue();
        System.out.println(queue.getElements());

        System.out.println(queue.first());
    }
}

class MyQueue<T> {
 //   LinkedList<T> queue;
    LinkedList<T> queue;
    // Напишите свое решение ниже
//   queue = new LinkedList<T>;

    //elements = new LinkedList();

    public MyQueue() {
    // // Напишите свое решение ниже
    ///LinkedList<T> queue;
    queue = new LinkedList<>();
//    LinkedList<T> queue;
   }


    public void enqueue(T element) { // помещает элемент в конец очереди
        
        // Напишите свое решение ниже
        queue.addLast(element);
    }

    public Object dequeue() { // возвращает первый элемент из очереди и удаляет его
        // Напишите свое решение ниже
        return queue.removeFirst();
    }

    public Object first() {       // возвращает первый элемент из очереди и не удаляет его
        // Напишите свое решение ниже
        return queue.getFirst();
    }

    public LinkedList<T> getElements() {
        // Напишите свое решение ниже
        return queue;
    }

}


// Эталонное решение
// import java.util.LinkedList;

// class MyQueueInt {
//     private LinkedList<Integer> elements = new LinkedList<>();

//     public void enqueue(int element) {
//         elements.add(element);
//     }

//     public int dequeue() {
//         return elements.removeFirst();
//     }

//     public int first() {
//         return elements.getFirst();
//     }

//     public LinkedList<Integer> getElements() {
//         return elements;
//     }
// }

// // Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
// public class Printer {
//     public static void main(String[] args) {
//         MyQueueInt queue;
//         queue = new MyQueueInt();

//         if (args.length == 0) {
//         // При отправке кода на Выполнение, вы можете варьировать эти параметры
//             queue.enqueue(1);
//             queue.enqueue(10);
//             queue.enqueue(15);
//             queue.enqueue(5);
//         } else {
//             queue.enqueue(Integer.parseInt(args[0]));
//             queue.enqueue(Integer.parseInt(args[1]));
//             queue.enqueue(Integer.parseInt(args[2]));
//             queue.enqueue(Integer.parseInt(args[3]));
//         }

//         System.out.println(queue.getElements());

//         queue.dequeue();
//         queue.dequeue();
//         System.out.println(queue.getElements());

//         System.out.println(queue.first());
//     }
// }