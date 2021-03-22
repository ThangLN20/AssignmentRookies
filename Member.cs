using System;
namespace Assignment
{
    class Member : Person
    {
       public DateTime startDate {get;set;}
       public DateTime endDate {get;set;}
       public Member(string firstName,string lastName,string gender, DateTime dateOfBirth,int phoneNumber,string birthPlace, DateTime startDate, DateTime endDate)
       {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Gender = gender;
        this.DateOfBirth= dateOfBirth;
        this.PhoneNumber= phoneNumber;
        this.BirthPlace= birthPlace;
        this.startDate= startDate;
        this.endDate = endDate;
       }
    
    }
     

}