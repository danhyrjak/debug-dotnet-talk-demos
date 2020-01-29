namespace DebugOnProdC31.Models
{
    public class RegistrationModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int AgeInYears { get; set; }
        public string AgeInYearsForDisplay
        {
            get
            {
                if(AgeInYears >= 21)
                {
                    return "21+";
                }
                return AgeInYears.ToString();
            }
        }
    }
}
