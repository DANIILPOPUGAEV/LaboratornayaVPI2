namespace VPIEX2
{
    class exp
    {
        public string p { get; set; } // Поле

        //Конструкторы
        public exp() { p = "<3"; } // Без параметра
        public exp(string l) { p = l; } // С параметром
        public exp(exp copy) { p = copy.p; } // Копирующий
        public exp Clone() { return new exp(p); } // Метод клонирования
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Эксперимент 1");
                Console.WriteLine();
                // Первый объект
                Console.Write("Введите информацию: ");
                string s = Console.ReadLine();
                Console.WriteLine();
                exp Object1 = new exp(s);
                Console.WriteLine(Object1.p);
                // Второй объект
                exp Object2 = new exp();
                Console.WriteLine(Object2.p);
                // Третий объект
                exp Object3 = new exp(Object1);
                Console.WriteLine(Object3.p);
                // Четвёртый объект
                exp Object4 = Object2.Clone();
                Console.WriteLine(Object4.p);
                Console.WriteLine();
                Console.WriteLine("Эксперимент 2");
                Console.WriteLine();

                // Пятый объект
                Console.Write("Введите информацию: ");
                string v = Console.ReadLine();
                Console.WriteLine();
                exp Object5 = new exp(v);

                // Создается коллекция
                List<exp> Listochec = new List<exp>();
                Listochec.Add(Object1);
                Listochec.Add(Object2);
                Listochec.Add(Object3);
                Listochec.Add(Object4);
                Listochec.Add(Object5);
                foreach (exp objects in Listochec)
                {
                    Console.WriteLine(objects.p);
                }
                Console.WriteLine();

                Listochec.RemoveAt(1);
                Listochec.RemoveAt(3);

                foreach (exp objects in Listochec)
                {
                    Console.WriteLine(objects.p);
                }
                Console.ReadKey();
           

        }
    }
}