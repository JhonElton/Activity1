﻿using System;

namespace UserProfiling
{
    class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Occupation { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the function to collect profile information
            Profile userProfile = CollectProfile();

            Console.Write("Thank you for taking the form!");

            Console.WriteLine(" Press any key to exit...");
            Console.ReadKey();
        }

        // Profiling Functions
        static Profile CollectProfile()
        {
            Profile profile = new Profile();

            Console.Write("Enter your name: ");
            profile.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            profile.Age = int.Parse(Console.ReadLine());

            Console.Write("Please enter you gender: ");
            profile.Gender = Console.ReadLine();

            Console.Write("Please enter your Contact Number: ");
            profile.ContactNumber = Console.ReadLine();

            Console.Write("Please enter your Email: ");
            profile.Email = Console.ReadLine();

            Console.Write("Please enter your Location: ");
            profile.Location = Console.ReadLine();

            Console.Write("Enter your occupation: ");
            profile.Occupation = Console.ReadLine();

            return profile;
        }
    }
}