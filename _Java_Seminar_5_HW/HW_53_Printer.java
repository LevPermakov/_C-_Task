package Seminar_5;

// Сортировка массива с использованием кучи (Heap Sort), использовать buildTree, heapSort

// Необходимо разработать программу для сортировки массива целых чисел 
// с использованием сортировки кучей (Heap Sort). 
// Программа должна работать следующим образом:
// Принимать на вход массив целых чисел для сортировки. 
// Если массив не предоставлен, программа использует массив по умолчанию.
// Сначала выводить исходный массив на экран.
// Затем применять сортировку кучей (Heap Sort) 
// для сортировки элементов массива в порядке возрастания.

// Выводить отсортированный массив на экран.
// Ваше решение должно содержать два основных метода: 
// buildTree, который строит сортирующее дерево на основе массива, 
// и heapSort, который выполняет собственно сортировку кучей.

// Программа должна быть способной сортировать массив, 
// даже если он состоит из отрицательных чисел и имеет дубликаты.

// На входе:
// '5 8 12 3 6 9'

// На выходе:
// Initial array:
// [5, 8, 12, 3, 6, 9]
// Sorted array:
// [3, 5, 6, 8, 9, 12]



import java.util.Arrays;


// Не удаляйте и не меняйте метод Main! 
public class HW_53_Printer {
    public static void main(String[] args) {
        int[] initArray;

        if (args.length == 0) {
            initArray = new int[]{17, 32, 1, 4, 25, 17, 0, 3, 10, 7, 64, 1};
        } else {
            initArray = Arrays.stream(args[0].split(" ")).mapToInt(Integer::parseInt).toArray();
        }

        System.out.println("Initial array:");
        System.out.println(Arrays.toString(initArray));
        HeapSort.heapSort(initArray, initArray.length);
        System.out.println("Sorted array:");
        System.out.println(Arrays.toString(initArray));
    }
}

class HeapSort {
    public static void buildTree(int[] tree, int sortLength) {
           // Введите свое решение ниже
           int n = sortLength;
           // Построение кучи (Heapify) - устанавливать пирамидальный порядок
           for (int i = n / 2 -1; i >= 0; i--) {
            heapify(tree, n, i);
           }
    }

    private static void heapify(int[] arr, int n, int i) {
        int largest = i;  // Наибольший элемент как корень 
        // (предполагается, что largest это индекс текущего узла)
        int leftChild = 2 * i + 1;  // Левый дочерний элемент
        int rightChild = 2 * i + 2; // Правый дочерний элемент

        // Если левый дочерний элемент болше корня
        if (leftChild < n && arr[leftChild] > arr[largest]) {
            largest = leftChild;
        }

        // Если правый дочерний элемент больше, 
        // чем наиболший элемент на данный момент
        if (rightChild < n && arr[rightChild] > arr[largest]) {
            largest = rightChild;
        }

        // Если наимбольший элемент не является корнем
        if (largest != i) {
            // Поменять значения
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            // Рекурсивно опустить элемент для узла, который был изменет
            heapify(arr, n, largest);
        }
    }

    public static void heapSort(int[] sortArray, int sortLength) {
        // Введите свое решение ниже
        int n = sortLength;
        // Построение кучи (Heapify)
        buildTree(sortArray, sortLength);
        // Извлечение по одному элементу из кучи
        for (int i = n - 1; i >= 0; i--) {
            // Перемещаем текущий корень в конец
            int temp = sortArray[0];
            sortArray[0] = sortArray[i];
            sortArray[i] = temp;
            // Перестраиваем кучу
            heapify(sortArray, i, 0);
        }
    }
}


// Эталонное решение
// import java.util.Arrays;

// class HeapSort {
//     public static void buildTree(int[] tree, int sortLength) {
//         // Для всех вершин дерева начиная с середины сортируемой части массива
//         // (движемся влево до нулевого индекса)
//         for (int i = sortLength / 2 - 1; i >= 0; i--) {
//             int maxIndex;
//             // Если у вершины два листа, выбираем больший
//             if (i * 2 + 2 <= sortLength - 1) {
//                 if (tree[i * 2 + 2] > tree[i * 2 + 1]) maxIndex = i * 2 + 2;
//                 else maxIndex = i * 2 + 1;
//             // Иначе один лист
//             } else maxIndex = i * 2 + 1;
//             // Сравниваем лист с максимальным значением с вершиной, при большем значении
//             // дочернего элемента меняем его местами с вершиной
//             if (tree[i] < tree[maxIndex]) {
//                 int temp = tree[i];
//                 tree[i] = tree[maxIndex];
//                 tree[maxIndex] = temp;
//             }
//         }
//     }

//     public static void heapSort(int[] sortArray, int sortLength) {
//         // Выход из рекурсии: длина сортируемой части равна 0
//         if (sortLength == 0) return;
//         // Выстраивание элементов части массива в виде сортирующего дерева
//         buildTree(sortArray, sortLength);
//         // Замена местами первого и последнего элемента в сортируемой части
//         int temp = sortArray[0];
//         sortArray[0] = sortArray[sortLength - 1];
//         sortArray[sortLength - 1] = temp;
//         // Рекурсивно построение дерева и замена элементов для n - 1 элементов массива
//         heapSort(sortArray, sortLength - 1);
//     }
// }

// public class Printer {
//     public static void main(String[] args) {
//         int[] initArray;

//         if (args.length == 0) {
//             initArray = new int[]{17, 32, 1, 4, 25, 17, 0, 3, 10, 7, 64, 1};
//         } else {
//             initArray = Arrays.stream(args[0].split(" ")).mapToInt(Integer::parseInt).toArray();
//         }

//         System.out.println("Initial array:");
//         System.out.println(Arrays.toString(initArray));
//         HeapSort.heapSort(initArray, initArray.length);
//         System.out.println("Sorted array:");
//         System.out.println(Arrays.toString(initArray));
//     }
// }

