using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_ProJect_MVC.Models{
    [Table("HeThongPhanPhoi")]
    public class HeThongPhanPhoi
    {
        [Key]
        public string? MaHTTP { get; set; }
        public string? TenHTPP { get; set;}

    }
}