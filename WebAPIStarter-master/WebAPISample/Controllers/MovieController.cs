﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Models;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;


namespace WebAPISample.Controllers
{
    public class MovieController : ApiController
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        List<Movie> movies = new List<Movie>();
        // GET api/values
        MovieController()
        {
          
            movies = context.Movies.ToList();
   
        }


        
        public async Task<IHttpActionResult> Get()
         { 
                 
            return context.Movies.ToList();

       
            return movies;


            // Retrieve all movies from db logic
           // return new string[] { "movie1 string", "movie2 string" };
        }




        // GET api/values/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var foundMovie = context.Movies.Where(a => a.MovieId == id).Single();
            return Ok(foundMovie);
        }
        // GET api/values/5
       
         
        public async Task<IHttpActionResult> Post([FromBody]Movie value)
        {
            try
            {
                context.Movies.Add(value);
                context.SaveChangesAsync();

                return Ok(movies);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // PUT api/values/5
        public async Task<IHttpActionResult> Put([FromBody]Movie value)
        {
            try
            {
                var movieToUpdate = context.Movies.Find(value.MovieId);

                movieToUpdate.Title = value.Title ?? movieToUpdate.Title;
                movieToUpdate.Genre = value.Genre ?? movieToUpdate.Genre;
                movieToUpdate.Director = value.Director ?? movieToUpdate.Director;
                var movie = await context.SaveChangesAsync();

                return Ok(movie);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE api/values/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            // Delete movie from db logic
            try
            {
                context.Movies.Remove(context.Movies.FirstOrDefault(h => h.MovieId == id));
                var movie = await context.SaveChangesAsync();
                return Ok(movie);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }

}