using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    public class Khoa
    {
        [Key]
        [Required, MinLength(3)]
        public string MaKhoa { get; set; }
        [Required, MinLength(10)]
        public string TenKhoa { get; set; }
    }
}