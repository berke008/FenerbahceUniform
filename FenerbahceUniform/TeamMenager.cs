using System;
using System.Collections.Generic;
using System.Text;

namespace FenerbahceUniform
{
    class TeamMenager
    {
        //naming convention -- 
        //Eğer bir yerde () varsa orada metot vardır.
        public void Add(Player player) 
        {
            Console.WriteLine("Congrats! New Transfer: " + player.Number + " number "+ player.Name + " :) ");
        }

    }
}
