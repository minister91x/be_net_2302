using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BE_NET_2302.Models
{
    public class EmployeeRegisterModels
    {
        [Required(ErrorMessage = "Mã nv không được trống")]
        [MaxLength(128)]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
    }
}