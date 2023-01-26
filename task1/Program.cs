// программа принемает два числа и возвращает первое в степени второго
int numA = new Random().Next(1, 10);
int numB = new Random().Next(1, 10);

Console.WriteLine(GetPow(numA, numB));

static int GetPow(int num1, int num2)
{
    int res = 0;
    res =Convert.ToInt32(Math.Pow(num1, num2));
    return res;
}
