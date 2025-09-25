using System.IO;

namespace Files
{
    public class Movie
    {
        private string Film;
        private string Genre;
        private string LeadStudio;
        private string AudienceScore;
        private string Profitability;
        private string RottenTomatoes;
        private string WorldWideGros;
        private string Year;

        public Movie(string film, string genre, string leadStudio, string audienceScore, string profitability,
            string rottenTomatoes, string worldWideGros, string year)
        {
            Film = film;
            Genre = genre;
            LeadStudio = leadStudio;
            AudienceScore = audienceScore;
            Profitability = profitability;
            RottenTomatoes = rottenTomatoes;
            WorldWideGros = worldWideGros;
            Year = year;
            
        }

        public override string ToString()
        {
            
            return Film + ", " + Genre + ", " + LeadStudio + ", " + AudienceScore + ", " + Profitability + ", " + RottenTomatoes + ", " + WorldWideGros + ", " + Year;
        }

        public string GetTomatoRating()
        {
            return RottenTomatoes;
        }

        public string GetYear()
        {
            return Year;
        }

        
    }
}