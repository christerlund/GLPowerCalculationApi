using System.ComponentModel.DataAnnotations;

namespace GLPowerCalculationApi.Models
{

    /// <summary>
    /// Model for holding calculation data
    /// 
    /// Regex - "^(0|[1-9][0-9]*)$" allows 0 and positive whole numbers  
    /// </summary>
    public class CalculationItem
    {
        [RegularExpression("^(0|[1-9][0-9]*)$")]
        public int P { get; set; }
        [RegularExpression("^(0|[1-9][0-9]*)$")]
        public int U1 { get; set; }
        [RegularExpression("^(0|[1-9][0-9]*)$")]
        public int U2 { get; set; }
        [RegularExpression("^(0|[1-9][0-9]*)$")]
        public int U3 { get; set; }
        [RegularExpression("^(0|[1-9][0-9]*)$")]
        public int I1 { get; set; }
        [RegularExpression("^(0|[1-9][0-9]*)$")]
        public int I3 { get; set; }
    }
}
