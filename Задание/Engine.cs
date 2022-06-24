using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание {
    internal class Engine {
        private int power;
        private string manufacture;
        public Engine(int power, string manufacture) {
            this.power = power;
            this.manufacture = manufacture;
        }
        public void info() {
            Console.WriteLine(power);
            Console.WriteLine(manufacture);
        }
    }
}
