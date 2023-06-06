using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unique Id for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First name of Player
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of Player
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of the player
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Phone number of the player
        /// </summary>
        public string PhoneNumber { get; set; }

        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
