
using System;

class NumberClass
{
    public int Value { get; set; }

    public NumberClass(int value) => Value = value;

    // Перегрузка операторов & и |
    public static NumberClass operator &(NumberClass a, NumberClass b)
        => new NumberClass(a.Value & b.Value);

    public static NumberClass operator |(NumberClass a, NumberClass b)
        => new NumberClass(a.Value | b.Value);

    // Перегрузка операторов true и false
    public static bool operator true(NumberClass obj)
        => obj.Value == 2 || obj.Value == 3 || obj.Value == 5 || obj.Value == 7;

    public static bool operator false(NumberClass obj)
        => obj.Value < 1 || obj.Value > 10;

    // Для удобства вывода
    public override string ToString() => Value.ToString();
}

class Program
{
    static void Main()
    {
        var num1 = new NumberClass(3);  // true
        var num2 = new NumberClass(8);  // false
        var num3 = new NumberClass(5);  // true

        Console.WriteLine($"num1: {num1}, num2: {num2}, num3: {num3}");
        Console.WriteLine();

        // Использование операторов && и ||
        if (num1 && num3)
            Console.WriteLine($"num1 && num3: true (оба истинные)");

        if (num1 || num2)
            Console.WriteLine($"num1 || num2: true (хотя бы один истинный)");

        if (!num2)
            Console.WriteLine($"!num2: true (num2 ложный)");
    }
}



/*
 

Задача 1
 

 static void Main(string[] args)
        {


            State state1 = new State { Population = 10_000_000, Area = 100_000 };
            State state2 = new State { Population = 15_000_000, Area = 120_000 };


            State state3 = state1 + state2;
            Console.WriteLine($"Объединенное государство: Население = {state3.Population}, Площадь = {state3.Area}");


            Console.WriteLine($"state1 > state2: {state1 > state2}");
            Console.WriteLine($"state1 < state2: {state1 < state2}");




        }

        class State
        {
            public decimal Population { get; set; }
            public decimal Area { get; set; }


            public static State operator +(State s1, State s2)
            {
                return new State
                {
                    Population = s1.Population + s2.Population,
                    Area = s1.Area + s2.Area
                };
            }


            public static bool operator >(State s1, State s2)
            {
                return s1.Population > s2.Population;
            }


            public static bool operator <(State s1, State s2)
            {
                return s1.Population < s2.Population;
            }


            public static bool operator >=(State s1, State s2)
            {
                return s1.Population >= s2.Population;
            }

            public static bool operator <=(State s1, State s2)
            {
                return s1.Population <= s2.Population;
            }
        }


    Задача 2


 class Bread
        {
            public int Weight { get; set; } // масса

            // Перегрузка оператора + в классе Bread
            public static Sandwich operator +(Bread bread, Butter butter)
            {
                return new Sandwich
                {
                    Weight = bread.Weight + butter.Weight
                };
            }
        }

        class Butter
        {
            public int Weight { get; set; } // масса
        }

        class Sandwich
        {
            public int Weight { get; set; } // масса
        }



        static void Main()
        {
            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };

            Sandwich sandwich = bread + butter;

            Console.WriteLine($" Ваш бутерброд шириной  в {sandwich.Weight}");  // Выведет 100
        }




Задача 3


using System;

// Определение интерфейсов
interface IFirst
{
    string Property { get; set; }
    int this[int index] { get; set; }
    void Method();
}

interface ISecond
{
    string Property { get; set; }
    int this[int index] { get; set; }
    void Method();
}

// Абстрактный класс
abstract class AbstractBase
{
    public abstract string Property { get; set; }
    public abstract int this[int index] { get; set; }
    public abstract void Method();
}

// Класс, реализующий абстрактный класс и интерфейсы с явной реализацией
class MyClass : AbstractBase, IFirst, ISecond
{
    private string _property;
    private int[] _data = new int[10];

    // Явная реализация свойства IFirst
    string IFirst.Property
    {
        get => _property + " (First)";
        set => _property = value;
    }

    // Явная реализация свойства ISecond
    string ISecond.Property
    {
        get => _property + " (Second)";
        set => _property = value;
    }

    // Реализация свойства из абстрактного класса
    public override string Property
    {
        get => _property;
        set => _property = value;
    }

    // Явная реализация индексатора IFirst
    int IFirst.this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }

    // Явная реализация индексатора ISecond
    int ISecond.this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }

    // Реализация индексатора из абстрактного класса
    public override int this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }

    // Явная реализация метода IFirst
    void IFirst.Method()
    {
        Console.WriteLine("Method from IFirst");
        Console.WriteLine($"Property: {Property}");
        Console.WriteLine($"Data[0]: {_data[0]}");
        _data[0] = 100;
        Console.WriteLine($"Data[0] after modification: {_data[0]}");
    }

    // Явная реализация метода ISecond
    void ISecond.Method()
    {
        Console.WriteLine("Method from ISecond");
        Console.WriteLine($"Property: {Property}");
        Console.WriteLine($"Data[1]: {_data[1]}");
        _data[1] = 200;
        Console.WriteLine($"Data[1] after modification: {_data[1]}");
    }

    // Реализация метода из абстрактного класса
    public override void Method()
    {
        Console.WriteLine("Method from AbstractBase");
        Console.WriteLine($"Property: {Property}");
        Console.WriteLine($"Data[2]: {_data[2]}");
        _data[2] = 300;
        Console.WriteLine($"Data[2] after modification: {_data[2]}");
        
        // Вызов методов интерфейсов через явную реализацию (можно через приведение)
        
        ((IFirst)this).Method();
        ((ISecond)this).Method();
        
        // Также можно вызвать свойства и индексаторы через приведение к интерфейсу:
        
        ((IFirst)this).Property = "Value for First";
        ((ISecond)this).Property = "Value for Second";

        Console.WriteLine($"After setting properties:");
        Console.WriteLine($"IFirst.Property: {((IFirst)this).Property}");
        Console.WriteLine($"ISecond.Property: {((ISecond)this).Property}");
        
        ((IFirst)this)[0] = 111;
        ((ISecond)this)[1] = 222;

        Console.WriteLine($"IFirst[0]: {((IFirst)this)[0]}");
        Console.WriteLine($"ISecond[1]: {((ISecond)this)[1]}");
        
     }
}

class Program
{
	static void Main()
	{
		MyClass obj = new MyClass();

		// Использование через объектную переменную:
		Console.WriteLine("Работа через объектную переменную:");
		obj.Property = "Object Property";
		Console.WriteLine($"obj.Property: {obj.Property}");

		obj[0] = 10;
		Console.WriteLine($"obj[0]: {obj[0]}");

		obj.Method();

		Console.WriteLine("\nРабота через интерфейсные переменные:");

		// Через интерфейс IFirst:
		IFirst firstInterface = obj;
		firstInterface.Property = "Interface First Property";
		Console.WriteLine($"firstInterface.Property: {firstInterface.Property}");
		firstInterface[5] = 55;
		Console.WriteLine($"firstInterface[5]: {firstInterface[5]}");
		firstInterface.Method();

		Console.WriteLine();

		// Через интерфейс ISecond:
		ISecond secondInterface = obj;
		secondInterface.Property = "Interface Second Property";
		Console.WriteLine($"secondInterface.Property: {secondInterface.Property}");
		secondInterface[7] = 77;
		Console.WriteLine($"secondInterface[7]: {secondInterface[7]}");
		secondInterface.Method();
		
	}
}














Задача 4












*/