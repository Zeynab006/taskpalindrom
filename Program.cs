//for ve while do while
//1 ci sintaksis ferqi
//2 ci 
//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}




//for(int i=0; i<=100; i++)
//{
//    Console.WriteLine(i);
//}

//int j = 1;
//while (j<=100)
//{
//    j++;    
//    Console.WriteLine(j);
//}

//while >>her hansi bir sert olana qeder davam edir
//user yes yazanda proqram dayansin yazmasa her defesinde sorussun ki cixmaq isteyirsinizmi
//Console.WriteLine("Proqramdan cixmaq isteyirsinizmi");
//string answer = Console.ReadLine();
//while(answer!="yes")
//{
//    Console.WriteLine("Proqramdan cixmaq isteyirsinizmi");
//    answer = Console.ReadLine();  
//}
//do while
//int i = 1;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i<=100);
//while  serti yoxlayir sonra isledir
//dowhile isledir sonra serte baxir


//string answer = "";
//do
//{
//    Console.WriteLine("Proqramdan cixmaq isteyirsinizmi");
//     answer = Console.ReadLine();
//}
//while (answer != "yes");


//string answer = "";
//do
//{
//    Console.WriteLine("Proqramdan cixmaq isteyirsinizmi");
//    answer = Console.ReadLine();
//}
//while (answer != "no");



//her hansi bir ededin mertebe sayini qaytaran proqram

//int num = 0;
//int count = 0;

//while (num != 0)
//{
//    num /= 10;
//    count++;    
//}

//Console.WriteLine(count);




//int num = 0;
//int count = 0;

//do
//{
//    num /= 10;
//    count++;
//} while (num != 0);
//Console.WriteLine(count);

//palindrom ededleri tapin 
// for if
//sozun palindrom oldugunu
//bir arraydeki sade ve murekkeb ededlerin sayini tapin




//for (int i = 0; i < 10; i++) ;
//{
//    Console.WriteLine("1ci dongu");
//    for (int j = 0; j < 10; j++)
//    {
//        Console.WriteLine("2ci dongu");
//    }
//}


//sozde nece sait var

//string word = "Salam";
//char[] vowels = ['a' , 'o' , 'i' , 'u' ,'e'];
//int count = 0;

//for (int i = 0; i < word.Length; i++)
//{
//    for (int j = 0; j < vowels.Length; j++)
//    {
//        if (word[i] == vowels[j])
//        {
//            count++;
//        }
//    }
//}
//Console.WriteLine(count);

//int[] nums=[1, 2, 3, 4, 5];
//int a = 1;

//for(int i=0; i<nums.Length; i++)
//{
//    if(nums[i] == a)
//    {
//        Console.WriteLine(i);
//    }
//}
/*Console.WriteLine(nums[3]); */  //O(1)





//palindrom ededleri tapin 
// for if
//sozun palindrom oldugunu









//bir arraydeki sade ve murekkeb ededlerin sayini tapin
//int [] arr = {1,2,3,4,5,6,7,8};




//bool HerfVar(string soz, char herf)
//{
//    for (int i = 0; i < soz.Length; i++)
//    {
//        if (soz[i] == herf)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine(HerfVar("salam", 'a'));










//1Ededlerden ibaret array in icerisinde en boyuk elementi tapan metod yaz
//int[] arr = {1,2,3,4,5,6,5,8,8,9,87};
//for (int i = 0; i < arr.Length; i++ )
//{
//    if arr[i] > arr[i + 1]{ }
//}








//Soz ve herf verilib sozun icinde hemin herfin olub olmadigini tapan metod yazin




//string soz = "Salam";
//char herf = 'a' ;
//bool c = false;
//for (int i = 0; i < soz.Length; i++)
//{
//    if (soz[i] == herf)
//    {
//        c=true;
//         break;

//    else{}
//}



//string soz = ("salam");
//char herf = 'a';
//bool var= false;
//{
//    for (int i = 0; i < soz.Length; i++)
//    {
//        if (soz[i] == herf)
//        {
//            return true;
//        }
//    }
//    return false;
//}
//Console.WriteLine);





//Verilmis metnin .az domen sayt adi olub olmadiginimmueyyen eden metod yazin
//string web = "kontakt.az";
//string domain = ".az";
//bool isDomain = false;
//if (web.Length < 3)
//{
//    isDomain = false;
//}
//else if (web.Length>0)
//{
//    string lastThree = "" + web[web.Length-3] + web[web.Length - 2] + web[web.Length - 1];
//}
//    if (lastThree == domain)
//{
//    isDomain = true;
//}
//verilmis sozun cumlede islennib islemediyini tapan metod yazin

//string web = "kontakt.az";
//string domain = ".az";
//bool isDomain = false;

//if (web.Length >= domain.Length) 
//{
//    string lastThree = "" + web[web.Length - 3] + web[web.Length - 2] + web[web.Length - 1];

//    if (lastThree == domain)
//    {
//        isDomain = true;
//    }
//}

//Console.WriteLine(isDomain); 






// verilmis cumlede nece soz oldugunu tapin


//string sentence = "verilmis cumlede nece soz var";
//int count = 0;

//for (int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i] == ' ')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count+1);





//verilmis sozun cumlede islenib islenmediyini gosteren metod

//string cumle = "Code for future";
//char space = ' ';
//string words = "";
//string find = "for";
//bool c = false;

//for (int i = 0; i < cumle.Length; i++)
//{
//    if (cumle[i] != ' ')
//    {
//        words += cumle[i];
//        Console.WriteLine(words);
//    }
//    else
//    {
//        words = "";
//    }
//    if(words==find)
//    {
//        Console.WriteLine("hemin soz var");
//        break;
//    }
//}

//string soz = "Salam";
//char herf = 'a' ;
//bool c = false;
//for (int i = 0; i < soz.Length; i++)
//{
//    if (soz[i] == herf)
//    {
//        c=true;
//         break;

//    else{}
//}







//verilmis stringin icindeki butun bosluqlari  %20 ile evez eden metod

//string Bosluq(string metn)
//{
//    return metn.Replace(" ", "%20");
//}

//Console.WriteLine(Bosluq("Programming"));


//string cumle = "programming dfds gfsg";
//string netice = "";














//palindrom ededleri tapin 
//for (int i = 10; i < 200; i++)
//{
//    int eded = i;
//    int ters = 0;

//    while (eded > 0)
//    {
//        ters = ters * 10 + eded % 10;
//        eded /= 10;
//    }

//    if (i == ters)
//    {
//        Console.WriteLine(i);
//    }
//}






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