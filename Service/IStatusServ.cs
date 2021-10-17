using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatusAPI.Service
{
    public interface IStatusServ<Status>
    {
        public Task<List<Status>> GetAllStatus(int id);
        public Task<Status> GetStatusByID(int id);
        public Task<int> EditStatus(Status s);
        public Task<int> DeleteStatus(int id);
        public Task<List<Status>> AllStatus();
    }
}
