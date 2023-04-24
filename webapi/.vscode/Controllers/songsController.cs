using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.utility;


namespace webapi.Controllers
{
    [Route("api/songs")]
    [ApiController]
    public class songsController : ControllerBase
    {
        // GET: api/songs
        [HttpGet]
         public Song[] Get()
        {
            // return new string[] {"Micah", "Pentecost"};
            // Song lol = new Song("lol", "lol", "lol", "lol", "lol");
            // return lol;
            Song[] songs = new Song[100];
            SongUtility songUtility = new SongUtility(songs);
            songUtility.GetAllSongsFromFile();
            Song[] maxSongs = new Song[Song.GetCount()];
            for(int i=0; i<Song.GetCount();i++)
            {
                maxSongs[i]= songs[i];
            }
            return maxSongs;

        }
        

        // GET: api/songs/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/songs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
