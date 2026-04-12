using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreCrudDemo.Models
{
    public class Student
    {
        [Key]
        [Display (Name ="Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        public string Email {  get; set; }
        public string Course {  get; set; }
       
        [Display(Name = "Enorllment Date")]
        public DateTime EnorllmentDate {  get; set; }

    }
}
