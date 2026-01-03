using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSB.Models
{

    [Table("VehicleService")]
    public class VehicleService
    {
        [Key]
        [Column("sid", TypeName ="int")]
        public int SId { get; set; }

        [Column("sname", TypeName ="varchar(50)")]
        public string? SName { get; set; }


        [Column("duration", TypeName="float")]
        public double SDuration { get; set; }

        [Column("price", TypeName = "float")]
        public double SPrice { get; set; }

        public VehicleService(int sId, string? sName, double sDuration, double sPrice)
        {
            SId = sId;
            SName = sName;
            SDuration = sDuration;
            SPrice = sPrice;
        }


        public VehicleService(string? sName, double sDuration, double sPrice)
        {
            SName = sName;
            SDuration = sDuration;
            SPrice = sPrice;
        }
        public VehicleService()
        {
        }

        public override string? ToString()
        {
            return $"ServiceName : {SName}, ServiceDuration : {SDuration}, ServicePrice : {SPrice}";
        }
    }
}
