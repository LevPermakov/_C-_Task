package Seminar_5;

// Подсчет повторяющихся имен HashMap

// Вы работаете с приложением для учета имен пользователей. 
// Ваша задача - разработать программу, 
// которая принимает на вход пять имен пользователей 
// (или использует имена по умолчанию, если аргументы не предоставлены) 
// и подсчитывает, сколько раз каждое имя встречается.
// Программа должна использовать 
// HashMap для хранения имен и их количества вхождений.
// По завершении, программа выводит результат в 
// виде пар "имя - количество".

// На входе:
// 'Elena'
// 'Elena'
// 'Elena'
// 'Ivan'
// 'Ivan'

// На выходе:
// {Ivan=2, Elena=3}


import java.util.HashMap;
import java.util.Map.Entry;

// Не удаляйте и не меняйте метод Main! 
public class HW_52_Printer {
    public static void main(String[] args) {
        String name1;
        String name2;
        String name3;
        String name4;
        String name5;
        
      
        if (args.length == 0) {
            name1 = "Elena";
            name2 = "Elena";
            name3 = "Elena";
            name4 = "Elena";
            name5 = "Ivan";
        } else {
            name1 = args[0];
            name2 = args[1];
            name3 = args[2];
            name4 = args[3];
            name5 = args[4];
        }      
        NamesCounter namesCounter = new NamesCounter();

        String[] namesAll = new String[5];

        namesAll = namesCounter.addName(name1);
        namesAll = namesCounter.addName(name2);
        namesAll = namesCounter.addName(name3);
        namesAll = namesCounter.addName(name4);
        namesAll = namesCounter.addName(name5);

        // System.out.println(namesAll);
        // System.out.println(namesAll[0]);
        // System.out.println(namesAll[1]);
        // System.out.println(namesAll[2]);
        // System.out.println(namesAll[3]);
        // System.out.println(namesAll[4]);
        // System.out.println();

        namesCounter.showNamesOccurrences(namesAll);
    }
}

class NamesCounter {
    private HashMap<String, Integer> names = new HashMap<>();
    int i = 0;
    //String[] names_ = {"Alice", "Alice", "Alice", "Alice", "Alice"};
    
    //ArrayList<String> list = new ArrayList<>();
    String[] namesKey = new String[5];
    // Метод для добавления имени в HashMap
    public String[] addName(String name) {

        namesKey[i] = name;
        i = i + 1;

        return namesKey;
    }


    // Метод для вывода содержимого HashMap
    public void showNamesOccurrences(String[] namesAll) {
        // Введите свое решение ниже
        // System.out.println(names);
        // System.out.println(names[0]);
        // System.out.println(names[1]);
        // System.out.println(names[2]);
        // System.out.println(names[3]);
        // System.out.println(names[4]);
        // System.out.println();

        for (String name : namesAll) {
            if (names.containsKey(name)) {
                names.put(name, names.get(name) + 1);
            }
            else{
                names.put(name, 1);
            }
        }
        // Выводим результаты
        // i = 0;
        // int j = names.size();
        
        // System.out.println();
        // System.out.print("{");

        // for (Entry<String, Integer> entry : names.entrySet()) {
        //     if (i < j - 1) {
        //         System.out.print(entry.getKey() + "=" + entry.getValue() + ", ");
        //         i = i + 1;
        //     }
        //     else {
        //         System.out.print(entry.getKey() + "=" + entry.getValue());
        //     }
        // }
        // System.out.print("}");
        System.out.println(names);
    }
}

// Эталонное решение
// import java.util.HashMap;

// class NamesCounter {
//     private HashMap<String, Integer> names = new HashMap<>();

//     // Метод для добавления имени в HashMap
//     public void addName(String name) {
//         if (names.containsKey(name)) {
//             names.put(name, names.get(name) + 1);
//         } else {
//             names.put(name, 1);
//         }
//     }

//     // Метод для вывода содержимого HashMap
//     public void showNamesOccurrences() {
//         System.out.println(names);
//     }
// }

// public class Printer {
//     public static void main(String[] args) {
//         String name1;
//         String name2;
//         String name3;
//         String name4;
//         String name5;

//         if (args.length == 0) {
//             name1 = "Elena";
//             name2 = "Elena";
//             name3 = "Elena";
//             name4 = "Elena";
//             name5 = "Ivan";
//         } else {
//             name1 = args[0];
//             name2 = args[1];
//             name3 = args[2];
//             name4 = args[3];
//             name5 = args[4];
//         }      
//         NamesCounter namesCounter = new NamesCounter();

//         namesCounter.addName(name1);
//         namesCounter.addName(name2);
//         namesCounter.addName(name3);
//         namesCounter.addName(name4);

//         namesCounter.addName(name5);

//         namesCounter.showNamesOccurrences();
//     }
// }