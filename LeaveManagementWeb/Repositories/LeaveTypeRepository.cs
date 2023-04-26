using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
