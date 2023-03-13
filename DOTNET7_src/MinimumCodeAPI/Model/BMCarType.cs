using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MinimumCodeAPI.Model
{
    [Index(nameof(CarType), IsUnique = true)]
    public class BMCarType
    { 

        [Required]
        [MaxLength(80)]
        public string CarType { get; set; }
        [Required]
        public int? NumOfSeats { get; set; }

        [Required]
        [MaxLength(200)]
        public string DefaultImagePath { get; set; }
        public static bool IsOrderByDescending { get; set; } = false;





        [Key]
        public Guid Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required]
        public long ROW_NUM { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }
        [Required]
        [MaxLength(36)]
        public string CreatedByIP { get; set; }

        [MaxLength(36)]
        public string? UpdatedByIP { get; set; }
    }
}
