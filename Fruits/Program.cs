using System;


namespace Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Демонстрация работы первого задания ***/
            Apple apple;
            Berry berry;
            Fruit f_berry;

            apple = new Apple(240, "яблоня", "антоновка", 10);
            berry = new Berry("Крыжовник", form.ROUND, 150, "куст", color.GREEN, "август");
            /* Демонстрация динамического полиморфизма */
            f_berry = berry;

            Console.WriteLine(apple.name + " " + apple.shape + " " + apple.cost + " " + apple.where + " " + apple.kind + " " + apple.size);
            Console.WriteLine(berry.name + " " + berry.shape + " " + berry.cost + " " + berry.where + " " + berry.color + " " + berry.date);

            Console.WriteLine(berry.info());
            Console.WriteLine(f_berry.info());

            /*** Демонстрация задания части 3 Анкета ***/

            /* Создаем анкетирвемых */
            Questioned Ivanof = new Questioned("Иванов", 3, 518);
            Questioned Petrof = new Questioned("Петров", 2, 214);
            Questioned Sidorof = new Questioned("Сидоров", 1, 84);

            /* Создаем пару студент-преподаватель */
            Interviewer Zakharov_1 = new Interviewer(Ivanof, "Захаров");
            Interviewer Zakharov_2 = new Interviewer(Petrof, "Захаров");
            Interviewer Simonchuk = new Interviewer(Sidorof, "Симончюк");

            /* --- Первый экзаменуемый у Захарова --- */
            Console.WriteLine("\n\nЭкзамен для студента " + Zakharov_1.person.nameStudent + ", " 
                + Zakharov_1.person.course + " курса, " + Zakharov_1.person.group + " группы.");
            Zakharov_1.whichStar();
            Zakharov_1.whichPlanet();
            Zakharov_1.isPluto();

            /* --- Второй экзаменуемый у Захарова --- */
            Console.WriteLine("\n\nЭкзамен для студента " + Zakharov_2.person.nameStudent + ", "
                + Zakharov_2.person.course + " курса, " + Zakharov_2.person.group + " группы.");
            Zakharov_2.whichStar();
            Zakharov_2.whichPlanet();
            Zakharov_2.isPluto();

            /* --- Первый экзаменуемый у Симончук --- */
            Console.WriteLine("\n\nЭкзамен для студента " + Simonchuk.person.nameStudent + ", "
                + Simonchuk.person.course + " курса, " + Simonchuk.person.group + " группы.");
            Simonchuk.whichStar();
            Simonchuk.whichPlanet();
            Simonchuk.isPluto();

            /*** Проверяем результаты ***/
            Tutor.checkTest(Zakharov_1);
            Tutor.checkTest(Zakharov_2);
            Tutor.checkTest(Simonchuk);




            return;
        }
    }
}
