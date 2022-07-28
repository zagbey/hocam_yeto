// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Atama ve işlemli atama

int x = 3;
int y = 3;

y = y+2; // y'yi 2 arttırıyor 
Console.WriteLine(y);

y +=2;
Console.WriteLine(y);

// mantıksal operatörler 
// || && !

bool isSuccess = true;
bool isCompleted = false ;

if(isSuccess && isCompleted)// VE, her ikisinin de sağlanmasını bekler
    Console.WriteLine("perfeckt");

if(isSuccess || isCompleted)// veya ,her ikisinden birisi true ise 
    Console.WriteLine("Great");

if(isSuccess && isCompleted)// success ve completed değilse 
    Console.WriteLine("Fine");

//İlişkisel operatörler 
// <,> <=,>=,== != eşit değildir 
int a = 3;
int b = 4;
bool sonuc = a<b;

Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc); 

//Aritmetik operatörler
// /,*,+,-

int sayi=10;
int sayi1 = 5;
int sonuc1= sayi/sayi1;
Console.WriteLine(sonuc1);
sonuc1 = sayi*sayi1;
sonuc1 = sayi1++ ;
Console.WriteLine(sonuc1);

// % mod almak için kullanılıyor 

int sonuc2 = 20%3;
Console.WriteLine(sonuc2);





