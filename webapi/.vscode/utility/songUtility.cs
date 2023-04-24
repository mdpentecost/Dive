using webapi.models;
namespace webapi.utility
{
    public class SongUtility
    {
        Song[] songs;

        public SongUtility(Song[] songs)
        {
            this.songs=songs;
        }

        public void GetAllSongsFromFile()
        {
            //open
            StreamReader inFile = new StreamReader("./files/Taylor.txt");
            
            //process
            Song.SetCount(0);
            string line = inFile.ReadLine();
            while(line!= null)
            {
                string[] temp = line.Split("#");
                songs[Song.GetCount()] =  new Song(temp[0], temp[1], temp[2], temp[3], temp[4], int.Parse(temp[5]));
                Song.IncCount();
                line= inFile.ReadLine();
            }
            //close
            inFile.Close();
        }

        public string GetSongChoice()
        {
            System.Console.WriteLine("Please Enter a name of any song above!");
            string songChoice= Console.ReadLine();
            return songChoice;
        }

        public string UserChoice()
        {   
            string songChoice= GetSongChoice();
            System.Console.WriteLine("To Get an anlysis of "+songChoice+" Enter 1");
            System.Console.WriteLine("To Get the artist of "+songChoice+" Enter 2");
            System.Console.WriteLine("To Get an album of "+songChoice+" Enter 3");
            System.Console.WriteLine("To Get key lyrics of "+songChoice+" Enter 4");
            string userChoice= Console.ReadLine();
            return userChoice;
        }
    public int Find()
    {
        string searchVal= GetSongChoice();
        for(int i= 0; i< Song.GetCount(); i++) // sequential search
        {
            if(songs[i].GetTitle().ToUpper()== searchVal.ToUpper())
            {
                return i;
            }
        }
        return -1;
    }
     public void FindSong()
    {
         int foundIndex= Find();
        if(foundIndex!= -1)
        {
            Route(foundIndex);
        }else System.Console.WriteLine("Song not found!");
        
    }

    
        public void Route(int foundIndex)
        {
            
            string userChoice= UserChoice();
            if(userChoice== "1")
            {
                System.Console.WriteLine(songs[foundIndex].GetAnalysis());
            }else if(userChoice== "2")
            {
                 System.Console.WriteLine(songs[foundIndex].GetArtist());
            }else if(userChoice== "3")
            {
                 System.Console.WriteLine(songs[foundIndex].GetAlbum());
            }else if(userChoice== "4")
            {
                System.Console.WriteLine(songs[foundIndex].GetKeyLyrics());
            }
            else System.Console.WriteLine("Invalid Menu Choice!");
        }

    }
}