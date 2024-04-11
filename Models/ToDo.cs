using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualBasic;

namespace ToDo_List.Models
{
    public class ToDo : IToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(40, ErrorMessage = "Description must be 40 characters or less")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        [Range(typeof(DateTime), "1/1/2000 00:00 AM", "12/31/2050 11:59 PM", ErrorMessage = "Date entered must be between 1/1/2000 and 12/31/2050.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue =>
            StatusId == "open" && DueDate < DateTime.Today;

        public Cart(IHttpContextAccessor ctx)
        {
            session = ctx.HttpContext!.Session;
            requestCookies = ctx.HttpContext!.Request.Cookies;
            responseCookies = ctx.HttpContext!.Response.Cookies;        }
        }
}
