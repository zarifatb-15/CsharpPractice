using System.Globalization;

namespace Practice;

class Program
{
    static void Main(string[] args)
    {
        #region  ArrayTasks

        //Arrayde en boyuk reqemin indeksini tapir.Axtardigimiz reqem yoxusa ekrana -1 cixarir.
      
        // int[] numbers = { 10, 20, 15 };
        // Array.Sort(numbers);
        // int num = 10;
        // int index = -1;
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     if (numbers[i] == num)
        //     {
        //         index = i;
        //         break;
        //     }
        // }
        // Console.WriteLine($"Index: {index}");
//Arraydə təkrarlanan rəqəmi tpamaq və neçə dəfə təkrarlandığını ekrana çap etmek.
        // int[] arr = { 1, 2, 3, 4, 5, 5, 5, 4, 3, 3 };
        // int num = 5;
        // int count = 0;
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (arr[i] == num)
        //         count++;
        // }
        //
        // Console.WriteLine($"Count:{count}");
        // Tekrarlanan simvol ve sayi

        // string sentence = "Hello World helloooo";
        // int max = 0;
        // char simvol = ' ';
        // for (int i = 0; i < sentence.Length; i++)
        // {
        //     int count = 0;
        //     for (int j = 0; j < sentence.Length; j++)
        //     {
        //         if (sentence[i] == sentence[j])
        //             count++;
        //         if (count > max)
        //         {
        //             max = count;
        //             simvol = sentence[i];
        //         }
        //     }
        // }
        //
        // Console.WriteLine($"Simvol: {simvol}");
        // Console.WriteLine($"MAX Simvol: {max}");//Arrayde en boyuk reqemin indeksini tapir.Axtardigimiz reqem yoxusa ekrana -1 cixarir.
      
        // int[] numbers = { 10, 20, 15 };
        // Array.Sort(numbers);
        // int num = 10;
        // int index = -1;
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     if (numbers[i] == num)
        //     {
        //         index = i;
        //         break;
        //     }
        // }
        // Console.WriteLine($"Index: {index}");
//Arraydə təkrarlanan rəqəmi tpamaq və neçə dəfə təkrarlandığını ekrana çap etmek.
        // int[] arr = { 1, 2, 3, 4, 5, 5, 5, 4, 3, 3 };
        // int num = 5;
        // int count = 0;
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (arr[i] == num)
        //         count++;
        // }
        //
        // Console.WriteLine($"Count:{count}");
        // Tekrarlanan simvol ve sayi

        // string sentence = "Hello World helloooo";
        // int max = 0;
        // char simvol = ' ';
        // for (int i = 0; i < sentence.Length; i++)
        // {
        //     int count = 0;
        //     for (int j = 0; j < sentence.Length; j++)
        //     {
        //         if (sentence[i] == sentence[j])
        //             count++;
        //         if (count > max)
        //         {
        //             max = count;
        //             simvol = sentence[i];
        //         }
        //     }
        // }
        //
        // Console.WriteLine($"Simvol: {simvol}");
        // Console.WriteLine($"MAX Simvol: {max}");
        
        // string[] students=new string[3];
        //
        // students[0] = "Zarifa";
        // students [1] = "Kamran";
        // students [2] = "Aysel";
        //
        // foreach (string student in students)
        // {
        // Console.WriteLine(student);
        // }
            
        

        // string [] studentGroup = new string [5];
        // studentGroup[0] = "Ayxan";
        // studentGroup[1] = "Rufet";
        // studentGroup[2] = "Nicat";
        // studentGroup[3] = "Xeyale";
        // studentGroup[4] = "Zarina";
        //
        //
        // Console.WriteLine(studentGroup[0]);
        
        // foreach (string student in studentGroup)
        // {
        //     Console.WriteLine(student);
        // }

        // string[,] regions = new string[7, 3]
        // {
        //     { "Baki", "Gence", "Sumqayit" },
        //     { "Lankaran", "Mingachevir", "Shaki" },
        //     { "Quba", "Qusar", "Shamakhi" },
        //     { "Gabala", "Yevlakh", "Agdam" },
        //     { "Nakhchivan", "Shirvan", "Jalilabad" },
        //     { "Salyan", "Masalli", "Fuzuli" },
        //     { "Imishli", "Aghjabadi", "Tartar" }
        // };
        //
        // for (int i=0;i<=regions.GetUpperBound(0); i++)
        // {
        //     for (int j = 0; j <= regions.GetUpperBound(1); j++)
        //     {
        //         Console.WriteLine(regions[i, j]);
        //     }
        // }
        //
        
        
        






        #endregion
        #region MyMiniTasks

        // Console.WriteLine("*****Hello C#*****");

        // Console.WriteLine("*****Qiymet Cedveli*****");
        // Console.WriteLine();
        // double applePrice = 2.50;
        // double bananaPrice = 1.20;
        // double orangePrice = 1.80;
        // double strawberryPrice = 3.00;
        // double potatoPrice = 0.80;
        // double tomataPrice = 1.50;
        // Console.WriteLine("-------apple-------" + applePrice + " AZN");
        // Console.WriteLine("-------banan-------" + bananaPrice + " AZN");
        // Console.WriteLine("-------orenge-------" + orangePrice+ " AZN");
        // Console.WriteLine("-------strawberry-------" + strawberryPrice + " AZN");
        // Console.WriteLine("-------potato-------" + potatoPrice + " AZN");
        // Console.WriteLine("-------tomata-------" + tomataPrice + " AZN");
        //
        // Console.WriteLine( );
        // Console.WriteLine( );
        //
        // double appleGram = 1.700;
        // double bananaGram = 2.990;
        // double orangeGram = 4.800;
        // double strawberryGram = 5.450;
        // double potatoGram = 3.600;
        // double tomataGram = 1.500;
        //
        //
        // double  appleTotal = applePrice * appleGram;
        // Console.WriteLine("Apple umumi mebleg: " + appleTotal + " AZN");
        // double bananaTotal = bananaPrice * bananaGram;
        // Console.WriteLine("Banana umumi mebleg: " + bananaTotal +"AZN");
        // double orangeTotal = orangePrice * orangeGram;
        // Console.WriteLine("Orange umumi mebleg: " + orangeTotal + " AZN");
        // double strawberryTotal = strawberryPrice * strawberryGram;
        // Console.WriteLine("Strawberry umumi mebleg: " + strawberryTotal + " AZN");
        // double potatoTotal = potatoPrice * potatoGram;
        // Console.WriteLine("Potato umumi mebleg: " + potatoTotal + " AZN");
        // double tomataTotal = tomataPrice * tomataGram;
        // Console.WriteLine("Tomata umumi mebleg: " + tomataTotal + " AZN");  
        //
        // double shoppingTotalprice=appleTotal + bananaTotal + orangeTotal + strawberryTotal;
        // Console.WriteLine();
        // Console.WriteLine();
        //
        // Console.WriteLine("Umumi mebleg: " + shoppingTotalprice + " AZN");

        // char simvol = 'Z';
        // Console.WriteLine(simvol);
        //
        // Console.WriteLine("****c# hava yollari melumatlari****");
        // Console.WriteLine();
        // string passengerName = "";
        // string passengerSurname="";
        // string passengerDistination="";
        // string passengerCity="";
        // string passengerAge="";
        // string passengerIdentity="";
        //
        // Console.Write("Passenger Name: ");
        // passengerName = Console.ReadLine();
        // Console.Write("Passenger Surname: ");
        // passengerSurname = Console.ReadLine();
        // Console.Write("Passenger Distination: ");
        // passengerDistination = Console.ReadLine();
        // Console.Write("Passenger City: ");
        // passengerCity = Console.ReadLine();
        // Console.Write("Passenger Age: ");
        // passengerAge = Console.ReadLine();
        // Console.Write("Passenger Identity: ");
        // passengerIdentity = Console.ReadLine(); 
        // Console.WriteLine();
        // Console.WriteLine("-------------------------------");
        //
        // Console.WriteLine("Passenger Name:" + passengerName);
        // Console.WriteLine("Passenger Surname:" + passengerSurname);
        // Console.WriteLine("Passenger Distination:" + passengerDistination);
        // Console.WriteLine("Passenger City:" + passengerCity);
        // Console.WriteLine("Passenger Age:" + passengerAge);
        // Console.WriteLine("Passenger Identity:" + passengerIdentity);
        //


        // int shoesPrice, computerPrice, chairPrice, tvPrice;
        // shoesPrice = 100;
        // computerPrice = 3300;
        // chairPrice = 500;
        // tvPrice= 2500;
        //
        // int shoesCount, computerCount, chairCount, tvCount;
        // Console.Write(" Aldiginiz ayaqqabi sayini yazin: ");
        // shoesCount = int.Parse(Console.ReadLine());
        // Console.Write("Aldiginiz komputer sayini yazin: ");
        // computerCount=int.Parse(Console.ReadLine());
        // Console.Write("Aldiginiz stul sayini yazin: ");
        // chairCount = int.Parse(Console.ReadLine());
        // Console.Write("Aldiginiz televizor sayini yazin: ");
        // tvCount = int.Parse(Console.ReadLine());
        //
        // int totalPrice=(shoesPrice*shoesCount)+(computerPrice*computerCount)+(chairPrice*chairCount)+(tvPrice*tvCount);
        // Console.WriteLine();
        //
        // Console.WriteLine("Umumi mebleg: " + totalPrice + " AZN");

        //5 imtahan balinin ortalamasini tapan proqram

        //  double exam1, exam2, exam3,exam4, exam5;
        //  Console.Write("Birinci imtahan balini daxil edin: ");
        //  exam1 = double.Parse(Console.ReadLine());
        //  Console.Write("Ikinci imtahan balini daxil edin: ");
        //  exam2= double.Parse(Console.ReadLine());
        //  Console.Write("Ucuncu imtahan balini daxil edin: ");
        //  exam3 = double.Parse(Console.ReadLine());
        //  Console.Write("Dorduncu imtahan balini daxil edin: ");
        //  exam4 = double.Parse(Console.ReadLine());
        //  Console.Write("Besinci imtahan balini daxil edin: ");
        //  exam5 = double.Parse(Console.ReadLine());
        //  
        // double result  = (exam1 + exam2 + exam3+ exam4+ exam5) / 5;
        //  Console.WriteLine("Ortalama baliniz: " + result);

        #endregion

        #region Lopps

        // var i1 = For();
        //
        //
        // for(int i =100; i<0; i--)
        // {
        //     Console.WriteLine(i);
        // }
        
        
        

        #endregion
    }

    // private static int For()
    // {
    //     int i;
    //     for (i = 0; i <=100; i++)
    //     {
    //         Console .WriteLine(i);
    //     }
    //
    //     return i;
    // }
}