using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialsSurveys.Models
{
    public class SurveyLuisViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "SurveyLuis_Question01", ResourceType = typeof(Resources.Resources))]
        [Range(1, 7)]
        public int Question01 { get; set; }

        [Required]
        [Display(Name = "SurveyLuis_Question02", ResourceType = typeof(Resources.Resources))]
        [Range(1, 7)]
        public int Question02 { get; set; }

        [Required]
        [Display(Name = "SurveyLuis_Question03", ResourceType = typeof(Resources.Resources))]
        [Range(1, 7)]
        public int Question03 { get; set; }

        [Required]
        [Display(Name = "SurveyLuis_Question04", ResourceType = typeof(Resources.Resources))]
        [Range(1, 7)]
        public int Question04 { get; set; }
    }
}