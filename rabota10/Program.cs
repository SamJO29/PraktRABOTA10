using System;

namespace rabota10
{
    internal class Program
    {
       
    }
}


//Задача1
 /*
        static void Main(string[] args)
        {
            State state1 = new State() { Population = 12312, Area = 124000 };
            State state2 = new State() { Population = 12232, Area = 125000 };

            State state3 = state1 + state2;

            bool isGreater = state1 > state2;
            bool NoGreater = state1 < state2;

            Console.WriteLine($"\nНаселение STATE1 : {state1.Population}");
            Console.WriteLine($"Население STATE2 : {state2.Population}");
            Console.WriteLine($"\nОбщее население state1,state2 : {state3.Population}");

            Console.WriteLine($"\nСравнение больше ли  население STATE1>STATE2 : {isGreater}");
            Console.WriteLine($"Сравнение меньше ли  население STATE1<STATE2 : {NoGreater}");

        }


        class State
        {

            public decimal Population { get; set; }
            public decimal Area { get; set; }

            public static  State operator +(State state1, State state2)
            {

                State newState=new State();
                newState.Population = state1.Population+state2.Population;
                newState.Area = state1.Area+state2.Area;
                return newState;


            }

            public static bool operator > (State state1, State state2)
            {
                return state1.Population > state2.Population;
            }

            public static bool operator <(State state1, State state2)
            {
                return state1.Population < state2.Population;
            }
        }*/



//Задача2
/*
class Bread
{
    public int Weight { get; set; }

    public static Sandwich operator +(Bread bread, Butter butter)
    {
        Sandwich sandwich = new Sandwich();
        sandwich.Weight = bread.Weight + butter.Weight;
        return sandwich;
    }
}

class Butter
{
    public int Weight { get; set; }
}

class Sandwich
{
    public int Weight { get; set; }
}

static void Main(string[] args)
{
    Bread bread = new Bread { Weight = 80 };
    Butter butter = new Butter { Weight = 100 };

    Sandwich sandwich = bread + butter;

    Console.WriteLine($" Бутерброд с маслом весом = {sandwich.Weight}");

}*/