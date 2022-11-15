Задание

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа

Решение

1. Прописавыем функцию "GetNumber" ввода любого числа с клавиатуры;
2. Прописываем функцию "InitArray" ввода массива строк с клавиатуры;
3. Прописываем функцию "ElementsCounter" счетчика элементов по заданному параметру;
4. Прописываем функцию "FillResultArray", которая создает и заполняет массив элементами, удовлетворяющими условию, из ранее заданного массива;
5. Прописываем фунцкию "PrintArray" вывода массива на экран;
6. При помощи функции "GetNumber" задаем переменную "length", которая будет отвечать за длину первоначального массива;
7. Создаем и вводим элементы первоначального массива "userArray" функцией "InitArray";
8. Для наглядносьти выводим массив "userArray" на экран;
9. Функцией "ElementsCounter" присваиваем переменной "resultArrayLength" кол-во элементов, подходящих под условие: длина меньше либо равна 3;
10. При помощи функции "FillResultArray", создаем новый массив длиной равной значению "resultArrayLength" и заполняем его элементами, длина которых равна 3, из массива "userArray".