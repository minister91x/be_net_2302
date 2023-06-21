﻿using System.ComponentModel.DataAnnotations;
using UnitOfWork.DataAccess.Entities;
using WebApplicationCoreAPI.Filter;

namespace WebApplicationCoreAPI.Models
{
    public class StudentEditModel
    {
        [Required(ErrorMessage = "Vui lòng điền tên học sinh")]

        public string? Name { get; set; }
        public string? Department { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày sinh.")]
        [Min18Years]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày .")]

        [CustomAdmissionDate(ErrorMessage = "Admission Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }

        public HOADON hoadon { get; set; }

    }
}