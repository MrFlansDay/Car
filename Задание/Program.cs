using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Задание {
    internal class Program {
        static void Main(string[] args) {
            Car car = new Car();
            car.tern_left();
            car.tern_right();
            car.ToString();

        }
    }
}
