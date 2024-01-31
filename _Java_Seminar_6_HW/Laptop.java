package Seminar_6;

import java.util.Objects;

public class Laptop {
    public static final int setAmountRAM = 0;
    // Поля:
    private String brandName;
    private String model;
    private String color;
    private int price;
    private String os;
    private int amountRAM;
    private int hdd;
    

    // Создаем Конструктор: 
    public Laptop(String brandName, String model, String color, int price, String os, int amountRAM, int hdd) {
        // Берем член Класса и присваиваем ему значение
        // Инициализируем значение по-умолчанию
        this.brandName = brandName;
        this.model = model;
        this.color = color;
        this.price = price;
        this.os = os;
        this.amountRAM = amountRAM;
        this.hdd = hdd;
    }

    // Геттеры и Сеттеры для полей Класса
    public String getbrandName() {
        return brandName;
    }

    public String getModel() {
        return model;
    }

    public int getPrice() {
        return price;
    }

    public String getOs() {
        return os;
    }

    public int getAmountRAM() {
        return amountRAM;
    }

    public int getHdd() {
        return hdd;
    }
    public String getColor() {
        return color;
    }

    //==============================
    public void setBrandName(String brandName) {
        this.brandName = brandName;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public void setPrice(int price ) {
        this.price = price;
    }

    public void setOs(String os) {
        this.os = os;
    }

    public void setAmountRAM(int amountRAM) {
        this.amountRAM = amountRAM;
    }

    public void setHdd(int hdd) {
        this.hdd = hdd;
    }

    public void setColor(String color) {
        this.color = color;
    }


    @Override
    public String toString() {
        return "Бренд: " + brandName + "; Модель: " + model + "; Цвет: " + color + "; Цена: " + price + "; ОС: " + os + "; РАМ: " + amountRAM + "; HDD: " + hdd;
    } 

    // this.brandName = brandName;
    // this.model = model;
    // this.color = color;
    // this.price = price;
    // this.os = os;
    // this.amountRAM = amountRAM;
    // this.hdd = hdd;

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
           return true; 
        }
        if (obj == null || getClass() != obj.getClass()) {
            return false;
        }
        Laptop laptop = (Laptop)obj;
        return model.equals(laptop.model) && color.equals(laptop.color) && price == laptop.price;
    }

    @Override
    public int hashCode() {
        return Objects.hash(model, color, price);
    }
    
}
