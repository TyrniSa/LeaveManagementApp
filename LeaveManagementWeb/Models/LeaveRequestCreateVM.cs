using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Enter a start date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End date")]
        [Required(ErrorMessage = "Enter an end date")]
        public DateTime? EndDate { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The start date must be before the end date.", new[] { nameof(StartDate),
                                                                                                    nameof(EndDate) });
            }
            if (RequestComments?.Length > 500)
            {
                yield return new ValidationResult("Comment must be under 500 characters.", new[] { nameof(RequestComments) });
            }
        }
    }
}
