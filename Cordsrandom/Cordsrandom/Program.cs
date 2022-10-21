using System;
using Cordsrandom;


Punkt[] arraycordsx = new Punkt[10];
int[] arraycordsy = new int[10];

// jagged arrays
for(int i = 0; i < arraycordsy.Length; i++)
{
    arraycordsy[i] = i;
}

for (int i = 0; i < 10; i++)
{
    arraycordsy[i].setY(i);

}


for (int i = 0; i < arraycordsx.Length; i++) {
    arraycordsx[i] = new Punkt();
}

for (int i = 0; i < 10; i++)
{
    arraycordsx[i].setX(i);

}
Random rndm = new Random();

arraycordsx = arraycordsx.OrderBy(x => rndm.Next()).ToArray();
arraycordsy = arraycordsy.OrderBy(y => rndm.Next()).ToArray();

foreach (var i in arraycordsx)
{
    Console.Write(i.getX() + ",");
    Console.WriteLine(i.getY());
}



// var shuffledArraycords = arraycords.OrderBy(x => rndm.Next()).ToArray();

// Console.WriteLine(arraycords[i].getX() + arraycords[i].getY());