// Atama ve işlemli atama
int x = 3;
int y = 4;

y = y + 2 ; 
Console.WriteLine(y);
y+=2;
Console.WriteLine(y);
y/=2;
Console.WriteLine(y);
x-=1;
Console.WriteLine(x);

// Mantıksal Operatörler
// ||, &&, ! 

bool isSucces = true;
bool isCompleted = false;

if(isCompleted&&isSucces)
    Console.WriteLine("Perfect");

if(isCompleted||isSucces)
    Console.WriteLine("Fine");

if(!isCompleted&& isSucces)
    Console.WriteLine("Great");


 //İlişkisel Operatörler

 int a = 3 ; 
 int b = 5 ; 
 bool sonuc = a<b; 

Console.WriteLine(sonuc);   
sonuc = a>b;
Console.WriteLine(sonuc);   
sonuc = a<=b;
Console.WriteLine(sonuc);   
sonuc = a>=b;
Console.WriteLine(sonuc);   
sonuc = a==b;
Console.WriteLine(sonuc);   
sonuc = a!=b;
Console.WriteLine(sonuc);   

//Aritmetik Operatörler
// +,-,*,/

int sayi1 = 6;
int sayi2 = 4;
int sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1);   
sonuc1 = sayi1 - sayi2;
Console.WriteLine(sonuc1);   
sonuc1 = sayi1 * sayi2 ;
Console.WriteLine(sonuc1);   
sonuc1 = sayi1 / sayi2 ; 
Console.WriteLine(sonuc1);   

// % mod alma 

int sonuc2 = 20%3; 
Console.WriteLine(sonuc2);   





