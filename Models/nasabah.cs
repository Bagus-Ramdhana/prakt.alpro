using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace bank.Models
{
        
        public class nasabah
{
        [Key]
        [Column(TypeName = "varchar(200)",Order = 1)]
        public string ciff_nasabah { get; set; }
        [Column(TypeName = "varchar(200)",Order = 2)]
        public string nama_nasabah { get; set; }
        [Column(TypeName = "varchar(200)",Order = 3)]
        public string jk_nasabah { get; set; }
        [Column(TypeName = "varchar(200)",Order = 4)]
        public string alamat_nasabah { get; set; }
        [Column(TypeName = "varchar(200)",Order = 5)]
        public string nohp_nasabah { get; set; }
        [Column(TypeName = "varchar(200)",Order = 6)]
        public string pekerjaan_nasabah { get; set; }

        [ForeignKey("ciff_nasabah")]
        public ICollection <transaksi> transaksi { get; set; }

}
}