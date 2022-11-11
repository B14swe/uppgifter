using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassdiagram
{
    public class Djur
    {
    
        private int legs;
        private int weight;


        public int Getlegs() { return this.legs; }
        public int GetWeight() { return this.weight; }

        public void Setlegs(int legs) { this.legs = legs; }
        public void SetWeight(int weight) { this.weight = weight; }
        public class Hund : Djur
        {
            private string name;

            public void SetName(string name) { this.name = name; }

            public string GetName() { return this.name; }
            public void woof()
            {
                Console.WriteLine(name + " " + "woofed");
            }

            public void walk()
            {
                Console.WriteLine(name + " " + "walked with his " + legs + " legs");
            }
        }

    }
}
