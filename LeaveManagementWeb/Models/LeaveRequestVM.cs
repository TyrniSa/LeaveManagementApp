using LeaveManagementWeb.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Request Date")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }

    }
}
