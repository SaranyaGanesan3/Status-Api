using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatusAPI.FiberConnection;
using StatusAPI.Repository;

namespace StatusAPI.Service
{
    public class StatusServ : IStatusServ<Status>
    {
        private readonly IStatusRepo<Status> s_repo;
        public StatusServ(IStatusRepo<Status> _s_repo)
        {
            s_repo = _s_repo;
        }
        public async Task<int> DeleteStatus(int id)
        {
           return await s_repo.DeleteStatus(id);
        }

        public async Task<List<Status>> GetAllStatus(int id)
        {
            return await s_repo.GetAllStatus(id);
        }

        public async Task<Status> GetStatusByID(int id)
        {
            return await s_repo.GetStatusByID(id);
        }
        public async Task<int> EditStatus(Status s)
        {
            return await s_repo.EditStatus(s);
        }
        public async Task<List<Status>> AllStatus()
        {
            return (await s_repo.AllStatus());
        }
    }
}
