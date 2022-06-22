using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class PetModel
    {
        /// <summary>
        /// Represents the primary ID of pet
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the owner of the pet
        /// </summary>
        public int OwnerID { get; set; }
        /// <summary>
        /// Represents the pet name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the type of the pet
        /// </summary>
        public string Species { get; set; }
        /// <summary>
        /// Base on species, this is the breed of the pet
        /// </summary>
        public string Breed { get; set; }
        /// <summary>
        /// Defines the color of the pet
        /// </summary>
        public string ColorMarking { get; set; }
        /// <summary>
        /// Represents the age of the pet
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Represents the gender of the pet
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Represents the notes for the pet
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// This is the count output from the database
        /// </summary>
        public int VisitsCount { get; set; }
        /// <summary>
        /// Represents the visits of the pet
        /// </summary>
        public List<VisitModel> Visits { get; set; } = new List<VisitModel>();

    }
}
