using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentInfoSystem.Data
{
    class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {    //whole information for the student
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) &&
                              (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
            {
                // return queryResult.ElementAt<User>(0).Role;
                return queryResult[0];
            }
            return null;
        }

        //Check if the user is free
        public static int IsUserFree(string username)
        {
            return UserData._IsUserCorrect(username);
        }
        private static int _IsUserCorrect(string username)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
                
                return queryResult.ElementAt<User>(0).Role;
            return -1;
        }

        //returns the information for a student with Faknum; else null;
        public static Student GetStudentDataByUser(string faknum)
        {
            StudentsDataClassesDataContext dc = new StudentsDataClassesDataContext();
            var queryResult = (from Students in dc.GetTable<Student>()
                               where (Students.FakNumber == faknum)
                               select Students).ToArray<Student>();
            if (queryResult.Count<Student>() > 0)
            {
                return queryResult[0];
            }

            return null;

        }
        public static bool InsertStudent(Student s)
        {
            StudentsDataClassesDataContext dc = new StudentsDataClassesDataContext();
            try
            {
                dc.AddNewStudent(s.FirstName, s.SecondName, s.LastName, s.Faculty,
                s.Specialty, s.OKS, s.StudentStatus,
                s.FakNumber, s.Course, s.Potok, s.Group);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool InsertUser(User u)
        {
            UserDataClassesDataContext uc = new UserDataClassesDataContext();
            try
            {
                uc.AddNewUser(u.Username, u.Password, u.FacNumber, u.Role);
                uc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        public static List<int> GetStudentGroups()
        {
            StudentsDataClassesDataContext dc = new StudentsDataClassesDataContext();
            var queryResult = (from Students in dc.GetTable<Student>()
                               select Students.Group).Distinct().ToList<int>();
            return queryResult;

        }


    }
}
