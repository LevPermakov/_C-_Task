    
//   ДЗ Семинар 3
// Создаем калькулятор:
// 1. Создать страницу, которая спрашивает(prompt) знак арифм. операции (+ , - и т.д.)
// 2. Запрашиваем ввод 2 чисел через prompt
// 3. Реализовать функцию - калькулятор и вывести результат на экран

let znak = prompt("Введите знак арифметической опереции (+, -, :, /): ", "+")
// alert(znak)
let a = parseInt(prompt("Введите значение Первой переменной (a): ", "10"))
// alert(a)
let b = parseInt(prompt("Введите значение Второй переменной (b): ", "20"))
// alert(b)

var rez = 0
// var rez2 = 0
// alert(rez)
function calculator (zn, a, b){
    switch (zn) {
        case "+":
            rez = a + b
            return rez
        case "-":
            rez = a - b
            return rez
        case "*":
            rez = a * b
            return rez
        case "/":
            rez = a / b
            return rez           
        default:
            rez = "Нет такой операции!" 
            // alert("Нет такой операции!")
            // break
            return rez
       }
}
rez = calculator (znak, a, b)
let massage_1 = `Результат_1:  ${rez}`
alert(massage_1)

// Вариант 2
let rez2 = `alert(${a} ${znak} ${b})`
// let rez2 = `alert("Рузультат_2: " ${a} ${znak} ${b})`
eval(rez2)

// Вариант 3
// var fn_Cal = `function fn_Cal () {
//     var rez2 = ${a} ${znak} b
//     return rez2}`
// rez2 = eval(fn_Cal())
// alert(rez2)