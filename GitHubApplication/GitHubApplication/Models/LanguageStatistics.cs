using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Models
{
   public class LanguageStatistics
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public int StarsCaunt { get; set; }
        public DateTime Date { get; set; }

    }
}
