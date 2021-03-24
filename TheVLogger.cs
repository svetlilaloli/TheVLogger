using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class TheVLogger
    {
        static void Main()
        {
            Dictionary<string, Follow> vloggers = new Dictionary<string, Follow>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] currentCommand = command.Split();
                string vloggerName = currentCommand[0];

                if (currentCommand.Contains("joined"))
                {
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new Follow());
                    }
                }
                else if (currentCommand.Contains("followed"))
                {
                    string vlogger2 = currentCommand[2];
                    if (vloggers.ContainsKey(vloggerName) && vloggers.ContainsKey(vlogger2) && vloggerName != vlogger2)
                    {
                        vloggers[vloggerName].following.Add(vlogger2);
                        vloggers[vlogger2].followers.Add(vloggerName);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.followers.Count).ThenBy(x => x.Value.following.Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.followers.Count} followers, {vlogger.Value.following.Count} following");
                if (count == 1)
                {
                    foreach (var follower in vlogger.Value.followers.OrderBy(n => n))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}
