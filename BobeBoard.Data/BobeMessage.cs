using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobeBoard.Data
{
    public class BobeMessage
    {
        [Key]
        public int BobeMessageId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }


        [Required, Display(Name = "Title")]
        [MaxLength(140, ErrorMessage ="140 characters max please.")]
        [MinLength(3, ErrorMessage ="3 characters minimum please.")] 
        public string MessageTitle { get; set; }
        

        [Required, Display(Name = "BobeMessage")]
        [MaxLength(140, ErrorMessage ="250 characters max please.")]
        [MinLength(3, ErrorMessage ="3 characters minimum please.")]
        public string MessageBody { get; set; }


        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        //public DateTimeOffset ModifiedUtc { get; set; }

        [JsonIgnore]
        public virtual List<Reply> Replies { get; set; } = new List<Reply>();
       
    }
}
