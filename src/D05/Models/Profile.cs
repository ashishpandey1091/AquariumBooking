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
        public int ProfileID { get; set; }
        [Required][Range(1,50)]
        public string FirstName { get; set; }
        [Required][Range(1,50)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        [Required]
        [Range(1, 30)]
        public string Password { get; set; }
        
        [Range(1, 200)]
        public string Question { get; set; }
       
        [Range(1, 50)]
        public string Answer { get; set; }
        
        [Range(1, 6)]
        public string PersonalCoup { get; set; }
        

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
            item.ProfileID = Convert.ToInt32(values[i++]);
            item.FirstName = Convert.ToString(values[i++]);
            item.LastName = Convert.ToString(values[i++]);
            item.Email = Convert.ToString(values[i++]);
            String tempAge = values[i++];
            item.Age = 0;
            item.Password = Convert.ToString(values[i++]);
            item.Question = Convert.ToString(values[i++]);
            
            item.Answer = Convert.ToString(values[i++]);
            item.PersonalCoup = Convert.ToString(values[i++]);
            


            return item;
        }
    }
}

