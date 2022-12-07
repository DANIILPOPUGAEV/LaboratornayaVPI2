class exp
{
    public string p { get; set; } // Поле

    //Конструкторы
    public exp() { p = "<3"; } // Без параметра
    public exp(string l) { p = l; } // С параметром
    public exp(exp copy) { p = copy.p; } // Копирующий
    public exp Clone() { return new exp(p); } // Метод клонирования
}
class Program
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
        Console.ReadKey();
    }
}