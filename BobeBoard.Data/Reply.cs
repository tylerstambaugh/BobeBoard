using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobeBoard.Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }



        [Required, Display(Name = "Reply")]
        [MaxLength(140, ErrorMessage = "140 characters max please.")]
        [MinLength(3, ErrorMessage = "3 characters minimum please.")]
        public string ReplyContent { get; set; }


        [Required]
        public Guid OwnerId { get; set; }


        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        
        
        [ForeignKey(nameof(BobeMessage)), Required]
        public int BobeMessageId { get; set; }
        public virtual BobeMessage BobeMessage { get; set; }
    }
}
