﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyWPFMukachev.Classes
{
    internal class CRUD
    {
        public static void CreateUser(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<User>("UserCollection");
            collection.InsertOne(user);
        }

        public static void GetUser(int number)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<User>("UserCollection");
            var user = collection.Find(x => x.DiplomNumber == number).FirstOrDefault();
            if (user == null)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine($"{user.Name} {user.Age}");
        }

        public static void CreateTestTeam(Team team)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users2024");
            var collection = database.GetCollection<Team>("UserCollection");
            collection.InsertOne(team);
        }
    }
}
