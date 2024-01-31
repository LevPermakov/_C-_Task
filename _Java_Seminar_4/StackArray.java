package Seminar_4;
// Задание №4
// Реализовать стэк с помощью массива. 
// Нужно реализовать методы:
// size(), empty(), push(), peek(), pop().

import java.util.Arrays;

public class StackArray {
    static int capacity = 0;  // область глобальных данных
    static int top = -1;      // индекс последнего (верхнего) элемента (начальн.зн.)
    static int[] stackArray;  // значение присвоим в main
    public static void main(String[] args) {
        capacity = 3;        // начальная емкость
        // при превышении емкости - отдельный Метод, кот-й увелич. размеры Стека
        stackArray = new int[capacity];

        System.out.println(size());
        push(78);
        System.out.println(size());
        push(678);
        push(6);
        System.out.println(size());

        System.out.println(pop());
        System.out.println(size());
        
        System.out.println(Arrays.toString(stackArray));
        // стек выводится неправильно - как массив: [78, 678, 6]
        // реализовать отдельным Методом - print

        // pop();
        // System.out.println(size());
        // System.out.println(Arrays.toString(stackArray));

    }

    public static int size() {
        return top + 1;
    }

    public static boolean empty() {
        return top == -1;
    }

    public static void push(int value) {
        stackArray[++top] = value;
    }

    public static int peek() {  // получает эл-нт, но не удаляет его
        return stackArray[top];    // верхний элемент
    }

    public static int pop() {  // получает эл-нт, и удаляет его
                        // из класс-го массива нельзя удалить,
                        // поэт. будет псевдо-удаление -
                        // не удаляем, а смещаем индексы.
        return stackArray[top--];    // верхний элемент
        // сначала возвр. top, потом --
    }

}
