using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_ProJect_MVC.Models
{
    [Table("DaiLy")]
    public class DaiLy
    {
        [Key]
        public String? MaDaiLy { get; set; }
        public String? TenDaiLy { get; set; }
        public String? DiaChi { get; set; }
        public String? NguoiDaiDien { get; set; }
        public String? DienThoai { get; set; }
        public String? MaHTTP { get; set; }
    }
}