using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AreaHelper.Entities
{
    public class Area
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        public string BolgeAd { get; set; }
        [StringLength(50)]
        public string Mevki { get; set; }
    }
}
