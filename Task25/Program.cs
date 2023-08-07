// Задача 25:
// Напишите цикл, который
// принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 –> 243 (3 ^ 5)
// 2, 4 –> 16  (2 ^ 4)

bool Natural(int natural)
{
    return natural > 0;
}

int Exponentiation(int num, int exp)
{
    int power = 1;
    for (int i = 0; i < exp; i++)
    {
        checked { power *= num; }
    }
    return power;
}

Console.Write("Введите основание степени (целое число): ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени (натуральное число): ");
int exponent = Convert.ToInt32(Console.ReadLine());

if (Natural(exponent))
{
    int result = Exponentiation(number, exponent);
    Console.WriteLine($"{number} ^ {exponent} = {result}.");
}
else Console.WriteLine($"Показатель степени: {exponent}, не натуральное число.");
