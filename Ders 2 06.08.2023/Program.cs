

//1. HAFTA

/*{
    int number1 = 10;
    int number2 = 5;

    int sum = number1 + number2;    
    Console.WriteLine($"Sum: {sum}");

    int difference = number1 - number2;
    Console.WriteLine($"Difference: {difference}");

    int baseNumber = 2;
    int exponent = 3;
    double result = Math, Pow(baseNumber, exponent);

    int total;
    total = total + 1;

    for ( int i = 0; i < exponent; i++ )
    {
        result = baseNumber * baseNumber;
    }
}*/


/*{
    Console.WriteLine("Birinci Sayıyı Girin:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci Sayıyı Girin:");
    int num2 = Convert.ToInt32(Console.ReadLine());


    if (num1 == num2)
    {
        Console.WriteLine("num1 == num2");
    }

    if (num1 != num2)
    {
        Console.WriteLine("num1 != num2");
    }

    if (num1 > num2)
    {
        Console.WriteLine("num1 > num2");
    }

    if (num1 < num2)
    {
        Console.WriteLine("num1 < num2");
    }

    if (num1 <= num2)
    {
        Console.WriteLine("num1 <= num2");
    }

    if (num1 >= num2)
    {
        Console.WriteLine("num1 >= num2");
    }
    Console.ReadLine();
}

{
    Console.WriteLine("Kaç İşçi Gireceksiniz?");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"İşçi {i + 1} Yaşını Giriniz:");
        int old = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"İşçi{i + 1} Maaşını Giriniz:");
        double salary = Convert.ToDouble(Console.ReadLine());

        //if (old > 25 && salary == 1000)
        {
            Console.WriteLine($"İşçi {i + 1} Bilgileri");
            Console.WriteLine($"Yaş = {old} ");
            Console.WriteLine($"Maaş = {salary}");
        }



    }
}
Console.WriteLine("Program Bitti");*/

/*{
    Console.WriteLine("Kaç Öğrenci Gireceksiniz?");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{i + 1}. Öğrenci Algoritma Notu:");
        int not1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{i + 1}. Öğrenci Veritabanı Notu:");
        double not2 = Convert.ToDouble(Console.ReadLine());

        if (not1 > 60 && not2 > 60)
        {
            Console.WriteLine($"{i + 1}. Öğrenci GEÇTİ");
            
        }
        else
        {
            Console.WriteLine($"{i + 1}. Öğrenci KALDI");
        }



    }
}
Console.WriteLine("Program Bitti");*/

/*{
    Console.WriteLine("Kaç Öğrenci Gireceksiniz?");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{i + 1}. Öğrenci Algoritma Notu:");
        int not1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{i + 1}. Öğrenci Veritabanı Notu:");
        double not2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{i + 1}. Öğrenci İnternet Notu:");
        double not3 = Convert.ToDouble(Console.ReadLine());

        if (not1 > 70 && (not2 > 65 || not3 > 65 ) )
        {
            Console.WriteLine($"{i + 1}. Öğrenci GEÇTİ ");
            Console.WriteLine("");
            Console.WriteLine("");


        }
        else
        {
            Console.WriteLine($"{i + 1}. Öğrenci KALDI ");
        }
        

    }
}
Console.WriteLine("Program Bitti");
*/


/* // FAKTÖRİYEL HESABI
 {
    Console.WriteLine("Değer Giriniz:");
    int n = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial = factorial * i;
               
    }
    Console.WriteLine(n + "! = " + factorial );
}
Console.WriteLine("Program Bitti");*/

//ÖDEVLER (1. Hafta) 

/* //1. Soru

//Klavyeden 3 farklı tam sayı girişi yaptıran, daha sonra bu sayıların toplamını, ortalamasını,
//çarpımını, en küçüğünü ve en büyüğünü hesaplayan bir program yazın.
//Programı sadece if keywordu içersin. Hazır fonksiyonlar kullanmayın.
//Ekran çıktısı aşağıdaki şekilde olmalıdır:
//ÇIKTI:
//Üç farklı tamsayı giriniz: 13 27 54
//Toplam: 54
//Ortalama: 18
//Çarpım: 4914
//En küçük: 13
//En büyük: 27




{
    Console.WriteLine("Üç Farklı Tamsayı Girilecektir.");
    Console.WriteLine();

    Console.WriteLine("1. Tamsayıyı Giriniz:");
    decimal n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("2. Tamsayıyı Giriniz:");
    decimal n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("3. Tamsayıyı Giriniz:");
    decimal n3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Üç Farklı Tamsayı Giriniz: {n1} {n2} {n3} ");

    decimal sum = n1 + n2 + n3;
    Console.WriteLine($"Toplam: {sum}");

    decimal average = (n1 + n2 + n3) / 3;
    Console.WriteLine($"Ortalama: {average}");

    decimal multiplication = n1 * n2 * n3;
    Console.WriteLine($"Çarpım: {multiplication}");

    if (n1 <= n2 && n1 <= n3)
    {
        Console.WriteLine($"En Küçük {n1} ");

    }
    else if (n2 <= n1 && n2 <= n3)
    {
        Console.WriteLine($"En Küçük {n2} ");
    }
    else
    {
        Console.WriteLine($"En Küçük {n3} ");
    }



    if (n1 > n2 && n1 > n3)
    {
        Console.WriteLine($"En Büyük {n1} ");

    }
    else if (n2 > n1 && n2 > n3)
    {
        Console.WriteLine($"En Büyük {n2} ");
    }

    else
    {
        Console.WriteLine($"En Büyük {n3} ");
    }
}

Console.WriteLine("");*/


/* //2. Soru
   // 0‘dan 10‘a kadar olan sayıların karelerini ve küplerini hesaplayıp, sonuçları ekrana
   //aşağıda göründüğü biçimde yazdıran bir program yazınız.




{
    Console.WriteLine("0‘dan 10‘a kadar olan sayıların karelerini ve küplerini hesaplanması için Enter'a Basınız.");
    Console.ReadLine();

    Console.WriteLine("Sayı  Karesi   Küpü");
    int n = 3;

    for (int i = 0; i <= n; i++)
    {
        Console.WriteLine($"{i}      {i * i}        {i * i * i}");

    }

    int m = 9;

    for (int k = 4; k <= m; k++)
    {
        Console.WriteLine($"{k}      {k*k}       {k * k*k} ");

    }

    int z = 10;

    for (int p = 10; p <= z; p++)
    {
        Console.WriteLine($"{p}     {p*p}      {p*p*p} ");

    }
}

Console.ReadLine();

*/


/* //3. Soru
 
//Bir sürücü, kaç kilometre yol yaptığını ve kaç lt benzin harcadığını hesaplamaya başladı.
//Kaç kilometre yol yaptığını ve kaç lt benzin harcandığını kullanıcıdan alan bir C# programı
//yazınız. Programınız, her lt için kaç kilometre yol alındığını hesaplasın. Bütün giriş bilgileri
//alındıktan sonra programınız, gidilen toplam kilometre için harcanan benzin miktarını
//bulmalı.








{
Console.WriteLine("Kaç Giriş Yapılacak?");
int n = Convert.ToInt32(Console.ReadLine());

double totalKilometers = 0;
double totalFuel = 0;


for (double i = 1; i <= n; i++)
{

    Console.WriteLine($"{i}. Çıkış için kaç litre benzin harcandı?:");
    double fuel = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{i}. Çıkış için aç kilometre yol alındı?:");
    double kilometers = Convert.ToInt32(Console.ReadLine()+"\n");
 

    double avarage = kilometers / fuel;
    {
        Console.WriteLine($"Kaç litre benzin harcandı: {fuel} lt");
        Console.WriteLine($"Kaç kilometre yol alındı: {kilometers} km");
        Console.WriteLine($"Kilometre / litre : {avarage} km/lt\n");
    }
    

    
    
        totalFuel += fuel;
        totalKilometers += kilometers;
        

    }
double averageKmPerLt = totalKilometers / totalFuel;

Console.WriteLine("\nToplam Kaç Litre Benzin Harcandı: " + totalFuel + " lt");
Console.WriteLine("Toplam Ortalama kilometre / Litre: " + averageKmPerLt + "km/lt");

}
Console.ReadLine();
Console.ReadLine();

*/


/* //4. Soru

//Bir ilaç şirketi, satış elemanlarına ücretlerini komisyon şeklinde ödemektedir. Bir satış
//elemanı haftalık 200$ ve haftalık brüt satışından %9 almaktadır. Örneğin, 5000$
//tutarında bir haftalık satış yapan satış elemanı 200$ ve 5000$ ‘in %9 ‘unu
//kazanmaktadır, yani 650$. Son haftadaki satış elemanlarının satışlarını kullanıcıya
//girdiren ve bu satış elemanlarının ne kadar kazandıklarını hesaplayıp ekrana yazdıran
//bir program yazınız. Her seferinde bir satış elemanın işlemlerini yapınız.



Console.WriteLine("Kaç Satış Elemanı Bulunmaktadır?");
double n = Convert.ToInt32(Console.ReadLine());
Console.ReadLine();


double weeklySalary = 200;

for (double i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}. Satış Elemanı Ne Kadar Satış Yaptı?:");
    double commission = Convert.ToInt32(Console.ReadLine());

        double monthlySalary = (4*weeklySalary + (commission * 0.09)) ;

    Console.WriteLine($"{i}. Satıcı  Satış Tutarı : {commission} $");
    Console.WriteLine($"{i}. Satıcı Maaşı : {monthlySalary} $\n");
    
}

Console.ReadLine();
Console.ReadLine();

*/


/* //5. Soru

//Tersten ve düzden okunduğunda aynı okunan kelimelere palindrome denir. Örneğin,
//12321, 55555, 45554, 11611 beş basamaklı tam sayıları birer palindrome‘dur. Kullanıcının
//girdiği beş basamaklı bir sayının palindrome olup olmadığına karar verip ekrana yazdıran
//bir program yazdınız.





Console.WriteLine("Beş basamaklı palindrome sayı bulma programı.\n\nEkrana 5 Basamaklı Bir Sayı Giriniz:");
double n = Convert.ToInt32(Console.ReadLine());
                               //12321

double m = n % 10000 ;         //2321
double l = m % 1000;           //321
double k = l % 100;            //21
double r = k % 10;             //1

double x = r*10000 + (k-r)*100 + (l-k) + (m-l)/100 + (n-m)/10000;






    if (n >= 100000 || n < 10000)
    {
        Console.WriteLine("\nYanlış Değer Girdiniz!!!");
   

}

   else if (n == x && n <= 100000 && n > 10000)
    {
 
    Console.WriteLine("\nPalindrome Sayıdır!!!");
    }
    else
    {
    
    Console.WriteLine("Palindrome Sayı Değildir!!!");
    }

Console.ReadLine();
Console.ReadLine(); 

*/


/* //6. Soru

//Bir park yeri işletmesi, 3 saate kadar yapılan parklar için minimum 2$ almaktadır. 3 saatin
//geçilmesi halinde her saat için 0,5$ almaktadır. Maksimum alınan para ise 24 saatlik park
//edilmesi halinde 10$'dır. 24 saatten daha uzun hiç bir aracın park etmediğini kabul ediniz.
//Dün bu park yerine park etmiş olan üç müşterinin ödemelerini hesaplayan ve yazdıran bir
//programı yazınız.(Kullanıcı, her müşterinin park saatini girmeli ve çıktı düzgün bir çizelge
//şeklinde olmalıdır ve dünün toplam gelirini hesaplamalıdır.)





Console.WriteLine("Park Yeri ÜcretiHesaplanması\n\nKaç Kişi Park Etti:");
double n = Convert.ToInt32(Console.ReadLine());

double totalParkingHours = 0;
double totalPay = 0;

int errorFlag = 0;  


for (double i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}. Araç Kaç Saat Park Etti:");
    double parkingHours = Convert.ToInt32(Console.ReadLine() + "\n");

    double pay = 0 ;
    
    errorFlag = 0;
    
   
   
        if (0 < parkingHours && parkingHours <= 3)


        {
            pay = 2;
            Console.WriteLine($"{i}. Araç Park Ücreti: {pay}\n");

        }

        else if (3 < parkingHours && parkingHours <= 19)


        {
            pay = 2 + ((parkingHours - 3) * 0.5);
            Console.WriteLine($"{i}. Araç Park Ücreti:{pay} $\n");
        }

        else if (19 < parkingHours && parkingHours <= 24)
        {
            pay = 10;
            Console.WriteLine($"{i}. Araç Park Ücreti:{pay}\n");
        }

        else
        {
            Console.WriteLine($"Yanlış Değer Girdiniz!!!");
            errorFlag = 1;
        i = i - 1;


    }
        if ( errorFlag == 0)
    {
        totalParkingHours += parkingHours;

        totalPay += pay;
    }
    
    
    
}



Console.WriteLine($"\nToplam Park Saati: { totalParkingHours}" );
Console.WriteLine($"Toplam Ücret: {totalPay}");

Console.ReadLine();
Console.ReadLine();
*/


/* // Palindrome Sayısı  Bulma
    int num, rev, sum = 0, temp;
    Console.Write("Enter the number: ");
    num = int.Parse(Console.ReadLine());
    temp = num;
    while (num > 0) // 414
    {
        rev = num % 10;         // 4          //1.4                //4,14
        sum = (sum * 10) + rev; // 4          //4*10 +1,4 = 41,4   //41,4 *10 +4,14
        num = num / 10;         //41.4        //4.14               //
    }
    if (temp == sum)
        Console.Write("Yay! the given number is Palindrome.");
    else
        Console.Write("Oops! the given number is not Palindrome.");
Console.ReadLine();
Console.ReadLine();
*/


//***************************************************************************************************************************

// 2. HAFTA

/* //Array List
using System.Collections;
ArrayList myList = new ArrayList();
string test = "deneme";
int a = 5;
char x = 'A';  

myList.Add(x);
myList.Add(a);
myList.Add(test);

// Console.WriteLine(myList[2]);


foreach (object o in myList)
{
    Console.WriteLine(o);

}
*/


/* // Hashtable Oluşturma
 
using System.Collections;

Hashtable ht = new Hashtable();
ht.Add ("ora", "oracle");
ht.Add ("vb", "vb.net");
ht.Add ("cs", "cs.net");
ht.Add ("asp", "asp.net");

foreach (DictionaryEntry d in ht)
{
    Console.WriteLine(d.Key + " " + d.Value);

}
*/


/* // Key Ve Value Değerleri

//Sıralama Yapar

using System.Collections;

SortedList sl = new SortedList();
sl.Add("ora", "oracle");
sl.Add("vb", "vb.net");
sl.Add("cs", "cs.net");
sl.Add("asp", "asp.net");

foreach (DictionaryEntry d in sl)
{
    Console.WriteLine(d.Key + " " + d.Value);

}
*/


//13.08.2023 (Pazar)


/* // Diziler (Burda Sorulacak Sorum Var)
using System.Collections;

int[] numberList = new int[10];

for(int i = 0; i < 10; i++)

{
    Console.WriteLine((i+1)  + " Numaralı Sayıyı Giriniz.");
    int number = Convert.ToInt32(Console.ReadLine());
    numberList[i] = number;
}

Console.WriteLine("Girilen Sayılar");
foreach (int number in numberList )
{
    Console.WriteLine(number);
}
Console.ReadLine();
*/


/* // Dizi Örneği (For Döngüsüyle)
using System.Collections;

int[] numberList = new int[10];

for (int i = 0; i < 10; i++)

{
    Console.WriteLine((i + 1) + " Numaralı Sayıyı Giriniz.");
    int number = Convert.ToInt32(Console.ReadLine());
    numberList[i] = number;
}
for (int i = 9; i >= 0; i--)

{
    Console.WriteLine("\nSayıların Tersten Yazılışı\n" numberList[i]);
}
Console.ReadLine();

*/


/* // Sınıfta Çözdüğümüz Kapsamlı Örnek

using System.Collections;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("1. Sınıf Mevcudunu Giriniz?:");
int class1 = Convert.ToInt32(Console.ReadLine());
string[] class1NameList = new string[class1];


for (int i = 0; i < class1; i++)

{
    Console.WriteLine((i+1) + ". Öğrenci İsmi");
    string name1 = Convert.ToString(Console.ReadLine());
    class1NameList[i] = name1;

}


Console.WriteLine("2. Sınıf Mevcudunu Giriniz?:");
int class2 = Convert.ToInt32(Console.ReadLine());
string[] class2NameList = new string[class2];

for (int i = 0; i < class2; i++)

{
    Console.WriteLine((i+1) + ". Öğrenci İsmi");
    string name2 = Convert.ToString(Console.ReadLine());
    class2NameList[i] = name2;
}


    //int total = class1NameList.Length + class2NameList.Length;
    //string[] class3 = new string[total];
    string[] merged = class1NameList.Concat(class2NameList).ToArray();  

foreach (string name in merged)
{
    Console.WriteLine(name);
}

if ((class1NameList.Length < 5 || class2NameList.Length < 5) && (class1NameList.Length > 15 || class2NameList.Length > 15))
{
    int class3 = merged.Length / 2;
    Console.WriteLine(class3);
}


if ((class1NameList.Length < 5)
{
    clas
}

Console.ReadLine();*/


/* // Asal Çarpanları Bulma
 {


Console.Write("1 ile 1000 Arasındaki Mükemmel Sayıları Bulmak İçin ENTER'a Basınız... \n");
Console.ReadLine();


int sumOfFactors = 1;
Console.Write("1\n");

for (int j = 2; j <= 29; j++)
{
Console.WriteLine("Girilen Sayı:" + j);
Console.WriteLine("1");
int n1 = j;
int n2 = j;
int i = 2;

while (n1 != 1)
{
if (n1 % i == 0)
{
Console.WriteLine("{0} ", i);
sumOfFactors += i;
n1 /= i;
}
else
{
i++;
}
}

Console.WriteLine("Sayının Çarpanlarının Toplamı: " + sumOfFactors + "\n");

if (j == sumOfFactors)
{
Console.WriteLine((j) + " mükemmel sayıdır..." + "\n");
}
else
{
Console.WriteLine();
}
sumOfFactors = 1;

}
}
Console.WriteLine();*/


//ÖDEVLER (2. Hafta) 

/* // 1. Soru
//Kendi bilgisayarınızın ne kadar hızlı çalıştığını nasıl anlayabilirsiniz? 1‘ den 3,000,000 e
//kadar sayan bir while döngüsü içeren bir program yazınız. Sayacınız 1,000,000’in her
//katında ekrana bu sayıyı yazdırsın. Saatinizi kullanarak her bir milyonluk döngünün ne
//kadar zamanda çalıştığını ölçün.

using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;

Console.WriteLine("*********************************** 1.  Soru ****************************************\n\n");

Console.WriteLine( "Başlatmak İçin ENTER'a basınız...");
Console.ReadLine();
int a = 0;
Stopwatch watch1 = new Stopwatch();
Stopwatch watch2 = new Stopwatch();

watch2.Start();

while (a <= 3000000)
{
    a++;

    if (a == 1000000 || a == 2000000 || a == 3000000 )
    {
        watch1.Start();
        Console.WriteLine(a);
        watch1.Stop();
        Console.WriteLine("Bağlantı  süresi: {0}", watch1.Elapsed.TotalSeconds + " saniye\n");
    }
}

watch2.Stop();
Console.WriteLine("\n\nToplam Bağlantı  süresi: {0}", watch2.Elapsed.TotalSeconds + " saniye\n");

Console.WriteLine("***************************************************************************\n\n");

Console.ReadLine();
*/


/*// 2. Soru
//bir şirket bazı verilerini telefon aracılığıyla başka bir yere iletmek istemektedir ama
//telefonlarının dinlendiğinden kuşkulanmaktadırlar. bütün veriler dört basamaklı tamsayılar
//şeklinde iletilecektir. size verilen görev ise bu verileri daha güvenli bir şekilde iletilmeleri
//için şifrelemenizdir. programınız şifrelemeyi şu şekilde yapmalıdır:
//her basamağı 7 ile toplamının 10‘luk sistemdeki eşitiyle ve birinci basamağı üçüncü
//basamak, ikinci basamağı da dördüncü basamak ile yer değiştirmelisiniz. bu şifrelenmiş
//sayıları alan ve eski haline getiren başka bir programda yazınız.




using System.Collections;

Console.WriteLine("*********************************** 2.  Soru ****************************************\n\n");
Console.WriteLine("4 Basamaklı Veriyi Giriniz:");
Console.Read();
*/


/*//3. Soru
//2'den 30'a kadar olan çift tamsayıların toplamını hesaplayan ve ekrana yazdıran bir
//program yazınız.
using System.Collections;

Console.WriteLine("*********************************** 3.  Soru ****************************************\n\n");

Console.WriteLine("2'den 30'a Kadar Olan Çift Sayıların Toplamını Hesaplayınız...\nBaşlatmak İçin ENTER'a basınız...");
Console.ReadLine();

int sum = 0;    

for (int i = 2; i <= 30; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine("2'den 30'a Kadar Olan Çift Sayıların Toplamı:" + sum);

Console.WriteLine("\n\n***************************************************************************\n\n");
Console.ReadLine();
*/


/*//4. Soru
//Eğer bir sayının kendisi hariç, bütün çarpanlarının toplamı yine o sayıya eşitse bu
//sayıya MÜKEMMEL SAYI denir. Örneğin, 6 bir mükemmel sayıdır. Çünkü 6 = 1 + 2 +
//3. mukemmel isminde, sayi parametresinin mükemmel bir sayı olup olmadığını tespit
//eden bir program yazınız. Bu program 1-1000 arasındaki tam sayılardan mükemmel
//olanlarını bulmak için bir program içinde kullanınız. Program sayının mükemmel
//olduğunu göstermek için mükemmel sayınının çarpanlarını ekrana yazdırsın. 1000‘den
//daha büyük sayıları test ederek bilgisayarınızın gücünü deneyebilirsiniz



{

    Console.WriteLine("*********************************** 4.  Soru ****************************************\n\n");
    Console.Write("1 ile 1000 Arasındaki Mükemmel Sayıları Bulmak İçin ENTER'a Basınız... \n");
    Console.ReadLine();
       
    int sumOfFactors = 0;

    for (int j = 2; j <= 1000; j++)
    {
              
       for (int k = 1; k < j; k++)
        {
            if (j % k == 0)
            {
               sumOfFactors += k;
            }
        }
       
        if (j == sumOfFactors)
        {
           Console.Write((j) + " sayısı mükemmel sayıdır..." + "\n" + (j) + " Sayısının Çarpanları: ");
           for (int l = 1; l < j; l++)
            {
                if (j % l == 0)
                {
                    Console.Write("{0} ", l);

                }
            }
            Console.WriteLine("\n");
        }
        
    sumOfFactors = 0;   

    }
}
Console.WriteLine("***************************************************************************\n\n");
    Console.WriteLine();

*/


/*//5. Soru
//Bilgisayarların eğitimde sürekli artan bir rolü vardır. Bir ilkokul öğrencisine çarpma
//işleminde yardımcı olacak bir program yazınız. Kullanıcıdan 2 adet 1 basamaklı sayı
//isteyin ve ekrana şu şekilde bir soru yazdırın: 4 kere 7 kaçtır ? Daha sonra öğrenci cevap
//versin. Program cevabı kontrol etsin. Eğer cevap doğruysa "Çok güzel" yazdırsın ve yeni
//bir soru sorsun. Eğer cevap yanlışsa "lütfen tekrar deneyin." yazdırsın ve aynı soruyu
//öğrenci doğru cevap verene kadar sorsun.


using System;
Console.WriteLine("*********************************** 5.  Soru ****************************************\n");
Console.Write("Çarpım Tablosu\n\n");

while (true)
{
    Console.Write("1. Sayıyı Giriniz: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
 

    Console.Write("2. Sayıyı Giriniz: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine((n1) + " kere " + (n2) + " kaçtır?");
    Console.Write("Cevap: ");

    int answer1 = Convert.ToInt32(Console.ReadLine());
    int result = n1 * n2;
    
    if (result != answer1)
    {
        while (result != answer1)
        {
            Console.WriteLine("Lütfen Tekrar Deneyin\n");
            Console.WriteLine((n1) + " kere " + (n2) + " kaçtır?");
            Console.Write("Cevap: ");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            answer1 = answer2;
        }
        Console.WriteLine("Çok Güzel\n");
    }
    else
    {
        Console.WriteLine("Çok Güzel\n");
    }
}
//Console.WriteLine("***************************************************************************\n\n");
*/


/*//6. Soru
//Bir dizideki tüm tekrarlı sayıları kaldıran ve güncelleyen bir programı yazın


using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("*********************************** 6.  Soru ****************************************\n\n");
int[] numberList1 = { 5,9,6,8,9,8,2,3,4,6,5,9,7,8,9,5,7,1,12,25,78,25 };
int size = numberList1.Length;

Console.Write("Dizi: ");

foreach (int a in numberList1)
{
    Console.Write(a + "  ");
}

Console.WriteLine();


for (int i = 0; i < size; i++)
{
     for (int j = i+1; j < size; j++)
    {
        if (numberList1[i] == numberList1[j] )
        {
            for (int k = j; k < size - 1; k++)
            {
               numberList1[k] = numberList1[k + 1];
            }
            size--;
          
        }
    }
}
Console.Write("\n\nDizide Tekrar Eden Elemanlar Çıkarıtılınca: ");
for (int i = 0;i < size; i++)
{
    Console.Write(numberList1[i] + "  ");
}
Console.WriteLine();

Console.WriteLine("\n\n\n***************************************************************************");
*/


/*//7. Soru
//Bir sayı dizisindeki tüm asal sayıların toplamını hesaplayan C# Sharp programı yazın.


Console.WriteLine("*********************************** 7.  Soru ****************************************\n\n");
using static System.Runtime.InteropServices.JavaScript.JSType;



int[] numberList = { 6, 5, 12, 97, 101, 156, 19, 88, 46,73,91,23,123,75,103 };
Console.Write("Dizi : ");

foreach (var number in numberList)
{
    Console.Write(number + "  ");
}

Console.WriteLine("\n\nDizideki Asal Sayıların Toplamını Bulmak İçin ENTER'a Basınız... ");
Console.ReadLine();
int sumOfPrimeNumbers = 0;


for (int i = 0; i < numberList.Length; i++)
{
    int n1 = numberList[i];
    
    for (int j = 2; j < n1; j++)
    {
        if (n1 % j == 0)
        {
            numberList[i] = 0;
        }
 
        
    }


}

Console.Write("Dizi : ");

foreach (var number in numberList)
{
    Console.Write(number + "  ");
}

for (int k = 0; k < numberList.Length; k++)
{
    sumOfPrimeNumbers += numberList[k];
}

Console.WriteLine("\nDizideki Tüm Asal Sayıların Toplamı:" + sumOfPrimeNumbers);

Console.WriteLine("*************************************************************");
*/


/*//8. Soru
//Bir sayı dizisindeki tüm asal sayıların toplamını hesaplayan C# Sharp programı yazın.


using System;

Console.WriteLine("*********************************** 8.  Soru ****************************************\n\n");

Console.Write("Kaç Adet Sayı Girilecek:");
int size = Convert.ToInt32(Console.ReadLine());
int [] numberList = new int[size];

for (int k = 0; k < numberList.Length; k++)

{
    Console.Write((k + 1) + ". Sayı:");
    int number = Convert.ToInt32(Console.ReadLine());
    numberList[k] = number;

}


Console.Write("\nDizi : ");
foreach (var number in numberList)
{
    Console.Write(number + "  ");
}

int smallestNumber = numberList[0];
int largestNumber = numberList[1];


 for (int i = 0; i < numberList.Length ; i++)
 {
    if (smallestNumber > numberList[i])
    {
            smallestNumber = numberList[i];
    }          
 }

for (int j = 0; j < numberList.Length; j++)
{
    if (largestNumber < numberList[j])
    {
        largestNumber = numberList[j];
    }
}




Console.WriteLine("\n\nEn Küçük Sayı : " + smallestNumber);
Console.WriteLine("En Büyük Sayı : " + largestNumber);

Console.WriteLine("\n\n\n\n***************************************************************************");
*/

