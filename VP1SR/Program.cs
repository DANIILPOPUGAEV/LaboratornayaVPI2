namespace VP1SR
{
    class smartphone
    {
        public string Model { get; set; }
        public double frequency { get; set; }
        public int RAM { get; set; }
        public int ROM { get; set; }
        public string TypeOS { get; set; }
        public int Massa { get; set; }
        public void Info()
        {

            Console.Write("Модель: ");
            Console.WriteLine(Model);
            Console.Write("Показатель частоты: ");
            Console.WriteLine(frequency);
            Console.Write("Объем оперативной памяти: ");
            Console.WriteLine(RAM);
            Console.Write("Объем постоянной памяти: ");
            Console.WriteLine(ROM);
            Console.Write("Тип операционной системы: ");
            Console.WriteLine(TypeOS);
            Console.Write("Масса: ");
            Console.WriteLine(Massa);
        }
        public smartphone(string Model, double frequency, int RAM, int ROM, string TypeOS, int Massa)
        {
            this.Model = Model;
            this.frequency = frequency;
            this.RAM = RAM;
            this.ROM = ROM;
            this.TypeOS = TypeOS;
            this.Massa = Massa;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            smartphone smartphone = new smartphone("Xxx", 2.6, 4, 128, "Android", 1);
            smartphone.Info();
        }
    }
}