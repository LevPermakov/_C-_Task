package Seminar_6;

// ДЗ 

// Подумать над структурой класса Ноутбук для магазина техники - выделить поля и методы. Реализовать в java. 
// Создать множество ноутбуков. 
// Написать метод, который будет запрашивать у пользователя критерий (или критерии) фильтрации и выведет ноутбуки, отвечающие фильтру. 
// Критерии фильтрации можно хранить в Map. 
// Например: 
// “Введите цифру, соответствующую необходимому критерию: 
// 1 - ОЗУ        
// 2 - Объем ЖД 
// 3 - Операционная система 
// 4 - Цвет … 
// Далее нужно запросить минимальные значения для указанных критериев – 
// сохранить параметры фильтрации можно также в Map. 
// Отфильтровать ноутбуки их первоначального множества и 
// вывести проходящие по условиям.

import java.util.Arrays;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.stream.Collectors;

public class MainLaptop {
    public static void main(String[] args) {
        // Экземпляры Классов
        Laptop laptop1 = new Laptop("hp", "Pavilion", "blacke", 60_000, "Windows", 8, 256);
        Laptop laptop2 = new Laptop("Asus", "Asus_1", "Grey", 50_0000, "Windows", 6, 300);
        Laptop laptop3 = new Laptop("Lenovo", "Lenovo_1", "white", 90_0000, "Windows", 16, 512);
        Laptop laptop4 = new Laptop("Apple", "Apple_1", "Silver", 120_0000, "MacOs", 32, 1024);
        Laptop laptop5 = new Laptop("Lenovo", "Lenovo_1", "white", 90_0000, "Windows", 16, 512); // Дубль 1
        Laptop laptop6 = new Laptop("Apple", "Apple_1", "Silver", 120_0000, "MacOs", 8, 1024);   // Дубль 2

        // set.add(new Laptop("hp", "Pavilion", "Grey", 100_00, "Windows", 16, 512));

        Set<Laptop> laptops = new HashSet<>(Arrays.asList(laptop1, laptop2, laptop3, laptop4, laptop5, laptop6));

        // System.out.println(laptops);

        // -------------------------------------------
        // System.out.println("Все модели: ");
        // System.out.println(laptop1);
        // System.out.println(laptop2);
        // System.out.println(laptop3);
        // System.out.println(laptop4);
        // System.out.println(laptop5);
        // System.out.println(laptop6);
        // System.out.println();

        // System.out.println("Модели без дублей (с hash-фильтром): ");
        // for (Laptop note : laptops) {
        // System.out.println(note);
        // }
        // -----------------------------------------------

        Map<String, Object> filters = new HashMap<>();

        Scanner scanner = new Scanner(System.in);

        System.out.println("Выберите критерии для фильтрации:");
        System.out.println("1 - ОЗУ");
        System.out.println("2 - Объем HHD");
        System.out.println("3 - Операционная система");
        System.out.println("4 - Цвет");
        System.out.println("0 - Завершить выбор. По умолчанию: ОЗУ: от 6; HDD: от 256; Цвет: white; ОС: 'Windows'");

        int choice;
        while (true) {
            choice = scanner.nextInt();
            if (choice == 0) {
                break;
            }
            switch (choice) {
                case 1:
                    System.out.print("Минимальный объем ОЗУ (6 - 32): ");
                    filters.put("ram", scanner.nextInt());
                    System.out.println("Продолжите выбор. ");
                    break;
                case 2:
                    System.out.print("Минимальный объем HDD (256 - 1024): ");
                    filters.put("hdd", scanner.nextInt());
                    System.out.println("Продолжите выбор. ");
                    break;
                case 3:
                    System.out.print("Операционная система (Windows/MacOs): ");
                    filters.put("os", scanner.next());
                    System.out.println("Продолжите выбор. ");
                    break;
                case 4:
                    System.out.print("Цвет: ");
                    filters.put("color", scanner.next());
                    System.out.println("Продолжите выбор. ");
                    break;
                default:
                    System.out.println("Неверный выбор. Попробуйте снова.");
            }
        }
        // System.out.println(filters);
        Set<Laptop> filteredLaptops = laptops.stream()
                .filter(laptop -> laptop.getAmountRAM() >= (int) filters.getOrDefault("ram", 6))
                .filter(laptop -> laptop.getHdd() >= (int) filters.getOrDefault("hdd", 256))
                .filter(laptop -> laptop.getOs().equalsIgnoreCase((String) filters.getOrDefault("os", "Windows")))
                .filter(laptop -> laptop.getColor().equalsIgnoreCase((String) filters.getOrDefault("color", "white")))
                .collect(Collectors.toSet());

        // System.out.println(laptops);
        // -----------------------------------------------
        System.out.println("Выбранные Ноутбуки:");
        for (Laptop note : filteredLaptops) {
            System.out.println(note);
        }
        // -----------------------------------------------
    }
}
