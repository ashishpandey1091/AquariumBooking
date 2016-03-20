using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace D05.Models
{
    public class Profile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
        public int Profile_Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Please enter valid FirstName, it should not exceed the Limit ")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z”-‘\s]{1,40}$", ErrorMessage = "Please enter valid LastName, it should not exceed the Limit and only Alphabets")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Please Contact us for Assistance, we will provide everything for free if you are 120+ agged. ")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Please enter valid password, it should not exceed the Limit ")]
        public string Password { get; set; }

        [MinLength(1)]
        [MaxLength(200, ErrorMessage = "Please enter valid question, it should not exceed the Limit ")]
        public string Question { get; set; }

        [MinLength(1)]
        [MaxLength(200, ErrorMessage = "Please enter valid answer, it should not exceed the Limit ")]
        public string Answer { get; set; }

        [MinLength(1)]
        [MaxLength(8, ErrorMessage = "Please enter valid coupon, it should not exceed the Limit ")]
        public string PersonalCoupon { get; set; }


        public static List<Profile> ReadAllFromCSV(string filepath)
        {
            List<Profile> lst = File.ReadAllLines(filepath)
                                        .Skip(1)
                                        .Select(v => Profile.OneFromCsv(v))
                                        .ToList();
            return lst;
        }


        public static Profile OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Profile item = new Profile();

            int i = 0;
            item.Profile_Id = Convert.ToInt32(values[i++]);
            item.FirstName = Convert.ToString(values[i++]);
            item.LastName = Convert.ToString(values[i++]);
            item.Email = Convert.ToString(values[i++]);
            String tempAge = values[i++];
            item.Age = 0;
            item.Password = Convert.ToString(values[i++]);
            item.Question = Convert.ToString(values[i++]);

            item.Answer = Convert.ToString(values[i++]);
            item.PersonalCoupon = Convert.ToString(values[i++]);



            return item;
        }
    }
}

