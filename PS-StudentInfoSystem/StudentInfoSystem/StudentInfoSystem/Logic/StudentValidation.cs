using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class StudentValidation
    {
        public string errText { get; private set; }
        public static Student IsThereStudent(User usr)
        {
            return UserData.GetStudentDataByUser(usr.FacNumber);
        }
        private bool isTooShort(string s, int length)
        {

            if (s.Length < length)
            {
                return true;
            }
            return false;
            
        }
       public bool InsertStudentIfValid(Student s)
        {
         
            if (isTooShort(s.FirstName, 3))
            {
                errText = "Invalid FirstName";
                return false;
            }
            if (isTooShort(s.SecondName, 3))
            {
                errText = "Invalid SecondName";
                return false;
            }
            if (isTooShort(s.LastName, 3))
            {
                errText = "Invalid LastName";
                return false;
            }
            return UserData.InsertStudent(s);
        }

    }
}
