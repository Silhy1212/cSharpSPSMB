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
      foreach (var movie in Movies)
      {
        Console.WriteLine(movie.ToString());
      }
    }
    public static void GetMoviesIntoList(string filePath)
    {
      
      using (StreamReader csvReader = new StreamReader(filePath))
      {
        string line;
        
        while ((line = csvReader.ReadLine()) != null)
        {
          
          var parts = line.Split(',');
          
          
          var movie = new Movie(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
            
          Movies.Add(movie);
        }
      }
    }
    
  }
}