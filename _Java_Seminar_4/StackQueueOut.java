package Seminar_4;

import java.util.LinkedList;
import java.util.Queue;

// Задание №3
// 1) Написать метод, который принимает массив элементов, помещает их в стэк 
// и выводит на консоль содержимое стэка.
// 2) Написать метод, который принимает массив элементов, помещает их в 
// очередь и выводит на консоль содержимое очереди.


import java.util.Stack;

public class StackQueueOut {
    public static void main(String[] args) {
        int [] array = {34, 65, 23, 3, 98, 2, -5, 878};

        Stack<Integer> stack = new Stack<>();
        for (int elem : array) {
            stack.push(elem);
        }

        // System.out.println(stack);       // печатает некорректно (как стек)
        while (!stack.isEmpty()) {
            System.out.print(stack.pop() + " ");
        }
        System.out.println();


        Queue<Integer> queue = new LinkedList<>();
        for (int elem : array) {
            queue.add(elem);
        }

        System.out.println(queue);     

    }

}
