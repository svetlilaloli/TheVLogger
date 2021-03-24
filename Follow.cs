using System.Collections.Generic;

namespace TheVLogger
{
    class Follow
    {
        public HashSet<string> followers { get; set; }
        public HashSet<string> following { get; set; }

        public Follow()
        {
            followers = new HashSet<string>();
            following = new HashSet<string>();
        }
    }
}
