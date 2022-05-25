using Microsoft.EntityFrameworkCore;
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
    public class Account
    {
        [Key]
        public int IdAcc { get; set; }
        public int Balance { get; set; }
        public string TypeAccount { get; set; }
        
        public DateTime DateNextPay { get; set; }
       
        [ForeignKey("IdUser")]
        public virtual User User{ get; set; }

    }
}
