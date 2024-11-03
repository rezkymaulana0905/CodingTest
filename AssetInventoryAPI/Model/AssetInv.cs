using System.ComponentModel.DataAnnotations;

namespace AssetInventoryAPI.Model
{
    public class AssetInv
    {
        [Key]
        public string agreement_number { get; set; }
        public string bpkb_no { get; set; }

        public DateTime bpkb_date { get; set; }

        public string faktur_No { get; set; }

        public DateTime faktur_date { get; set; }
        public string location_id { get; set; }
        public string police_no { get; set; }
        public DateTime bpkb_date_in { get; set; }
        public string create_by { get; set; }
        public DateTime created_on { get; set; }
        public DateTime lastupdated_by { get; set; }
    }
}
