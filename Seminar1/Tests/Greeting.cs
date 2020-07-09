using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace Seminar1.Tests
{
    internal class Greeting
    {

        public Greeting()
        {
        }

        internal string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Hello, my friend.";
            }

            if (name == name.ToUpper())
            {
                return $"HELLO {name.ToUpper()}!";
            }
            if (name.Contains(","))
            {
                string[] words = name.Split(',');
                int numberOfNames = words.Length;
                int nr = 0; //Numar nume scrise cu LITERE MARI
                string ret = "";
                for (int i = 0; i<numberOfNames; i++)
                {
                    if (words[i] == words[i].ToUpper())
                    {
                        nr = nr + 1;
                    }
                }
                if (nr == 0)
                {
                    if (numberOfNames == 2)
                    {
                        ret = "Hello, " + words[0] + " and" + words[1] + ".";
                    }
                    else if (numberOfNames > 2)
                    {
                        ret = "Hello, ";
                        for (int i = 0; i<numberOfNames-1; i++)
                        {
                            ret = ret + words[i] + ", ";
                        }
                        ret = ret + "and " + words[numberOfNames-1] + ".";
                    }
                }
                else if (nr>0)
                {
                    if (numberOfNames == 2)
                    {
                        ret = "Hello, "+ words[0] + " and "+ words[1] + ".";
                    }

                    else if (numberOfNames > 2)
                    {
                        ret = "Hello, ";
                        for (int i = 0; i<numberOfNames-1; i++)
                        {
                            if (words[i] != words[i].ToUpper())
                            {
                                ret = ret + words[i] + " ";
                            }
                        }
                        ret = ret + "and " + words[numberOfNames-1] + ".";
                    }

                    ret = ret + " AND HELLO ";
                    for (int i = 0; i<numberOfNames; i++)
                    {
                        if (words[i] == words[i].ToUpper())
                        {
                            ret = ret + words[i];
                        }
                    }
                    ret = ret + "!";
                }
                return ret;
            }

            return $"Hello, {name}.";
        }
    }
}