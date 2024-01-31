package Seminar_5;

import java.util.HashMap;

// Задание №2
// Написать программу, определяющую правильность расстановки скобок в выражении.
// Пример 1: a+(d*3) - истина
// Пример 2: [a+(1*3) - ложь
// Пример 3: [6+(3*3)] - истина
// Пример 4: {a}[+]{(d*3)} - истина
// Пример 5: <{a}+{(d*3)}> - истина
// Пример 6: {a+]}{(d*3)} - ложь

import java.util.Map;
import java.util.Stack;
import java.util.HashMap;

public class CheckBrackets {
    public static void main(String[] args) {
        String[] strings = {"a+(d*3)", "[a+(1*3)", "[6+(3*3)]", "{a}[+]{(d*3)}", "<{a}+{(d*3)}>", "{a+]}{(d*3)}" };
        for (String string : strings) {
            boolean result = CheckBrackets(string);
            System.out.println(string + " -> " + result);
        }
    }

    public static Map<Character, Character> getBracketsMap() {
        Map<Character, Character> breckets = new HashMap<>();
        breckets.put(')', '(');
        breckets.put(']', '[');
        breckets.put('}', '{');
        breckets.put('>', '<');
        return breckets;
    }

    public static boolean CheckBrackets(String text) {
        Map<Character, Character> brekets = getBracketsMap();
        Stack <Character> stack = new Stack<>();
        for (char c : text.toCharArray()) {
            if (brekets.containsValue(c)) {
                stack.push(c);
            } else if (brekets.containsKey(c)) { // если "закрывающаяся" скобка
                // то в стеке должна лежать, соответствующая ей, "открывающая" скобка
                // таково же типа
                if (stack.isEmpty() || stack.pop() != brekets.get(c)) {
                    return false;
                }
            }
        }
        // в стеке може оказаться еще "открывающая" скобка
        // вернуть проверку на пустоту еще раз
        return stack.isEmpty();
    }

}

// Результат:
// a+(d*3) -> true
// [a+(1*3) -> false
// [6+(3*3)] -> true
// {a}[+]{(d*3)} -> true
// <{a}+{(d*3)}> -> true
// {a+]}{(d*3)} -> false
