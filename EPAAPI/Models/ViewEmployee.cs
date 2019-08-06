//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewEmployee
    {
        public int Id { get; set; }
        public string PID { get; set; }
        public Nullable<int> CurrentLocationAirport { get; set; }
        public Nullable<System.DateTime> DateJoinCompany { get; set; }
        public Nullable<int> ExpCompany { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public Nullable<System.DateTime> DateConfirmed { get; set; }
        public bool IsDeleted { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int MarriageId { get; set; }
        public string NID { get; set; }
        public int SexId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateBirth { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string FaxTelNumber { get; set; }
        public string PassportNumber { get; set; }
        public Nullable<System.DateTime> DatePassportIssue { get; set; }
        public Nullable<System.DateTime> DatePassportExpire { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> DateJoinAvation { get; set; }
        public Nullable<int> Exp { get; set; }
        public Nullable<System.DateTime> DateLastCheckUP { get; set; }
        public Nullable<System.DateTime> DateNextCheckUP { get; set; }
        public Nullable<System.DateTime> DateYearOfExperience { get; set; }
        public string CaoCardNumber { get; set; }
        public Nullable<System.DateTime> DateCaoCardIssue { get; set; }
        public Nullable<System.DateTime> DateCaoCardExpire { get; set; }
        public string CompetencyNo { get; set; }
        public Nullable<int> CaoInterval { get; set; }
        public Nullable<int> CaoIntervalCalanderTypeId { get; set; }
        public string Remark { get; set; }
        public string StampNumber { get; set; }
        public string StampUrl { get; set; }
        public string TechLogNo { get; set; }
        public Nullable<System.DateTime> DateIssueNDT { get; set; }
        public Nullable<int> IntervalNDT { get; set; }
        public string NDTNumber { get; set; }
        public Nullable<int> NDTIntervalCalanderTypeId { get; set; }
        public string Nickname { get; set; }
        public Nullable<int> CityId { get; set; }
        public string FatherName { get; set; }
        public string IDNo { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> CustomerCreatorId { get; set; }
        public Nullable<int> Age { get; set; }
        public int LocationId { get; set; }
        public Nullable<int> OrgRoleId { get; set; }
        public string LocationPhone { get; set; }
        public bool IsMainLocation { get; set; }
        public string MaritalStatus { get; set; }
        public string Sex { get; set; }
        public string CaoIntervalCalanderType { get; set; }
        public string NDTIntervalCalanderType { get; set; }
        public string City { get; set; }
        public Nullable<int> StateId { get; set; }
        public string State { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Country { get; set; }
        public string CityFullName { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public Nullable<int> RootLocation { get; set; }
        public string LocationCode { get; set; }
        public int PersonId { get; set; }
        public int EmployeeLocationId { get; set; }
        public string Post { get; set; }
        public Nullable<int> RemainNDT { get; set; }
        public Nullable<int> RemainCAO { get; set; }
        public Nullable<int> RemainPassport { get; set; }
        public int IsNDTExpired { get; set; }
        public int IsNDTExpiring { get; set; }
        public int IsCAOExpired { get; set; }
        public int IsCAOExpiring { get; set; }
        public int IsMedicalExpiring { get; set; }
        public int IsPassportExpired { get; set; }
        public int IsPassportExpiring { get; set; }
        public Nullable<System.DateTime> DateExpireNDT { get; set; }
        public Nullable<int> CriticalCertificatesCount { get; set; }
        public Nullable<int> BookAlert { get; set; }
        public string Types { get; set; }
        public Nullable<System.DateTime> ProficiencyExpireDate { get; set; }
        public Nullable<System.DateTime> CrewMemberCertificateExpireDate { get; set; }
        public Nullable<System.DateTime> LicenceExpireDate { get; set; }
        public Nullable<System.DateTime> LicenceIRExpireDate { get; set; }
        public Nullable<System.DateTime> SimulatorLastCheck { get; set; }
        public Nullable<System.DateTime> SimulatorNextCheck { get; set; }
        public string RampPassNo { get; set; }
        public Nullable<System.DateTime> RampPassExpireDate { get; set; }
        public Nullable<System.DateTime> LanguageCourseExpireDate { get; set; }
        public string LicenceTitle { get; set; }
        public Nullable<System.DateTime> LicenceInitialIssue { get; set; }
        public string RaitingCertificates { get; set; }
        public Nullable<System.DateTime> LicenceIssueDate { get; set; }
        public string LicenceDescription { get; set; }
        public Nullable<int> ProficiencyCheckType { get; set; }
        public Nullable<System.DateTime> ProficiencyCheckDate { get; set; }
        public Nullable<System.DateTime> ProficiencyValidUntil { get; set; }
        public Nullable<int> ICAOLPRLevel { get; set; }
        public Nullable<System.DateTime> ICAOLPRValidUntil { get; set; }
        public Nullable<int> MedicalClass { get; set; }
        public string PostalCode { get; set; }
        public string MedicalLimitation { get; set; }
        public string ProficiencyDescription { get; set; }
        public Nullable<System.DateTime> VisaExpireDate { get; set; }
        public Nullable<System.DateTime> SEPTIssueDate { get; set; }
        public Nullable<System.DateTime> SEPTExpireDate { get; set; }
        public Nullable<System.DateTime> SEPTPIssueDate { get; set; }
        public Nullable<System.DateTime> SEPTPExpireDate { get; set; }
        public Nullable<System.DateTime> DangerousGoodsIssueDate { get; set; }
        public Nullable<System.DateTime> DangerousGoodsExpireDate { get; set; }
        public Nullable<System.DateTime> CCRMIssueDate { get; set; }
        public Nullable<System.DateTime> CCRMExpireDate { get; set; }
        public Nullable<System.DateTime> CRMIssueDate { get; set; }
        public Nullable<System.DateTime> CRMExpireDate { get; set; }
        public Nullable<System.DateTime> SMSIssueDate { get; set; }
        public Nullable<System.DateTime> SMSExpireDate { get; set; }
        public Nullable<System.DateTime> AviationSecurityIssueDate { get; set; }
        public Nullable<System.DateTime> AviationSecurityExpireDate { get; set; }
        public Nullable<System.DateTime> EGPWSIssueDate { get; set; }
        public Nullable<System.DateTime> EGPWSExpireDate { get; set; }
        public Nullable<System.DateTime> UpsetRecoveryTrainingIssueDate { get; set; }
        public Nullable<System.DateTime> UpsetRecoveryTrainingExpireDate { get; set; }
        public Nullable<System.DateTime> ColdWeatherOperationIssueDate { get; set; }
        public Nullable<System.DateTime> HotWeatherOperationIssueDate { get; set; }
        public Nullable<System.DateTime> ColdWeatherOperationExpireDate { get; set; }
        public Nullable<System.DateTime> HotWeatherOperationExpireDate { get; set; }
        public Nullable<System.DateTime> FirstAidIssueDate { get; set; }
        public Nullable<System.DateTime> FirstAidExpireDate { get; set; }
        public Nullable<System.DateTime> PBNRNAVIssueDate { get; set; }
        public Nullable<System.DateTime> PBNRNAVExpireDate { get; set; }
        public Nullable<int> RemainFirstAid { get; set; }
        public int IsFirstAidExpired { get; set; }
        public Nullable<int> RemainCMC { get; set; }
        public int IsCMCExpired { get; set; }
        public Nullable<int> RemainLicence { get; set; }
        public int IsLicenceExpired { get; set; }
        public Nullable<int> RemainLicenceIR { get; set; }
        public int IsLicenceIRExpired { get; set; }
        public Nullable<int> RemainProficiency { get; set; }
        public int IsProficiencyExpired { get; set; }
        public Nullable<int> RemainLPR { get; set; }
        public int IsLPRExpired { get; set; }
        public Nullable<int> RemainMedical { get; set; }
        public int IsMedicalExpired { get; set; }
        public Nullable<int> RemainSEPT { get; set; }
        public int IsSEPTExpired { get; set; }
        public Nullable<int> RemainSEPTP { get; set; }
        public int IsSEPTPExpired { get; set; }
        public Nullable<int> RemainDG { get; set; }
        public int IsDGExpired { get; set; }
        public Nullable<int> RemainCRM { get; set; }
        public int IsCRMExpired { get; set; }
        public Nullable<int> RemainCCRM { get; set; }
        public int IsCCRMExpired { get; set; }
        public Nullable<int> RemainSMS { get; set; }
        public int IsSMSExpired { get; set; }
        public Nullable<int> RemainAvSec { get; set; }
        public int IsAvSecExpired { get; set; }
        public Nullable<int> RemainUpsetRecoveryTraining { get; set; }
        public int IsUpsetRecoveryTrainingExpired { get; set; }
        public Nullable<int> RemainColdWeather { get; set; }
        public int IsColdWeatherExpired { get; set; }
        public Nullable<int> RemainHotWeather { get; set; }
        public int IsHotWeatherExpired { get; set; }
        public string ScheduleName { get; set; }
        public string Code { get; set; }
    }
}
