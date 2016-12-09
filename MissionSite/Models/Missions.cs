using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("Missions")]
    public class Missions
    {
        [Key]
        public decimal MissionID { get; set; }
        public string MissionName { get; set; }
        public string MissionPresidentsFirstName { get; set; }
        public string MissionPresidentsLastName { get; set; }
        public string MissionAddress { get; set; }
        public string MissionLanguage { get; set; }
        public string MissionClimate { get; set; }
        public string MissionDominantReligion { get; set; }
        public string MissionSymbol { get; set; }
    }
}