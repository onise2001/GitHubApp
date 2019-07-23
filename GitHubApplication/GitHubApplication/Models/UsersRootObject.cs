using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Models
{
    public class UsersRootObject
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<GitHubUser> items { get; set; }
    }
}
