package Seminar_3;

import java.util.ArrayList;
import java.util.List;

// Задание №4
// Каталог товаров книжного магазина сохранен в виде двумерного
// списка List<ArrayList<String>> так, что на 0й позиции каждого
// внутреннего списка содержится название жанра, а на остальных
// позициях - названия книг. Напишите метод для заполнения данной
// структуры

public class CatalogBooks {
    public static void main(String[] args) {
        List<ArrayList<String>> catalog = new ArrayList<>(); // Список списков
        // List<> - интерфейс, ArrayList<> - реализация

        // Списки по жанрам
        ArrayList<String> ganre1 = new ArrayList<>();
        ganre1.add("1");
        ganre1.add("Книга1");
        ganre1.add("Книга2");   
        ganre1.add("Книга3");

        ArrayList<String> ganre2 = new ArrayList<>();
        ganre2.add("Жанр2");
        ganre2.add("Книга1");
        ganre2.add("Книга2");   
        ganre2.add("Книга3");

        ArrayList<String> ganre3 = new ArrayList<>();
        ganre3.add("Жанр3");
        ganre3.add("Книга1");
        ganre3.add("Книга2");   
        ganre3.add("Книга3");

        catalog.add(ganre1);
        catalog.add(ganre2);
        catalog.add(ganre3);

        System.out.println(catalog);
        // [[Жанр1, Книга1, Книга2, Книга3], [Жанр2, Книга1, Книга2, Книга3], [Жанр3, Книга1, Книга2, Книга3]]

    }
}
