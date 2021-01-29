using CoreArsaOfisi.BusinessLayer.Repository.Abstract;
using CoreArsaOfisi.BusinessLayer.Repository.Concrete;
using CoreArsaOfisi.DataLayer.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreArsaOfisi.BusinessLayer.Business
{
    public class MessageBusiness
    {
        private IRepository<Message> _messageRepository;
        private IUnitOfWork _messageUnitOfWork;
        private DbContext _dbContext;

        public MessageBusiness()
        {
            _dbContext = new u9673886_arsdbContext();
            _messageUnitOfWork = new EFUnitOfWork(_dbContext);
            _messageRepository = _messageUnitOfWork.GetRepository<Message>();
        }


        public void AddMessage(Message message)
        {
            _messageRepository.AddAsync(message);
            _messageUnitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Message>> GetAllMessageAsync()
        {
            return await _messageRepository.GetAllAsync();
        }
    }
}
