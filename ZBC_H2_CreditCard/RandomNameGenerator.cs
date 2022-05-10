using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ZBC_H2_CreditCard
{
    public class RandomNameGenerator
    {
        private Random rand;

        private string[] firstNames = new string[] {
                                        "Elijah",
                                        "Daniel",
                                        "Aiden",
                                        "Logan",
                                        "Matthew",
                                        "Lucas",
                                        "Jackson",
                                        "David",
                                        "Oliver",
                                        "Jayden",
                                        "Joseph",
                                        "Gabriel",
                                        "Samuel",
                                        "Carter",
                                        "Anthony",
                                        "John",
                                        "Emma",
                                        "Olivia",
                                        "Sophia",
                                        "Ava",
                                        "Isabella",
                                        "Mia",
                                        "Abigail",
                                        "Emily",
                                        "Charlotte",
                                        "Harper",
                                        "Madison",
                                        "Amelia",
                                        "Elizabeth",
                                        "Sofia",
                                        "Evelyn"                                
                                      };

        private string[] lastNames = new string[] {
                                        "Peters",
                                        "Hawkins",
                                        "Grant",
                                        "Hansen",
                                        "Castro",
                                        "Hoffman",
                                        "Hart",
                                        "Elliott",
                                        "Cunningham",
                                        "Knight",
                                        "Bradley",
                                        "Carroll",
                                        "Hudson",
                                        "Duncan",
                                        "Armstrong",
                                        "Berry",
                                        "Andrews",
                                        "Johnston",
                                        "Ray",
                                        "Lane",
                                        "Riley",
                                        "Carpenter",
                                        "Perkins",
                                        "Aguilar",
                                        "Silva",
                                        "Richards",
                                        "Willis",
                                        "Matthews",
                                        "Chapman",
                                        "Lawrence",
                                        "Garza",
                                        "Vargas",
                                        "Watkins",
                                        "Wheeler",
                                        "Larson",
                                        "Carlson",
                                        "Harper",
                                        "George",
                                        "Greene",
                                        "Burke",
                                        "Guzman",
                                        "Morrison",
                                        "Munoz",
                                        "Jacobs",
                                        "Obrien",
                                        "Lawson",
                                        "Franklin"
        };


        public RandomNameGenerator()
        {
            rand = new Random();
        }

        public string GenerateRandomFirstName()
        {
            return firstNames[rand.Next(firstNames.Length)];
        }

        public string GenerateRandomLastName()
        {
            return lastNames[rand.Next(lastNames.Length)];
        }
    }
}
