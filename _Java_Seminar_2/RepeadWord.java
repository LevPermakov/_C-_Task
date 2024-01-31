package Seminar_2;

import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDateTime;

// Задание №4
// Напишите метод, который составит строку, состоящую из 100 
// повторений слова TEST и метод, который запишет эту строку в 
// простой текстовый файл, обработайте исключения.

// Задание №5
// Напишите метод, который вернет содержимое текущей папки в виде 
// массива строк. 
// Напишите метод, который запишет массив, возвращенный предыдущим 
// методом в файл. 
// Обработайте ошибки с помощью try-catch конструкции. В случае 
// возникновения исключения, оно должно записаться в лог-файл

public class RepeadWord {
    public static void main(String[] args) {
        String repeatString = getRepeatWord("TEST", 100);
        System.err.println(repeatString);
        writeToFile(repeatString, "repeatWord.txt");
    }

    public static String getRepeatWord(String str, int repeat) {
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < repeat; i++) {
            sBuilder.append(str);
        }
        return sBuilder.toString();
    }

    public static void writeToFile(String str, String fileName) { 
        try (FileWriter fWriter = new FileWriter(fileName)) {
            fWriter.write(str);
            //fWriter.close();
            writeToLogFile("Данные успешно записаны в файл.", "log.txt");
        
        } catch (IOException e) {
            writeToLogFile("Ошибка записи в файл.", "log.txt");
        }

    }

    public static void writeToLogFile(String msg, String fileName) {   // msg - текст ошибки
        try (FileWriter fWriter = new FileWriter(fileName)) {
           LocalDateTime dateTime = LocalDateTime.now();
           fWriter.write(dateTime.toString());
           fWriter.write(System.lineSeparator());
           fWriter.write(msg);

        } catch (IOException e) {
            System.err.println("Ошибка записи в файл.");
        }

    }

}
