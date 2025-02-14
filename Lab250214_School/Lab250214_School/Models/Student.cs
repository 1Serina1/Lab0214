using System.ComponentModel.DataAnnotations;

namespace Lab250214_School.Models
{
    public class Student
    {
        //[Display(Name = "Number")]
        public int sID { get; set; }
        [Display(Name = "姓名")]
        public string sName { get; set; }
        [Display(Name = "國文")]
        public int Chinese { get; set; }
        [Display(Name = "英文")]
        public int English { get; set; }
        [Display(Name = "數學")]
        public int Math { get; set; }
        [Display(Name = "總分")]
        public int Total { get; set; }

    }
}
