using System.Security;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект для сериализации
            Movie movie1 = new Movie("Breaking bad", 150);
            MovieDTO movieDTO = new MovieDTO(movie1);
            movie1.Add(3);
            movie1.Add(5);
            movie1.Add(3);

            //создаем путь для файла xml на рабочий стол
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "movie.xml");

            //Создаем XML-сериализатор
            //-класс должен иметь конструктор без параметров
            //-класс должен быть публичный
            //-в классе все свойства должны быть с публичными get set

            //Оригинальный объект -> ДТО объект -> отдать все в сериализатор
            var serializer = new XmlSerializer(typeof(MovieDTO));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, movieDTO);
            }

            //Десериализуем объект из файла -> получаем ДТО объект -> оригинальный объект
            MovieDTO movieDTO2;
            using (var reader = new StreamReader(filePath))
            {
                movieDTO2 = (MovieDTO)serializer.Deserialize(reader);
            }
            Movie movie2 = new Movie(movieDTO2.Name, movieDTO2.Duration);
            foreach(int val in movieDTO2.Rating)
            {
                movie2.Add(val);
            }
            if (CompareMovies(movie1, movie2))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }

        private static bool CompareMovies(Movie m1, Movie m2)
        {
            if (m1.Name != m2.Name) return false;
            if (m1.Duration != m2.Duration) return false;
            if (m)
            return true;
        }
        public class Movie
        {
            private string _name;
            private int _duration;
            private int[] _rating;

            public string Name => _name;
            public int Duration => _duration;
            public int[] Rating => _rating.ToArray();

            public Movie(string name, int duration)
            {
                _name = name;
                _duration = duration;
                _rating = new int[0];
            }
            public void Add(int stars)
            {
                Array.Resize(ref _rating, _rating.Length+1);
                _rating[_rating.Length - 1] = stars;
            }
        }
        public class MovieDTO
        {
            public string Name { get; set; }
            public int Duration { get; set; }

            public MovieDTO()
            {
            }
            //конструкторы для копирования Movie
            public MovieDTO(string name, int duration)
            {
                Name = name;
                Duration = duration;
                Rating = 
            }
            public MovieDTO(Movie movie)
            {
                Name = movie.Name;
                Duration = movie.Duration;
            }
        }
    }
}
