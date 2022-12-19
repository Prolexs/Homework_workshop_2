/*
!!!!
Не самый рациональный вариант решения, но хотелось расписать выходные целого месяца. Вариант, как сделать запись короче, я не нашел. 
Есть ли оператор, который поочередно сравнивает введеное значение с каждым из значений в базе данных?
!!!!
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите любое число февраля 2022 года: ");
int A = Convert.ToInt32(Console.ReadLine());
int [] weekend = {5, 6, 12, 13, 19, 20, 23, 26, 27};
if (A == weekend[0])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[1])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[2])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[3])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[4])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[5])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[6])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[7])
{
    Console.WriteLine(" выходной день ");
}
if (A == weekend[8])
{
    Console.WriteLine(" выходной день ");
}
else 
{
    Console.WriteLine(" не выходной день ");
}