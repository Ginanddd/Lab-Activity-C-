using System;

namespace Activity2B
{
    public class Data
    {
        public string GetData(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "Invalid input.";

            input = input.ToLower().Trim();

            switch (input)
            {
                case "what is your id number?": return "21436613";
                case "what is your course?": return "Bachelor of Science in Computer Science";
                case "what is your year level?": return "2ND Year";
                case "what is your first name?": return "Roginand";
                case "what is your last name?": case "what is your family name?": return "Villegas";
                case "what is your middle name?": return "N/A";
                case "what is your email address?": return "roginandv@gmail.com";
                case "what is your home address?": return "Ermita Proper Cebu City";
                case "what is your father's name?": return "N/A";
                case "what is your mother's name?": return "Fryl Villegas";
                case "when is your date of birth?": return "November 14, 2004";
                case "what is your age?": return "20 Years Old";
                case "what is your phone number?": return "09104146278";
                case "what is your parent contact information?": return "09540654377";
                case "what are your skills and interests?": return "Analytical Thinking Skills, Adaptability, and Willingness to Learn";
                default: return "Invalid Input!";
            }
        }
    }
}
