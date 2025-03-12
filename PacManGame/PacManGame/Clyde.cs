using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PacManGame
{
    class Clyde
    {
        
        public void Movement()
        {
            var rand = new Random();
            int choice = rand.Next(1,3);
            if (choice == 1)
                Console.WriteLine("Clyde se mueve aleatoriamente");
            else if (choice == 2)
                Console.WriteLine("Clyde persigue a PacMan");
        }



    }
}
