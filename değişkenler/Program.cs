// See https://aka.ms/new-console-template for more information

byte b= 5;
sbyte c= 5;
short s= 6;
ushort us= 8;

int i16= 1;
int i = 2;
int i32 = 312;
int i64= 546;
uint ui= 23;
long l= 54;
ulong ul= 12;

float f= 5;
double d= 3.4;
decimal de= 4.675464M;

char ch= '2';
string str1= "furkan";

bool dogru= true;
bool yanlis= false;

DateTime dt=DateTime.Now;
Console.WriteLine(dt);

object o1= "xtyt";
object o2= "a";
object o3= 3;
object o4= 4.65;

string str2 = string.Empty;
str1= "Furkan öztürk";
string isim= "furkan";
string soyi="öztürk";
string ad_soyad= isim + " "+soyi;

int sayi1= 3;
int sayi2 = 15;
int islem1= sayi1*sayi2;
int islem2= sayi2/sayi1;
Console.WriteLine(islem1);
Console.WriteLine(islem2);

string str20= "20";
int int20= 20;
string yenideger= str20+ int20.ToString();
Console.WriteLine(yenideger);

int int21= int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22= int20+ int.Parse(str20);


string datetime= DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string hour= DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour);



