//palindrom
//int eded = 121;
//int deyisiklik = eded;
//int ters = 0;

//while (deyisiklik > 0)
//{
//    ters = ters * 10 + deyisiklik % 10;
//    deyisiklik /= 10;
//}

//if (eded == ters)
//{
//    Console.WriteLine("Palindromdur");
//}
//else
//{
//    Console.WriteLine("Palindrom deyil");
//}






//sozun palindrom oldugunu

//string soz = "ana";
//string ters = "";

//for (int i = soz.Length - 1; i >= 0; i--)
//{
//    ters += soz[i];
//}

//if (soz == ters)
//{
//    Console.WriteLine("Palindromdur");
//}
//else
//{
//    Console.WriteLine("Palindrom deyil");
//}






//bir arraydeki sade ve murekkeb ededlerin sayini tapin


int[] arr = { 1, 2, 4, 5, 9, 7 };

int sade = 0;
int murekkeb = 0;
int say = 0;
foreach (int num in arr)
{
    if (num == 1)
    {
        Console.WriteLine("1 ne sadedir ne murekkeb");
        continue;
    }

   

    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            say++;
        }
    }

    if (say == 2)
    {
        sade++;
    }
    else
    {
        murekkeb++;
    }
}

Console.WriteLine("Sade ededlerin sayi: " + sade);
Console.WriteLine("Murekkeb ededlerin sayi: " + murekkeb);
