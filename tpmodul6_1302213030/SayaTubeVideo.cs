using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213030
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            playCount = 0;


        }

        public void increasePlayCount(int playCount)
        {
            this.playCount = playCount;
    
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID Video     : " + id);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("Play Count   : " + playCount);
        }
    }
 }

