using KursALX.Lessons.M2.L2.Classes;
using KursALX.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();
            helloService.SayGoodMorning("Mateusz");
            helloService.SayGoodMorning();
            helloService.SayHello("Mateusz");
            helloService.SayHello();

            helloService = new Hello();
            helloService.SayGoodMorning("Mateusz");
            helloService.SayGoodMorning();
            helloService.SayHello("Mateusz");
            helloService.SayHello();
        }
    }
}
