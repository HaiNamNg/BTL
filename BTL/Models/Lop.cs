using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    public class Lop
    {
        [Key]
        [Required, MinLength(3)]
        public string TenLop { get; set; }
        [Required]
        public string MaLop { get; set; }
        [Required]
        public string GiaoVien { get; set; }
        [Required]
        public string MaMonHoc { get; set; }
        
    }
}