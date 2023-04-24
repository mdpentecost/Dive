
namespace webapi.models
{
       public class Song
    {
        //instance variables
        public string title {get; set;}

        public string artist{get; set;}

        public string analysis{get; set;}

        public string album{get; set;}

        public string keyLyrics{get; set;}

        public int id{get; set;}

        // public string keyLyrics;

        static public int count{get; set;}

       
        //constructor
        public Song()
        {

        }

        public Song(string title, string artist, string analysis, string album, string keyLyrics, int id)
        {
            this.title=title;
            this.artist=artist;
            this.analysis=analysis;
            this.album=album;
            this.keyLyrics=keyLyrics;
            this.id=id;
        }
        //methods


        public void SetTitle(string title)
        {
            this.title=title;
        }
         public string GetTitle()
        {
            return title;
        }
        public void SetArtist(string artist)
        {
            this.artist=artist;
        }
         public string GetArtist()
        {
            return artist;
        }
        public void SetAnalysis(string analysis)
        {
            this.analysis=analysis;;
        }
         public string GetAnalysis()
        {
            return analysis;
        }
            public void SetAlbum(string album)
        {
            this.album=album;;
        }
         public string GetAlbum()
        {
            return album;
        }

           public void SetKeyLyrics(string keyLrics)
        {
            this.keyLyrics=keyLyrics;
        }
         public string GetKeyLyrics()
        {
            return keyLyrics;
        }
         
        
        
        static public void SetCount(int count)
        {
            Song.count= count; // belongs to entire class so use book not this
        }
        static public void IncCount()
        {
            count++;
        }
       static public int GetCount()
       {
        return Song.count;
       }
        public override string ToString()
        {
            // string title, string artist, string analysis, string album
            return $"Song:{title} Artist: {artist} Analysis: {analysis} Album:{album}";
        }
    }
}