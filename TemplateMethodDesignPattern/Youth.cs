using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    internal class Youth : ExerciseBase
    {
        public Youth()
        {
            name = "Youth";
        }

        public override void Game()
        {
            Console.WriteLine("The game is handball");        }

        public override void Run()
        {
            Console.WriteLine("You needs to run 1000 m");
        }

        public override void Training()
        {
            Console.WriteLine("The training is about 10 minutes");
        }
    }
}
