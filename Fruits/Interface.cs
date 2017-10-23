namespace Fruits
{
    interface IFruitVeget
    {
        void SetName();
        void SetWhere(string where);
        void SetPrice(int price); 
    }

    class BasePlant
    {
        protected string _name = "";
        protected string _where = "";
        protected int _price = 0;

        public string name { get { return _name; } }
        public string where { get { return _where; } }
        public int price { get { return _price; } }


    }

    class IApple:BasePlant,IFruitVeget
    {
        public void SetName()  // Жестко заданное значение
        {
            _name = "Яблоко";
        }

        public void SetWhere(string where = "Сад") //параметр со значением переменной по умолчанию
        {
            _where = where;
        }

        public void SetPrice(int price)
        {
            _price = price;
        }
    }
    class IBerry:BasePlant,IFruitVeget
    {
        public void SetName()
        {
            _name = "Ягода";
        }

        public void SetWhere(string where) 
        {
            _where = where;
        }

        public void SetPrice(int price)
        {
            _price = price;
        }
    }
    class IPotato: BasePlant, IFruitVeget
    {
        public void SetName()
        {
            _name = "Картошка";
        }

        public void SetWhere(string where = "Поле")
        {
            _where = where;
        }

        public void SetPrice(int price = 450)
        {
            _price = price;
        }
    }
    class ITomato: BasePlant, IFruitVeget
    {
        public void SetName()
        {
            _name = "Помидор";
        }

        public void SetWhere(string where = "Грядка")
        {
            _where = where;
        }

        public void SetPrice(int price = 120)
        {
            _price = price;
        }
    }
}
