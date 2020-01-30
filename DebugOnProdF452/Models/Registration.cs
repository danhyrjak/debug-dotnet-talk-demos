using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DebugOnProdF452.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int AgeInYears { get; set; }

        [NotMapped]
        public string AgeInYearsForDisplay
        {
            get
            {
                if (AgeInYears >= 21)
                {
                    return "21+";
                }
                return AgeInYears.ToString();
            }
        }
    }
}