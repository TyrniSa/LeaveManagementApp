using System.ComponentModel.DataAnnotations;

namespace LeaveManagementCommon.Models
{
    public class AdminLeaveRequestViewVM
    {
        [Display(Name = "Total number of requests")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
