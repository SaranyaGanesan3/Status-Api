using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatusAPI.FiberConnection;

namespace StatusAPI.Repository
{
    public class StatusRepo:IStatusRepo<Status>
    {
        private readonly IStatus<Status> s_obj;
        public StatusRepo(IStatus<Status> _s_obj)
        {
            s_obj = _s_obj;
        }
        public async Task<List<Status>> GetAllStatus(int id)
        {
            return await s_obj.GetAllStatus(id);
        }

        public async Task<Status> GetStatusByID(int id)
        {
            return await s_obj.GetStatusByID(id);
        }

        public async Task<int> DeleteStatus(int id)
        {
           return await s_obj.DeleteStatus(id);
        }
        public async Task<int> EditStatus(Status s)
        {
            return await s_obj.EditStatus(s);
        }
        public async Task<List<Status>> AllStatus()
        {
            return (await s_obj.AllStatus());
        }
    }
}
