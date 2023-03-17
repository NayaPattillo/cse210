using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activity _activityStart = new Activity();
        string _menu = _activityStart.Menu();
        Console.WriteLine(_menu);
        string _input = Console.ReadLine();
        string animation = _activityStart.Animation(" ");

        while (_input != "4"){
            if (_input == "1"){
                BreathingAct _breathing = new BreathingAct();
                Console.WriteLine(_breathing.Breathing());
            }
            else if (_input == "2"){
                ReflectionAct _reflection = new ReflectionAct();
                Console.WriteLine(_reflection.Reflection());
            }
            else if (_input == "3"){
                ListingAct _listing = new ListingAct();
                Console.WriteLine(_listing.Listing());
            }
            _menu = _activityStart.Menu();
            Console.WriteLine(_menu);
            _input = Console.ReadLine();
        }
    }
}