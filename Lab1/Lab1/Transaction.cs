
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab1
{
     public class Transaction
    {
        [Key]
        public int IdTranz{ get; set; }
        public string secondname { get; set; }
    }
}
