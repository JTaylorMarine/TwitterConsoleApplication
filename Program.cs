using System;
using System.Collections.Generic;
using TwitterManager;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            TweetManagerFile tm = new TweetManagerFile();

            do
            {

                Console.WriteLine("--------Main Menu---------");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Post New Post");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");

                choice = Console.ReadLine();
                if (choice == "1")
                {
                    for (int i = 0; i < tm.TweetCounter(); i++)
                        Console.WriteLine("Tweet #{0}:{1}", i + 1, tm.getTweets()[i]);
                }

                if (choice == "2")
                {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();
                    string msg = tm.postTweet(tweet);
                    Console.WriteLine(msg);
                }

                if (choice == "3")
                {
                    Console.Write("Enter search term: ");
                    string search = Console.ReadLine();
                    List<string> results = tm.Search(search);
                    Console.WriteLine("Found " + results.Count + " tweets.");
                }

                Console.WriteLine("You entered {0}", choice);

            }
            while (choice != "4");


            Console.ReadLine();

            /*
            string[] tweets = new string[4];
            // Loop 1
            for (int i = 0; i < tweets.Length; i++)
            {
                Console.Write("Enter tweet #{0}: ", i + 1);
                tweets[i] = Console.ReadLine();
            }


            Console.WriteLine("Tweets posted successfully.");
            Console.WriteLine();

            Console.WriteLine("Your tweets are: ");
            //loop 2
            for (int i = 0; i < tweets.Length; i++)
            {
                if (tweets[i].Length > 140)
                    Console.WriteLine("Your tweet is longer than 140 characters.");
                else
                Console.WriteLine("Your tweet #{0} is '{1}' ", i + 1, tweets[i]);
            }

            Console.ReadLine();
            */
        }
    }
}
