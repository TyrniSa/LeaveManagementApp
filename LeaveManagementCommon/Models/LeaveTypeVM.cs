using System.ComponentModel.DataAnnotations;

namespace LeaveManagementCommon.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave type")]
        [Required(ErrorMessage = "Enter a name for leave type")]
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        [Required]
        [Range(1,30, ErrorMessage ="Number must be between 1-30")]
        public int DefaultDays { get; set; }
    }
}
