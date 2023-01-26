// Принемает на вход число и выдаёт сумму цифр в числе
int numA = new Random().Next(1, 100000);
Console.WriteLine(numA);
Console.WriteLine(GetSum(numA));

static int GetSum(int num)
{
    int numSum = 0;
    while(num > 0)
    {
        numSum = numSum + (num % 10);
        num /= 10;
    }
    return numSum;
}