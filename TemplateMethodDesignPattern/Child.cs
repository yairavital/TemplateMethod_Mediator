using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    internal class Child : ExerciseBase
    {
        public Child()
        {
            name = "child";
        }
        public override void Game()
        {
            Console.WriteLine("The game is basketball");
        }

        public override void Run()
        {
            Console.WriteLine("You needs to run 500 m");
        }

        public override void Training()
        {
            Console.WriteLine("The training is about 5 minutes");
        }
    }
}
