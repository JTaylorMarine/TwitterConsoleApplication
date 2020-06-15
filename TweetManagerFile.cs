using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterManager
{
    public class TweetManagerFile : TweetManager
    {
        private string filename = "tweets.txt";

        public override string WriteTweet(string tweet)
        {
            System.IO.File.AppendAllLines(filename, new string[] { tweet });

            return "Tweet posted successfully";
        }

        public override int TweetCounter ()
        {
            return System.IO.File.ReadAllLines(filename).Length;
        }
        public override string[] getTweets()
        {
            return System.IO.File.ReadAllLines(filename);
        }
    }
}
