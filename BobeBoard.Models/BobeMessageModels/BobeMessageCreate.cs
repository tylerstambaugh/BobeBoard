using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobeBoard.Models
{
    public class BobeMessageCreate //properties from the entity, that when provided through the controller are used by the service to create a BobeMessage in the database. All data annotations are done on the entity, not the model?
    {
        [Required, Display(Name = "Title")]
        [MaxLength(140, ErrorMessage = "140 characters max please.")]
        [MinLength(3, ErrorMessage = "3 characters minimum please.")]
        public string MessageTitle { get; set; }

        [Required, Display(Name = "BobeMessage")]
        [MaxLength(140, ErrorMessage = "250 characters max please.")]
        [MinLength(3, ErrorMessage = "3 characters minimum please.")]
        public string MessageBody { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
    }
}
