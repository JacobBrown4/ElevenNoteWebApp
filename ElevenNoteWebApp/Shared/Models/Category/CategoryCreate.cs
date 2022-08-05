using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteWebApp.Shared.Models.Category
{
    public class CategoryCreate
    {
        [Required]
        public string Name { get; set; }
    }
}
