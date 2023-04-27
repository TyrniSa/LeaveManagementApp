using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            foreach (var employee in employees)
            {
                var allocation = new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period= period,
                    NumberOfDays = leaveType.DefaultDays
                };

                await AddAsync(allocation);
            }

            throw new NotImplementedException();
        }
    }
}
