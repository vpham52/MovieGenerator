using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Net.Http;
using This_Is_Final.Models;
using This_Is_Final;

namespace This_Is_Final

{
    public class MovieRepository : IMovieRepository
    {
        private readonly string _conn;

        public MovieRepository(string conn)
        {
            _conn = conn;
        }

        public Movie GetApiResponse()
        {
            var movie = new Movie();


            //RestSharp Code
            var client = new RestClient("https://imdb-top-100-movies.p.rapidapi.com/");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Key", $"{_conn}");
            request.AddHeader("X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com");
            var response = client.Execute(request);

            movie.APIResponse = response.Content;

           

            static int GenerateRandomNumber()
            {
                Random random = new Random();
                int randomNumber = random.Next(100);
                return randomNumber;
            }
            int i = GenerateRandomNumber();

            movie.Title = JArray.Parse(movie.APIResponse)[i]["title"].ToString();
            movie.Year = JArray.Parse(movie.APIResponse)[i]["year"].ToString();
            movie.Genre = JArray.Parse(movie.APIResponse)[i]["genre"][0].ToString();
            movie.Rank = JArray.Parse(movie.APIResponse)[i]["rank"].ToString();
            movie.Rating = JArray.Parse(movie.APIResponse)[i]["rating"].ToString();
            movie.Description = JArray.Parse(movie.APIResponse)[i]["description"].ToString();
            movie.Image = JArray.Parse(movie.APIResponse)[i]["image"].ToString();
            movie.Trailer = JArray.Parse(movie.APIResponse)[i]["trailer"].ToString();
            movie.Director = JArray.Parse(movie.APIResponse)[i]["director"].ToString();
            movie.Writers = JArray.Parse(movie.APIResponse)[i]["writers"].ToString();





            //returns everything we parsed
            return movie;
        }

    }




    
}


