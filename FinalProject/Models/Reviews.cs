using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApplication.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }

    }
}