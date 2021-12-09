using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace bank.Models
{
        
            public class fasilitas
    {
        [Key]
        [Column(TypeName = "varchar(200)",Order = 1)]
        public string jns_fasilitas { get; set; }
        [Column(TypeName = "varchar(200)",Order = 2)]
        public string nama_fasilitas { get; set; }

        

        
    }
}
