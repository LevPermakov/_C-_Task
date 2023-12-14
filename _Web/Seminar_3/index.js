// alert("Hello, world!")
// alert(`Результат: ${158 + 2}`)   // обратные кавычки – буква Ё на латинской раскладке:  ````
// Знак интерполяции - $, ставится перед выражением

// alert(`Результат: 158 + 2`);     // знак ; - не обязателен 
// alert(158 + 2); 
// alert("158" + "2"); 
// alert("158" + 2)

// function examplLet (){
//     let x = 10             // let - блочная область видиомости
//     if (true) {
//         let x = 20;
//         alert(x)   // 20
//     }
//     alert(x)       // 10
// }
// examplLet()

// function exampleVar (){
//     var y = 10            // var - функциональная область видимости
//     if (true) {
//         var y = 20;
//         alert(y)   // 20
//     }
//     alert(y)       // 20
// }
// exampleVar()

// let name = `Михаил`
// alert(`Привет, ${name}!`)

// let userName = `Михаил`
// let userName = prompt("Enter your name: ", "USER")
// function showGreetings() {
//     let massage = "Hello, " + userName
//     alert(massage)
// }
// showGreetings()

//  Калькулятор (часть)
// функция-предикат - возвращает либо true, либо false
// if (confirm("Складываем числа 5 и 3?")) {   // OK
//     alert(5+3)
// }
// else   // Отмена
// {
//     alert("...")
// }
    
//   ДЗ Семинар 3
// Создаем калькулятор:
// 1. Создать страницу, которая спрашивает(prompt) знак арифм. операции (+ , - и т.д.)
// 2. Запрашиваем ввод 2 чисел через prompt
// 3. Реализовать функцию - калькулятор и вывести результат на экран

let znak = prompt("Введите знак арифметической опереции (+, -, :, /): ", "+")
alert(znak)
let a = prompt("Введите значение Первой переменной (a): ", "10")
alert(a)
let b = prompt("Введите значение Второй переменной (b): ", "20")
alert(b)
// alert(a+b)
// alert(a*b)
// alert(a/b)
// alert(a*b)


// function showGreetings() {
//     let massage = "Hello, " + userName
//     alert(massage)
// }
// showGreetings()