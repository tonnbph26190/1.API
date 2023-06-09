﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_API.ViewModel.NhanVien
{
    public class CreateNhanVien
    {
        public Guid? Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string? Ten { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "Vui lòng nhập đúng email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Toi thieu 6 ki tu, toi da 30 ki tu")]
        public string? MatKhau { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^((09(\d){8})|(086(\d){7})|(088(\d){7})|(089(\d){7})|(01(\d){9}))$", ErrorMessage = "Vui lòng nhập đúng số điện thoại")]
        public string? Sdt { get; set; }
        
        public string? AnhNhanVien { get; set; }
        public bool? GioiTinh { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        public DateTime? NgaySinh { get; set; }

    }
}
