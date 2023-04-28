using System.ComponentModel.DataAnnotations;

namespace LeaveManagementCommon.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Request Date")]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }

    }
}
