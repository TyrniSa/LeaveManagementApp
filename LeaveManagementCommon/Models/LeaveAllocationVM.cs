using System.ComponentModel.DataAnnotations;

namespace LeaveManagementCommon.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number of days")]
        [Required]
        [Range(1,50, ErrorMessage = "Invalid number.")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation period")]
        public int Period { get; set; }

        public LeaveTypeVM? LeaveType { get; set; }
    }
}