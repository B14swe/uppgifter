using System;
using klassdiagram;
Djur.Hund harry = new Djur.Hund();

harry.SetName("harry");
harry.Setlegs(4);
harry.woof();
harry.walk();
harry.SetWeight(30);
Console.WriteLine((harry.GetWeight()));
Console.WriteLine(harry.Getlegs());