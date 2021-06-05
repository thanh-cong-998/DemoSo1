using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoSo1.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public string ID { get; set; }
        public string TenHang{ get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}