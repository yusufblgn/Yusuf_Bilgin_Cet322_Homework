using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppCoreMVCCodeFirst._24._03._2023_22.Models
{
    public class Student
    {

        [Key]
        public int StudentdsID { get; set; }
        public string StudentdsNo { get; set; }
        public string StudentdsName { get; set; }
        public string StudentdsSurname { get; set; }
        public string EMail { get; set; }
        public int DeptID { get; set; }
        [ForeignKey("DeptID")]
        public Department Department { get; set; }

    }
}
