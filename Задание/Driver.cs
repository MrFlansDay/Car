using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание {
    internal class Driver {
        private string first_name;
        private string surname;
        private string patronymic;
        private int driving_experience;
        public Driver(string first_name, string surname, string patronymic, int driving_experience) {
            this.first_name = first_name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.driving_experience = driving_experience;
        }
        public void info() {
            Console.WriteLine(first_name);
            Console.WriteLine(surname);
            Console.WriteLine(patronymic);
            Console.WriteLine(driving_experience);
        }
    }
}
