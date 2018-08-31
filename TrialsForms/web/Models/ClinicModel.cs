using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrialsSurveys.Models
{
    public class ClinicModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Clinic Id")]
        public string ClinicId { get; set; }

        [Required]
        [Display(Name = "Clinic name")]
        public string ClinicName { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Required]
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Required]
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Fax number")]
        public string FaxNumber { get; set; }

        [Required]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

    }

    public class ClinicListViewModel : List<ClinicModel>
    {

    }
}