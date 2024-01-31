package Seminar_5;

// Задание №0
// Создать структуру для хранения Номеров паспортов и Фамилий
// сотрудников организации.
// 123456 Иванов
// 321456 Васильев
// 234561 Петрова
// 234432 Иванов
// 654321 Петрова
// 345678 Иванов
// Вывести данные по сотрудникам с фамилией Иванов.

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.TreeMap;

public class PassportName {
    public static void main(String[] args) {
        // HashMap<Integer, String> hashMap = new HashMap<>();
        // hashMap.put(123456, "Иванов");
        // hashMap.put(234432, "Иванов");
        // hashMap.put(345678, "Иванов");
        // hashMap.put(321456, "Васильев");
        // hashMap.put(234561, "Петрова");
        // hashMap.put(654321, "Петрова");

        // String targetName = "Иванов";

        // for (Integer passpotNumber : hashMap.keySet()) {
        //     String name = hashMap.get(passpotNumber);
        //     if (name.equals(targetName)){
        //         System.out.println("Номер паспорта: " + passpotNumber + ",  Фамилия: " + name);
        //     }
                // Не Сохранен порядок сохранения ключей
        // }

        // LinkedHashMap<Integer, String> hashMap = new LinkedHashMap<>();
        // hashMap.put(123456, "Иванов");
        // hashMap.put(234432, "Иванов");
        // hashMap.put(345678, "Иванов");
        // hashMap.put(321456, "Васильев");
        // hashMap.put(234561, "Петрова");
        // hashMap.put(654321, "Петрова");

        // String targetName = "Иванов";

        // for (Integer passpotNumber : hashMap.keySet()) {
        //     String name = hashMap.get(passpotNumber);
        //     //if (name.equals(targetName)){
        //         System.out.println("Номер паспорта: " + passpotNumber + ",  Фамилия: " + name);
        //     //}
        //     // Сохранен порядок сохранения ключей
        // }

        TreeMap<Integer, String> hashMap = new TreeMap<>();
        hashMap.put(123456, "Иванов");
        hashMap.put(234432, "Иванов");
        hashMap.put(345678, "Иванов");
        hashMap.put(321456, "Васильев");
        hashMap.put(234561, "Петрова");
        hashMap.put(654321, "Петрова");

        String targetName = "Иванов";

        for (Integer passpotNumber : hashMap.keySet()) {
            String name = hashMap.get(passpotNumber);
            //if (name.equals(targetName)){
                System.out.println("Номер паспорта: " + passpotNumber + ",  Фамилия: " + name);
            //}
            // Порядок -  по возрастанию Ключей (отсортировано)
        }

    }
}
