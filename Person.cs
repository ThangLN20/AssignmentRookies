using System;
namespace Assignment
{
    public class Person
    {
       public string FirstName{get;set;}
       public string LastName{get;set;}
        public string Gender{get;set;}
        public DateTime DateOfBirth{get;set;}
        public int PhoneNumber{get;set;}
        public string BirthPlace{get;set;}
        public string Age{get;set;}
       

        public Person()
    {}
    public Person(string firstName,string lastName,string gender,DateTime dateOfBirth, int phoneNumber,string birthPlace,string age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Gender = gender;
        this.DateOfBirth= dateOfBirth;
        this.PhoneNumber= phoneNumber;
        this.BirthPlace= birthPlace;
        this.Age=age;

    }

    }
    
}