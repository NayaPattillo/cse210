using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Console.WriteLine("Which event would you like to see?:");
        Console.WriteLine("1. Lecture");
        Console.WriteLine("2. Reception");
        Console.WriteLine("3. Outdoor");
        string input = Console.ReadLine();

        if (input == "1"){
            string e_title = "Stars and Beyond";
            string e_description = "A lecture from an Astronaut";
            string e_date = "4/3/23";
            string e_time = "11:00 AM";
            string e_address = "416W 400N Milky Way";
            string e_spaeker = "Mr. Marsion";
            int e_capacity = 60;

            Event lecture = new Event();
            lecture.SetEvent(e_title, e_description, e_date, e_time, e_address);
            Console.WriteLine(lecture.GetEvent());

            Lectures _lecture = new Lectures();
            _lecture.SetDetails(e_spaeker, e_capacity);
            Console.WriteLine(_lecture.GetDetails());
        }
        else if (input == "2"){
            string e_title = "Ben & Kristy";
            string e_description = "Wedding Reception";
            string e_date = "5/4/23";
            string e_time = "2:30 PM";
            string e_address = "527E 511S Hall Way";
            string e_email = "receptionmail@gmail.com";

            Event lecture = new Event();
            lecture.SetEvent(e_title, e_description, e_date, e_time, e_address);
            Console.WriteLine(lecture.GetEvent());

            Receptions reception = new Receptions();
            reception.SetDetails(e_email);
            Console.WriteLine(reception.GetDetails());
        }
        else if (input == "3"){
            string e_title = "County Fair";
            string e_description = "Carbon County Spring Fair";
            string e_date = "3/10/23";
            string e_time = "8:30 AM - 6:60PM";
            string e_address = "700N 400S Park Way";
            string e_weather = "65F Partly Cloudy";

            Event lecture = new Event();
            lecture.SetEvent(e_title, e_description, e_date, e_time, e_address);
            Console.WriteLine(lecture.GetEvent());

            Outdoor weather = new Outdoor();
            weather.SetWeather(e_weather);
            Console.WriteLine(weather.GetWeather());
        }
    }
}