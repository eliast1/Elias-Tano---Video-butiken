using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Uppgift6Avancerat.Models
{
    public class Kunder
    {
        [Key]
        public string Namn { get; set; }
        public int Id { get; set; }
    }
}