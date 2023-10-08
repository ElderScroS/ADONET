using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataa
{
    public class Car
    {
        [Key]
        public int CarKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishingDate { get; set; }
    }

    internal class Program { static void Main(string[] args) { } }
}
