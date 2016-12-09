using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public decimal MissionQuestionID { get; set; }
        public decimal MissionID { get; set; }
        public decimal UserID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}