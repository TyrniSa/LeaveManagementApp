using LeaveManagementApplication.Contracts;
using LeaveManagementData;

namespace LeaveManagementApplication.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
