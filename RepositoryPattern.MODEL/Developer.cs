using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.MODEL
{
    public class Developer
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Followers { get; set; }
    }
}
