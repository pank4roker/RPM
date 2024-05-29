using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27pr
{ 
    struct CinemaPoster
    {
        public string CinemaName;
        public DateTime SessionDate;
        public string MovieTitle;
        public string Genre;
        public TimeSpan StartTime;
        public int DurationMinutes;

        public CinemaPoster(string cinemaName, DateTime sessionDate, string movieTitle, string genre, TimeSpan startTime, int durationMinutes)
        {
            CinemaName = cinemaName;
            SessionDate = sessionDate;
            MovieTitle = movieTitle;
            Genre = genre;
            StartTime = startTime;
            DurationMinutes = durationMinutes;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Кинотеатр: {CinemaName}");
            Console.WriteLine($"Дата сеанса: {SessionDate.ToShortDateString()}");
            Console.WriteLine($"Название фильма: {MovieTitle}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Время начала: {StartTime}");
            Console.WriteLine($"Длительность: {DurationMinutes} минут");
            Console.WriteLine($"Время завершения: {GetEndTime()}");
            Console.WriteLine();
        }

        public TimeSpan GetEndTime()
        {
            return StartTime.Add(TimeSpan.FromMinutes(DurationMinutes));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CinemaPoster[] posters = new CinemaPoster[]
            {
            new CinemaPoster("Кинотеатр 1", new DateTime(2024, 6, 1), "Фильм 1", "Драма", new TimeSpan(14, 30, 0), 120),
            new CinemaPoster("Кинотеатр 2", new DateTime(2024, 6, 2), "Фильм 2", "Комедия", new TimeSpan(16, 0, 0), 90),
            new CinemaPoster("Кинотеатр 3", new DateTime(2024, 6, 3), "Фильм 3", "Боевик", new TimeSpan(18, 45, 0), 110),
            new CinemaPoster("Кинотеатр 4", new DateTime(2024, 6, 7), "Фильм 4", "Ужасы", new TimeSpan(20, 0, 0), 105),
            new CinemaPoster("Кинотеатр 5", new DateTime(2024, 6, 8), "Фильм 5", "Фантастика", new TimeSpan(19, 30, 0), 95),
            };

            Console.WriteLine("Сведения о времени завершения каждого сеанса:\n");
            foreach (var poster in posters)
            {
                poster.DisplayInfo();
            }

            Console.WriteLine("Фильмы, идущие в выходные дни (Суббота и Воскресенье):\n");
            foreach (var poster in posters)
            {
                if (poster.SessionDate.DayOfWeek == DayOfWeek.Saturday || poster.SessionDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    poster.DisplayInfo();
                }
            }
            Console.ReadKey();
        }
    }

}
