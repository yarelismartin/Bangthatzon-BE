﻿using Bangthatzon.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;


namespace Bangthatzon.APIs
{
    public class UserAPI
    {
        public static void Map(WebApplication app) 
        {
            //Get user by id
            app.MapGet("/api/users/{uid}", (BangthatzonDbContext db, string uid) =>
            {
                User user = db.Users
                .SingleOrDefault(u => u.Uid == uid);
                if (user == null)
                {
                    return Results.NotFound("There are no users matching.");
                }
                return Results.Ok(user);
            });

            //post user // creating an account 
            app.MapPost("api/register", (BangthatzonDbContext db, User newUser) =>
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return Results.Created($"/api/users/{newUser.Id}", newUser);

            });

            // Get all users and compare the logged in users uid to the uid stores in database. return true if there's a match.
            app.MapGet("/checkuser/{uid}", (BangthatzonDbContext db, string uid) =>
            {

                var user = db.Users.Where(u => u.Uid == uid).ToList();
                if (user == null)
                {
                    return Results.NotFound("There are no users with this uid");
                }
                else
                {
                    return Results.Ok(user);

                }

            });



            //patch user // edit form for user
            app.MapPut("/api/users/{userId}", (BangthatzonDbContext db, int userId, User user) =>
            {
                var userToUpdate = db.Users.SingleOrDefault(u => u.Id == userId);
                if (userToUpdate == null)
                {
                    return Results.BadRequest("User not found.");
                }
                userToUpdate.FirstName = user.FirstName;
                 userToUpdate.LastName = user.LastName;
                userToUpdate.Username = user.Username;
                userToUpdate.Email = user.Email;
                userToUpdate.Address = user.Address;
                userToUpdate.Image = user.Image;
                db.SaveChanges();
                return Results.Ok(userToUpdate);

            });
        }
    }
}
