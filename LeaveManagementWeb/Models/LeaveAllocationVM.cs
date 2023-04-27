using LeaveManagementWeb.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LeaveManagementWeb.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Number of days")]
        [Required]
        [Range(1,50, ErrorMessage = "Invalid number.")]
        public int NumberOfDays { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
        [Required]
        [Display(Name = "Allocation period")]
        public int Period { get; set; }
    }
}