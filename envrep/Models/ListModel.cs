using System.ComponentModel;

namespace envrep.Models
{
    public class ListModel
    {
        public List<RecordPostViewModel> Records { get; set; }

        [DisplayName("Id")]
        public int? id { get; set; }
        [DisplayName("Temperature")]
        public double? temp { get; set; }
        [DisplayName("Humidity")]
        public double? hum { get; set; }
        [DisplayName("Co2")]
        public double? co2 { get; set; }
    }
}
