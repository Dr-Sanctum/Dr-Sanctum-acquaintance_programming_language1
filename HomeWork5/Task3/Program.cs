﻿/*Кажется, еще совсем недавно наступил новый 2013 год. 
А знали ли Вы забавный факт о том, что 2013 год является 
первым годом после далекого 1987 года, в котором все цифры различны?

Теперь же Вам предлагается решить следующую задачу: 
задан номер года, найдите наименьший номер года, 
который строго больше заданного и в котором все цифры различны.

Входные данные
В единственной строке задано целое число y (1000 ≤ y ≤ 9000) — номер года.

Выходные данные
Выведите единственное целое число — минимальный номер года, 
который строго больше y, в котором все цифры различны. 
Гарантируется, что ответ существует.
*/


int given = int.Parse(Console.ReadLine());

int a, b ,c , d;

for ( given += 1; given < 9999; given++)
{
    a = given/1000;
    b = given/100%10;
    c = given/10%10;
    d = given%10;
    if (a!=b && a!=c && a!=d && b!=c && b!=d && c!=d)
    {
        break;
    }
}
Console.WriteLine(given);

