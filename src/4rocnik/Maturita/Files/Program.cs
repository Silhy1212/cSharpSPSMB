using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    internal class Program
    {
        public static List<Movie> Movies = new List<Movie>();
        public static void Main(string[] args)
        {
            GetMoviesIntoList("./movies.csv");
            
            Console.WriteLine("Zadej rok");
            Console.WriteLine();

            int nevim =Convert.ToInt32(Console.ReadLine());
            WorstRatedMovieInYear(nevim);
        }
        public static void GetMoviesIntoList(string filePath)
        {
      
            using (StreamReader csvReader = new StreamReader(filePath))
            {
                string line = csvReader.ReadLine();
                
                
        
                while ((line = csvReader.ReadLine()) != null)
                {
                    
                    var parts = line.Split(',');
          
          
                    var movie = new Movie(parts[0], parts[1], parts[2], parts[3], parts[4], (parts[5]), parts[6], parts[7]);
            
                    Movies.Add(movie);
                }
            }
        }

        public static void WorstRatedMovieInYear(int year)
        {
           
            int[] rating = new int[Movies.Count];
            for (int i = 0; i < Movies.Count; i++)
            {
                if (Convert.ToInt32(Movies[i].GetYear()) == year)
                {
                    int y = 0;
                    rating[y] = Convert.ToInt32(Movies[i].GetTomatoRating());
                    y++;
                }
               
            }
            

            int min = rating[0];
            int filmPlace = rating[0];
            for (int i = 0; i < rating.Length; i++)
            {
                if (rating[i] < min)
                {
                    min = rating[i];
                    filmPlace = i;
                }
            }

            Console.WriteLine(Movies[filmPlace]); 
        }
    
    }
}