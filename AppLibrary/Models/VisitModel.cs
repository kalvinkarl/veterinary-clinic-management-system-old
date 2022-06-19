using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class VisitModel
    {
        /// <summary>
        /// Represents the primary ID of visits
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Represents the pet
        /// </summary>
        public PetModel Pet { get; set; }
        /// <summary>
        /// Represents the weight of the pet
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Represents the temperature of the pet
        /// </summary>
        public int Temperature { get; set; }
        /// <summary>
        /// Represents the Complaint or Diagnosis of the pet
        /// </summary>
        public string ComplaintDiagnosis { get; set; }
        /// <summary>
        /// Represents the treatment procedure
        /// </summary>
        public string Treatment { get; set; }
        /// <summary>
        /// Represents the visit notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Represents the month,day and year of the visit
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Represents the date of next visit
        /// </summary>
        public DateTime NextVisit { get; set; }
    }
}
