using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class role
    {
        public int roleId { get; set; }
        public string? roleName { get; set; }

        public ICollection<user>? users { get; set; }
    }
}
