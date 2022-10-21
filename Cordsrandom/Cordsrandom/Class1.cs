using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordsrandom
{
    public class Punkt
    {

		private int x;
		private int y;
		// kanske använda detta i klassen men fattar inte hur man gör sedan efter i program
		 /*static void main()
        {
			int[] arraycordsy = new int[10];

			// jagged arrays
			for (int i = 0; i < arraycordsy.Length; i++)
			{
				arraycordsy[i] = i;
			}


		}*/
		public int getX() { return this.x; }
		public int getY() { return this.y; }

		public void setX(int x) { this.x = x; }
		public void setY(int y) { this.y = y; }
	}
}
