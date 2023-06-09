﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelsClass
{
    public class NhanVien
    {         
        public Guid Id { get; set; }
        public string? Ten { get; set; }
        public string? MaNV { get; set; }
        public string? Email { get; set; }
        public string? MatKhau { get; set; }
        public string? Sdt { get; set; }
        public string? AnhNhanVien { get; set; }
        public bool? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgaySinh { get; set; }
        
    }
}
