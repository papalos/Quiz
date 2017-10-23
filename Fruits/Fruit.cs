namespace Fruits
{
    enum form { ROUND, OVAL, PEAR, OBLONG};
    enum color { GREEN, RED, YELLOW}

    /* В приложении  создать класс «Fruit». 
     * Описание класса должно содержать поля:
     * Где растет(protected)
     * Название(public)
     * Цена(private)
     * Форма(public)
     * Дописать в классе Fruit методы доступа к закрытым полям
     */

    class Fruit
    {
        protected string _where;
        public string name;
        private double _cost;
        public form shape;

        public Fruit(string name, form shape, double cost, string where)
        {
            this.where = where;
            this.name = name;
            this._cost = cost;
            this.shape = shape;

        }

        public double cost { set { _cost = value; } get { return _cost; } }
        public string where { set { _where = value; } get { return _where; } }

        public virtual string info()
        {
            return "Название фрукта: " + name 
                + ", имеет форму: " + shape 
                + ", прмерная стоимость на рынке: " + cost
                + ", растет: " + where;
        }

    }

    /* Описать два класса – наследника
     * (Apple  - яблоко и Berry - ягода, у которых появляются дополнительные характеристики):
     * Для яблока – сорт,  средний размер яблока,
     * Для ягоды – цвет (использовать перечисление), дата сбора урожая,
     * Для яблока и ягоды – bool поле, является ли корнеплодом
     * (инициализируется для Apple  и Berry по умолчанию значением false)
     */

    class Apple : Fruit
    {
        public string kind;
        public int size;
        public bool root_crop;

        public Apple(double cost, string where, string kind, int size):base("яблоко", form.ROUND, cost, where)
        {
            this.kind = kind;
            this.size = size;
            root_crop = false;
        }

        
            public override string info()
        {
            return "Название фрукта: " + name
                + ", имеет форму: " + shape
                + ", прмерная стоимость на рынке: " + cost
                + ", растет: " + where
                + ", сорт: " + kind 
                + ", размер: " + size;
        }
    }


    /**** Ягода ****/

    class Berry : Fruit
    {
        public color color;
        public string date;
        public bool root_crop;

        public Berry(string name, form shape, double cost, string where, color color, string date) : base(name, shape, cost, where)
        {
            this.color = color;
            this.date = date;
            root_crop = false;
        }

        public new string info()
        {
            return "Название фрукта: " + name
                + ", имеет форму: " + shape
                + ", прмерная стоимость на рынке: " + cost
                + ", растет: " + where
                + ", цвет: " + color 
                + ", дата сбора: " + date;
        }
        
    }

    class Vegetables
    {
        protected string _where;
        public string name;
        private double _cost;
        public form shape;

        public Vegetables(string name, form shape, double cost, string where)
        {
            this.where = where;
            this.name = name;
            this._cost = cost;
            this.shape = shape;

        }

        public double cost { set { _cost = value; } get { return _cost; } }
        public string where { set { _where = value; } get { return _where; } }


    }

    /* Описать два класса – наследника
     * (Apple  - яблоко и Berry - ягода, у которых появляются дополнительные характеристики):
     * Для яблока – сорт,  средний размер яблока,
     * Для ягоды – цвет (использовать перечисление), дата сбора урожая,
     * Для яблока и ягоды – bool поле, является ли корнеплодом
     * (инициализируется для Apple  и Berry по умолчанию значением false)
     */

    class Potatoes : Vegetables
    {
        public string kind;
        public int size;
        public bool root_crop;

        public Potatoes(string name, form shape, double cost, string where, string kind, int size) : base(name, shape, cost, where)
        {
            this.kind = kind;
            this.size = size;
            root_crop = true;
        }


    }

    class Tomato : Vegetables
    {
        public color color;
        public string date;
        public bool root_crop;

        public Tomato(string name, form shape, double cost, string where, color color, string date) : base(name, shape, cost, where)
        {
            this.color = color;
            this.date = date;
            root_crop = true;
        }


    }



}
