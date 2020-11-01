using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entites
{
    class Reward
    {
        public User User { get; set; }
        public Award Award { get; set; }

        public Reward(User user, Award award)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Award = award ?? throw new ArgumentNullException(nameof(award));
        }
    }
}
