const baseUrl= "http://localhost:5152/api/songs"
var songList = [];
var mySong = {};


async function getSongs()
{
    const allSongsApiUrl = "http://localhost:5152/api/songs";
    const response= await fetch(allSongsApiUrl)
    const data= await response.json()
    console.log(data)
    console.log(response)
}
getSongs()

function handleOnLoad(){
    
    populateList();
}

function populateList(){

    const allSongsApiUrl = baseUrl;
    fetch(allSongsApiUrl).then(function(response){
        
        return response.json();
    }).then(function(json){
        
        songList = json;
        console.log(songList)
        let html = "<select class = \"listBox\" onchange = \"handleOnChange()\" id= \"selectListBox\" name = \"list_box\" size=5 width=\"100%\">";
        json.forEach((song)=>{
            html += "<option value = " + song.id  + ">" + song.title + "</option>";
        })
        html += "</select>";
        // document.getElementById("listBox").innerHTML = "<div>HI</div>";
        
        document.getElementById("listBox").innerHTML = html;
        
    }).catch(function(error){
        console.log(error);
    });
}



function handleOnChange(){
    const selectedID= document.getElementById("selectListBox").value;
    songList.forEach((song)=>{
        if(song.id == selectedID)
        {
            mySong = song
        }
    });
    populateForm();
}

function populateForm(){
    const titleElement = document.getElementById("songTitle")
    const title = mySong.title

    document.getElementById("songTitle").innerHTML = mySong.title;
    document.getElementById("songAnalysis").innerHTML = mySong.analysis;
    document.getElementById("songAlbum").innerHTML = mySong.album;
    document.getElementById("songKeyLyrics").innerHTML = mySong.keyLyrics;
    document.getElementById("songLink").innerHTML = mySong.link;
    var html = "<img class= \"coverArt\" src= \"" + mySong.album + "\"></img>";
    document.getElementById("picBox").innerHTML = html;

}



