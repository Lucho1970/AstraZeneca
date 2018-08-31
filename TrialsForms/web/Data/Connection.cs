using System;
using System.Collections.Generic;
using TrialsSurveys.Models;

namespace TrialsSurveys.Data
{
    public class Connection
    {
    }

    public static class Clinic
    {
        public static List<ClinicModel> GetClinics()
        {
            var clinics = new List<ClinicModel>
                {
                    new ClinicModel
                    {
                        Id = 1,
                        ClinicId = "CDE001",
                        ClinicName = "The Best Darn Clinic",
                        DateCreated = DateTime.Today.AddDays(-30),
                        Address1 = "123 Main St.",
                        Address2 = string.Empty,
                        City = "Toronto",
                        Province = "ON",
                        PostalCode = "M3N4B5",
                        EmailAddress = "email1@mydomain.com",
                        PhoneNumber = "416-234-3232",
                        FaxNumber = "416-939-4433"
                    },
                    new ClinicModel
                    {
                        Id = 2,
                        ClinicId = "DCA002",
                        ClinicName = "Some Other Clinic",
                        DateCreated = DateTime.Today.AddDays(-20),
                        Address1 = "23 Queen St.",
                        Address2 = string.Empty,
                        City = "Toronto",
                        Province = "ON",
                        PostalCode = "M3B8J5",
                        EmailAddress = "email2@wedomain.com",
                        PhoneNumber = "416-434-5432",
                        FaxNumber = "416-334-8457"
                    },
                    new ClinicModel
                    {
                        Id = 3,
                        ClinicId = "GIKJ030",
                        ClinicName = "Good Clinic",
                        DateCreated = DateTime.Today.AddDays(-24),
                        Address1 = "63 King St.",
                        Address2 = string.Empty,
                        City = "Toronto",
                        Province = "ON",
                        PostalCode = "M5F7J3",
                        EmailAddress = "erer@myrrin.com",
                        PhoneNumber = "416-732-7309",
                        FaxNumber = "416-335-8251"
                    }
                };
            return clinics;
        }

        public static ClinicModel GetClinic(string clinicId)
        {
            foreach (var clinicModel in GetClinics())
            {
                if (clinicModel.ClinicId == clinicId) return clinicModel;
            }

            return null;
        }

    }

    public static class Patient
    {
        public static List<PatientModel> GetPatients()
        {
            var patients = new List<PatientModel>
                {
                    new PatientModel
                    {
                        Id = 1,
                        ClinicId = "ABC001",
                        PatientId = "DSA999",
                        DateCreated = DateTime.Today.AddDays(-20)
                    },
                    new PatientModel
                    {
                        Id = 2,
                        ClinicId = "ABC001",
                        PatientId = "MNB999",
                        DateCreated = DateTime.Today.AddDays(-10)
                    },
                    new PatientModel
                    {
                        Id = 3,
                        ClinicId = "ABC001",
                        PatientId = "NDJ765",
                        DateCreated = DateTime.Today.AddDays(-15)
                    },
                    new PatientModel
                    {
                        Id = 4,
                        ClinicId = "ABC001",
                        PatientId = "JNB654",
                        DateCreated = DateTime.Today.AddDays(-22)
                    }
                };

            return patients;
        }

        public static PatientModel GetPatient(string patientId)
        {
            foreach (var patientModel in GetPatients())
            {
                if (patientModel.PatientId == patientId) return patientModel;
            }

            return null;
        }

    }
}