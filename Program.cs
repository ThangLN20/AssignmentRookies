using System;
using System.Collections.Generic;

namespace Assignment
{
   
    class Program
    {
       
        

        static void Main(string[] args)
        {
             List<Member> listMember = new List<Member>();
             List<Member> whoIsMale = new List<Member>();
             List<string> listOfFullName = new List<string>();
             List<Member> whoIs1998 = new List<Member>();
             List<Member> whoIsGrt1998 = new List<Member>();
             List<Member> whoIsLet1998 = new List<Member>();
             List<Member> whoJoinClassBefore= new List<Member>();
             Member whoWasBornInHn;

             Member member = new Member("Le Ngoc","Thang", "male", new DateTime(2000,09,20), (0987698696),"Thanh Hoa",DateTime.Now,DateTime.Now );
             Member member1 = new Member("Le Ngoc","Nam", "male", new DateTime(1998,08,21), (0987698696),"Ha Nam", DateTime.Now,DateTime.Now);
             Member member2 = new Member("Le Thi","A", "female", new DateTime(2000,07,22), (0987698696),"Ha Noi",DateTime.Now,DateTime.Now );
             Member member3 = new Member("Le Thi","B", "female", new DateTime(2001,07,22), (0987698696),"Ha Noi",DateTime.Now,DateTime.Now );
             listMember.Add(member);
             listMember.Add(member1);
             listMember.Add(member2);
             listMember.Add(member3);


            // 1. Return a list of member who is Male 
            foreach (var item in whoIsMale )
            {
                Console.WriteLine("who are male is : " + item.LastName);
                
            }
            // 2. 
            Member oldMember = listMember[0];
            for (int i = 0; i < listMember.Count; i++)
            {
                listOfFullName.Add(listMember[i].FirstName + " " + listMember[i].LastName);
                string gender = listMember[i].Gender;
                int year = listMember[i].DateOfBirth.Year;
                 DateTime t = Convert.ToDateTime("03/22/2021");
                if ((listMember[i].startDate - t).Days < 0)
                {
                    whoJoinClassBefore.Add(listMember[i]);
                }
                 if (year == 1998)
                {
                    whoIs1998.Add(listMember[i]);
                }
                if (year > 1998)
                {
                    whoIsGrt1998.Add(listMember[i]);
                }
                if (year < 1998)
                {
                    whoIsLet1998.Add(listMember[i]);
                }
                if (gender == "male")
                {
                    whoIsMale.Add(listMember[i]);
                }
                if (listMember[i].DateOfBirth.Year < oldMember.DateOfBirth.Year)
                {
                    oldMember = listMember[i];
                }
            }
             Console.WriteLine("who are oldest is : " + oldMember.DateOfBirth.Year);
             //3. 
             foreach (var item in listOfFullName)
            {
                Console.WriteLine("full name of list : " + item);
            }
            //4. 
            foreach (var item in whoIsLet1998)
            {
                Console.WriteLine("who are less than 1998 : " + item.LastName);
            }
            foreach (var item in whoIsGrt1998)
            {
                Console.WriteLine("who are great than 1998 : " + item.LastName);
            }
            foreach (var item in whoIs1998)
            {
                Console.WriteLine("who are born 1998 : " + item.LastName);
            }
            //5.
            for (int i = 0; i < listMember.Count; i++)
            {
                if (listMember[i].BirthPlace == "ha noi")
                {
                    whoWasBornInHn = listMember[i];
                    Console.WriteLine(whoWasBornInHn.LastName);
                }
            }
            //6.
            foreach (var item in whoJoinClassBefore)
            {
                Console.WriteLine("who are join before 22/03/2021 is : " + item.LastName);
            }



        }
    }
}
