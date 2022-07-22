using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PublisherMan
    {
        Repository<publisher> publisherRepo = new Repository<publisher>();

        public List<publisher> GetAll()
        {
            return publisherRepo.List();
        }
    }
}
