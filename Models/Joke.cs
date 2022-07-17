using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokes_Test_2.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public String  Joke_Question  { get; set; }
        public String Joke_Answer { get; set; }

        public Joke()
        {

        }
    }
}
