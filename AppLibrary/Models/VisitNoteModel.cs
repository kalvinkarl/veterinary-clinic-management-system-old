using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class VisitNoteModel
    {
        public int ID { get; set; }
        public int VisitID { get; set; }
        public string Notes { get; set; }
    }
}
