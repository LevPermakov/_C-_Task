package Seminar_1;

// Задание №3
// Дан массив nums = [3,2,2,3] и число val = 3.
// Если в массиве есть числа, равные заданному, нужно перенести
// эти элементы в конец массива.

import java.util.Scanner;
import java.util.Arrays;

public class MoveNumToEnd {
    public static void main(String[] args) {
        
    int[] nums = {3, 2, 2, 3, 5, 8, 8, 3};
    int value = 2;
    moveToEnd(nums, value);
    System.out.println(Arrays.toString(nums)); 

    }

    private static void moveToEnd(int[] nums, int value) {
        int leftIndex = 0;
        int rightIndex = nums.length -1;

        while (leftIndex < rightIndex) {
            while (nums[rightIndex] == value && rightIndex > leftIndex) {
                rightIndex--;
            }
            if (nums[leftIndex] == value ) {
                int temp = nums[leftIndex];
                nums[leftIndex] = nums[rightIndex];
                nums[rightIndex] = temp;
            }
            leftIndex++;
        }
    }
}       