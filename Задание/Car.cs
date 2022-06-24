using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Задание {
    internal class Car {
        private string car_brand;
        private string car_class;
        private int weight;
        private Driver driver;
        private Engine engine;
        public Car(string driver_first_name = "", string driver_surname = "", string driver_patronymic = "", int driver_driving_experience = 0,
            int engine_power = 0, string engine_manufacture = "", 
            string car_brand = "", string car_class = "", int weight = 0) {

            driver = new Driver(driver_first_name, driver_surname, driver_patronymic, driver_driving_experience);
            engine = new Engine(engine_power, engine_manufacture);
            this.car_brand = car_brand;
            this.car_class = car_class;
            this.weight = weight;
        }


        public void start() {
            Console.WriteLine("Поехали");
        }
        public void stop() {
            Console.WriteLine("Останавливаемся");
        }
        public void tern_right() {
            Console.WriteLine("Поворот направо");
        }
        public void tern_left() {
            Console.WriteLine("Поворот налево");
        }
        public new void ToString() {
            Console.WriteLine(car_brand);
            Console.WriteLine(car_class);
            Console.WriteLine(weight);
            driver.info();
            engine.info();
        }

    }
}
