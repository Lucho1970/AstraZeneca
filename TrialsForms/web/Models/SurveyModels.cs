using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialsSurveys.Models
{
    public class SurveyBase
    {
        public string SurveyName { get; set; }
        public string SurveyDescription { get; set; }
        public string PatientId { get; set; }

    }
    public class AQLQ_s_12:SurveyBase
    {
        public AQLQ_s_12()
        {
            SurveyName = "ASTHMA QUALITY OF LIFE QUESTIONNAIRE WITH STANDARDISED ACTIVITIES (AQLQ(S))";
        }
        [Display(Name = "Answer question one")]
        public int Question1 { get; set; }

        [Display(Name = "Answer question two")]
        public int Question2 { get; set; }

        [Display(Name = "Answer question three")]
        public int Question3 { get; set; }

    }
}