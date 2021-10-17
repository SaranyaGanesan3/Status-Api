using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatusAPI.Repository
{
    public interface IStatusRepo<Status>
    {
        public Task<List<Status>> GetAllStatus(int id);
        public Task<Status> GetStatusByID(int id);
        public Task<int> DeleteStatus(int id);
        public Task<int> EditStatus(Status s);
        public Task<List<Status>> AllStatus();
    }
}
