using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace StatusAPI.FiberConnection
{
    public partial class Status:IStatus<Status>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();

        public int StatusId { get; set; }
        public string Status1 { get; set; }
        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
        public int? PlanId { get; set; }
        public int? BillingNumber { get; set; }
        public double? PlanPrice { get; set; }
        public string PlanName { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhonenumber { get; set; }
        public string CustomerPhonenumber { get; set; }
        public string CustomerAddress { get; set; }
        public virtual Billing BillingNumberNavigation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual FiberPlan Plan { get; set; }
        public async Task<int> DeleteStatus(int id)
        {
            Status s = fcc.Statuses.Find(id);
            fcc.Statuses.Remove(s);
            return await fcc.SaveChangesAsync();
        }

        public async Task<List<Status>> GetAllStatus(int id)
        {
            return await ( from i in fcc.Statuses where i.CustomerId == id select i).ToListAsync();
        }

        public async Task<Status> GetStatusByID(int id)
        {
            return await fcc.Statuses.FindAsync(id);
        }
        public async Task<int> EditStatus(Status s)
        {
            fcc.Entry(s).State = EntityState.Modified;
            return await fcc.SaveChangesAsync();
        }
        public async Task<List<Status>> AllStatus()
        {
            return await fcc.Statuses.ToListAsync();
        }
    }
}
