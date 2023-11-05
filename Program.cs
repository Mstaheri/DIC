// See https://aka.ms/new-console-template for more information
using DIC;

Console.WriteLine("Hello, World!");
MyDIC dic = new MyDIC();
dic.Add<KaveNegar>();
dic.Add<IranPayamak>();
var a = dic.Resolve<KaveNegar>();
a.SendSms("AAAA");
Console.ReadLine();