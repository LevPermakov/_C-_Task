package Seminar_3;

import java.util.ArrayList;

public class Z2 {
    public static void main(String[] args) {
        ArrayList<Integer> array = new ArrayList<>();
        array = FillRandomArray(10);
        PrintArray(array);
        DeleteEvenNumber(array);
        PrintArray(array);
    }

    public static void PrintArray(ArrayList<Integer> arr){ //Печать списка
        for(int element: arr) {
            //System.out.printf(«%d, «, element);
            System.out.print(" " + ", " + element);
        }
        System.out.println();
    }

    public static ArrayList<Integer> FillRandomArray(int n) {  //заполнение списка случайными целыми числами
        ArrayList <Integer> list = new ArrayList<>();
        for(int i = 0; i < n; i++){
            list.add((int)(Math.random()*100));
        }
        return list;

        // Integer[] arr = {};
        // arr = new Integer[]{1, 2, 3, 4, 5, 6, 7, 8, 9};
        // return arr;
    }

    public static void DeleteEvenNumber(ArrayList<Integer> list) {
        int i = 0;
        while (i < list.size()) {
            if (list.get(i) % 2 == 0)
                list.remove(i);
            else
                i++;
        }
    }

}
