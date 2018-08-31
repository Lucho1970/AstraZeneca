using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialsSurveys.Models
{
    public class SurveysModel
    {
        [Key]
        [Required]
        public string SurveyId { get; set; }

        [Required]
        [Display(Name = "Survey name")]
        public string SurveyName { get; set; }

        [Required]
        [Display(Name = "Completed")]
        public bool Completed { get; set; } = false;
    }
}