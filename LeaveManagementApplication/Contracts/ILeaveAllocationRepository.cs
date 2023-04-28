using LeaveManagementData;
using LeaveManagementCommon.Models;

namespace LeaveManagementApplication.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string id);
        Task<LeaveAllocationEditVM> GetOneEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
