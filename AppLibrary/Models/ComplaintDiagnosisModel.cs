using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class ComplaintDiagnosisModel
    {
        public int ID { get; set; }
        public int VisitID { get; set; }
        public string ComplaintDiagnosis { get; set; }
        public decimal Amount { get; set; }
    }
}
