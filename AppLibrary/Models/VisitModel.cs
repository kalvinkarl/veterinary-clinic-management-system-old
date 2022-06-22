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
        public int ID { get; set; }
        /// <summary>
        /// Represents the pet who visits
        /// </summary>
        public int PetID { get; set; }
        /// <summary>
        /// Represents the weight of the pet
        /// </summary>
        public string Weight { get; set; }
        /// <summary>
        /// Represents the temperature of the pet
        /// </summary>
        public string Temperature { get; set; }
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
        /// <summary>
        /// Represents the bill of the visit
        /// </summary>
        public BillModel Bill { get; set; }
        /// <summary>
        /// This is the count output from the database
        /// </summary>
        public int VisitsCount { get; set; }
        public string WTT
        {
            get
            {
                return $"{Weight}/{Temperature}";
            }
        }
    }
}
