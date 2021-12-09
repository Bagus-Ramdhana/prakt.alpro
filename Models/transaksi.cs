using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace bank.Models
{

public class transaksi
{
    [Key]
    [Column(TypeName = "varchar(200)",Order = 1)]
    public string ciff_nasabah { get; set; }
    [Column(TypeName = "date",Order = 2)]
    public DateTime tgl_transaksi { get; set; }
    [Column(TypeName = "varchar(200)",Order = 3)]
    public string jns_fasilitas { get; set; }
    [Column(TypeName = "varchar(200)",Order = 4)]
    public string nominal_transaksi { get; set; }
    [Column(TypeName = "varchar(200)",Order = 5)]
    public string keterangan_transaksi { get; set; }

    [ForeignKey("jns_fasilitas")]
    public ICollection <fasilitas> fasilitas { get; set; }

}
}