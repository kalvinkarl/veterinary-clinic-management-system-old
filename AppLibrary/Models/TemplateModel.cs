using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class TemplateModel
    {
        /// <summary>
        /// Represents the unique identity of the template
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the category of the template
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Represents the title of the template
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Represents the template itself
        /// </summary>
        public string Template { get; set; }
    }
}
