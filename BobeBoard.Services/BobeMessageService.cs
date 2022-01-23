using BobeBoard.Data;
using BobeBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobeBoard.Services
{
    public class BobeMessageService
    {
        private readonly Guid _userId;

        public BobeMessageService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateBobeMessage(BobeMessageCreate bobeMessageCreateModel)
        {
            //create an entity/object from the model and save it using the DB context.
            BobeMessage messageToCreate = new BobeMessage()
            {
                OwnerId = _userId,
                MessageTitle = bobeMessageCreateModel.MessageTitle,
                MessageBody = bobeMessageCreateModel.MessageBody,
                CreatedUtc = bobeMessageCreateModel.CreatedUtc
            };

            using (var ctx = new ApplicationDbContext())
            {
               // ctx.BobeMesssage.Add(messageToCreate);
                return ctx.SaveChanges() == 1;
            }
             
        }
    }
}
