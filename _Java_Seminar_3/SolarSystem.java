package Seminar_3;

// Задание состоит из двух блоков

// Задание №2.1
// Заполнить список названиями планет Солнечной
// системы в произвольном порядке с повторениями.
// Вывести название каждой планеты и количество его
// повторений в списке.

// Задание №2.2 (если выполнено первое задание)
// Пройти по списку из предыдущего задания и удалить
// повторяющиеся элементы.

import java.util.ArrayList;
import java.util.Collections;

public class SolarSystem {
    public static void main(String[] args) {
        ArrayList<String> listPlanet = getPlanetList();
        System.out.println(listPlanet);
        getCountPlanets(listPlanet);
        removeRepiatPlanet(listPlanet);
        System.out.println(listPlanet);
    }

    private static void removeRepiatPlanet(ArrayList<String> listPlanet) {
        for (int i = 0; i < listPlanet.size(); i++) {
            String planet = listPlanet.get(i);
            for (int j = i+1; j < listPlanet.size(); j++) {
                if (listPlanet.get(j).equals(planet)) {
                    listPlanet.remove(j);
                    j--;  // чтобы не было пропусков
                }
            }
        }
    }

    private static void getCountPlanets(ArrayList<String> listPlanet) {
        ArrayList<String> listPlanetSort = new ArrayList<>(listPlanet);
        Collections.sort(listPlanetSort);
        System.out.println(listPlanetSort);
        int count = 0;
        String currentPlanet = listPlanetSort.get(0);
        for (String planet : listPlanetSort) {
            if (planet.equals(currentPlanet))
                count++;
            else {
                System.out.println(currentPlanet + " => " + count);
                count = 1;
                currentPlanet = planet;
            }
        }
        System.out.println(currentPlanet + " => " + count);
    }

    private static ArrayList<String> getPlanetList() {
        ArrayList<String> list = new ArrayList<>();
        list.add("Mercury");
        list.add("Venus");
        list.add("Earth");
        list.add("Mars");
        list.add("Mercury");
        list.add("Mercury");
        list.add("Venus");
        list.add("Neptune");
        list.add("Jupiter");
        list.add("Jupiter");
        list.add("Uranus");
        list.add("Saturn");
        list.add("Saturn");
        list.add("Mercury");
        return list;
    }
}
