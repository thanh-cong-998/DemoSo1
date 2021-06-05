using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoSo1.Models
{
    public class HoaDon
    {
        [Key]
        public string ID_HD { get; set; }
        public string TenHoaDon { get; set; }
        public DateTime NgayMua { get; set; }
        public string ID { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}