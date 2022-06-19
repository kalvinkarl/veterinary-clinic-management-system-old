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
        /// Represents the month,day and year of the visit
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Represents the weight of the pet
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Represents the temperature of the pet
        /// </summary>
        public int Temperature { get; set; }
        /// <summary>
        /// Represents the Complaint or Diagnosis of the start
        /// </summary>
        public List<ComplaintDiagnosisModel> ComplaintDiagnosis { get; set; } = new List<ComplaintDiagnosisModel>();
        /// <summary>
        /// Represents the treatment procedure
        /// </summary>
        public List<TreatmentModel> Treatment { get; set; } = new List<TreatmentModel>();
        /// <summary>
        /// Represents the visit notes
        /// </summary>
        public List<VisitNoteModel> VisitNotes { get; set; } = new List<VisitNoteModel>();
        /// <summary>
        /// Represents the date of next visit
        /// </summary>
        public DateTime NextVisit { get; set; }
        /// <summary>
        /// Represents the bills costumer must pay
        /// </summary>
        public List<BillModel> Billings { get; set; } = new List<BillModel>();
    }
}
