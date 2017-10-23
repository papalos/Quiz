using System;

namespace Fruits
{
    /****** Класс шаблон представляющий поля для сохранения ответов и методы доступа к ним, объект создать невозможно *******/
    abstract class Answers
    {
        private string _sun = "";
        private string _mars = "";
        private string _pluto = "";

        public string sun { set { _sun = value; } get { return _sun; } }
        public string mars { set { _mars = value; } get { return _mars; } }
        public string pluto { set { _pluto = value; } get { return _pluto; } }
    }

    /******** На каждого отвечающего будет создаваться свой класс хранящий имя курс и группу опрашиваемого *********/
    class Questioned : Answers
    {
        private string _nameStudent;
        private int _course;
        private int _group;
        
        public Questioned(string nameStudent, int course, int group)
        {
            _nameStudent = nameStudent;
            _course = course;
            _group = group;
        }

        public string nameStudent { get => _nameStudent; }
        public int course { get => _course; }
        public int group { get => _group; }
    }

    /******* Методы с вопросами и заполняющие поля анкетируемого *********/
    interface Questions
    {
        void whichStar();
        void whichPlanet();
        void isPluto();
    }

    /***** получает опрашиваемого и заполняет все его поля
     * с вопросами из интерфейса, присутстует имя преподавателя *****/
    class Interviewer : Questions
    {
        private Questioned _person;
        private string _nameTeacher;

        public Interviewer(Questioned person, string nameTeacher)
        {
            _person = person;
            _nameTeacher = nameTeacher;
        }

        public Questioned person { get { return _person; } }
        public string nameTeacher { get { return _nameTeacher; } }

        public void whichStar()
        {
            Console.WriteLine("\nЦентральная звезда планетарной системы в которую входит земля?");
            _person.sun = Console.ReadLine().ToLower().Replace(" ","");
        }
        public void whichPlanet()
        {
            Console.WriteLine("\nЧетвертая планета от Солнца?");
            _person.mars = Console.ReadLine().ToLower().Replace(" ", "");
        }
        public void isPluto()
        {
            Console.WriteLine("\nКакую планету Солнечной системы пытались лишить статуса планеты?");
            _person.pluto = Console.ReadLine().ToLower().Replace(" ", "");
        }
    }

    /***** Статический класс который осуществляет проверку и выводит результат *****/
    static class Tutor
    {
        static public void checkTest(Interviewer tutor)
        {
            int rating = 0;
            if(tutor.person.sun == "солнце") { rating++;}
            if (tutor.person.mars == "марс") { rating++; }
            if (tutor.person.pluto == "плутон") { rating++; }

            Console.WriteLine("\nРейтинг студента " + tutor.person.nameStudent + ": " + rating);
            Console.WriteLine("\nОпросил и проверил " + tutor.nameTeacher);
        }
    }

}