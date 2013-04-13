using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student:ICloneable,IComparable<Student>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        Faculty faculty = new Faculty();
        Specialty specialty = new Specialty();
        University university = new University();
        //OVERRIDES
        
        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            else
            {
                Student secondStudent = obj as Student;
                if (this.FirstName == secondStudent.FirstName && this.LastName == secondStudent.LastName && this.SSN == secondStudent.SSN)
                {
                    return true;
                }
            }
            return false;
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.Append(this.FirstName + " " + this.SecondName + " " + this.LastName + "\n");
            sb.Append("Student Number: " + this.SSN + "\n");
            sb.Append("Studies "+this.specialty);
            sb.Append(" at "+this.faculty+" in "+this.university+"\n");

            return sb.ToString();
        }
        
        public static bool operator ==(Student firstStudent,Student secondStudent)
        {
            if (firstStudent.FirstName==secondStudent.FirstName&&firstStudent.LastName==secondStudent.LastName&&firstStudent.SSN==secondStudent.SSN)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Student firstStudent,Student secondStudent)
        {
            if (firstStudent.FirstName == secondStudent.FirstName && firstStudent.LastName == secondStudent.LastName && firstStudent.SSN == secondStudent.SSN)
            {
                return false;
            }
            return true;
        }
        public object Clone()
        {
            Student otherStudent = new Student();
            otherStudent.FirstName = this.FirstName;
            otherStudent.SecondName = this.SecondName;
            otherStudent.LastName = this.LastName;
            otherStudent.SSN = this.SSN;
            otherStudent.Address = this.Address;
            otherStudent.Email = this.Email;
            otherStudent.MobilePhone = this.MobilePhone;
            otherStudent.Course = this.Course;
            otherStudent.specialty = this.specialty;
            otherStudent.faculty = this.faculty;
            otherStudent.university = this.university;
            return otherStudent;
        }
        public int CompareTo(Student student)
        {
            if (this.LastName != student.LastName)
            {
                return (String.Compare(this.LastName, student.LastName));
            }
            if (this.FirstName != student.FirstName)
            {
                return (String.Compare(this.FirstName, student.FirstName));
            }
            if (this.SSN != student.SSN)
            {
                return (String.Compare(this.FirstName, student.FirstName));
            }
            return 0;
            
        }
    }
}
