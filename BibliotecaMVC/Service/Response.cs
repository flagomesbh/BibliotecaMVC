using System.Collections.Generic;

namespace BibliotecaMVC.Service
{
    public class Response
    {
        int _resultCount { get; set; }
        List<Result> _results { get; set; }

        public int ResultCount
        {
            get { return _resultCount; }
            set { _resultCount = value; }
        }

        public List<Result> Results
        {
            get { return _results; }
            set { _results = value; }
        }
    }

    public class Result
    {
        int _trackId { get; set; }
        string _artworkUrl60 { get; set; }
        string _trackName { get; set; }
        string _artistName { get; set; }
        string[] _genres { get; set; }
        double _price { get; set; }
        string _description { get; set; }

        public int TrackId
        {
            get { return _trackId; }
            set { _trackId = value; }
        }
        
        public string ArtworkUrl60
        {
            get { return _artworkUrl60; }
            set { _artworkUrl60 = value;}
        }
        
        public string TrackName
        {
            get { return _trackName; }
            set { _trackName = value; }
        }

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }
        public string[] Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
