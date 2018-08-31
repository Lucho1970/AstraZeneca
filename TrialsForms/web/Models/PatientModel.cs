using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialsSurveys.Models
{
    public class PatientModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Clinic Id")]
        public string ClinicId { get; set; }

        [Required]
        [Display(Name = "Patient Id")]
        public string PatientId { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

    }

    public class PatientListViewModel : List<PatientModel>
    {

    }
}