package Seminar_1;

// Задание №2
// Дан массив двоичных чисел, например [1,1,0,1,1,1], вывести
// максимальное количество подряд идущих 1.

public class MaxCountOnes {
    public static void main(String[] args) {
        int countMax = getCountMax();
        System.out.println(countMax);
    }

    private static int getCountMax() {
        int[] nums = {1, 1, 0, 1, 1, 1, 0, 1, 1, 1,1,1,1, 0};
        int count = 0;
        int countMax = 0;
        for (int num : nums) {
            if (num == 1) {
                count++;
                // countMax = countMax > count ? countMax : count;  // тернарный оператор
                countMax = Math.max(countMax, count);
            }
            else {
                count = 0;
            }
        }
        return countMax;
    }
}
