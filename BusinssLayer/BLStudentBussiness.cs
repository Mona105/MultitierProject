using System;
using System.Collections.Generic;
using CommonLayer.Models;
using DataLayer;

namespace BusinssLayer
{
    public class BLStudentBussiness
    {
        private StudentDataAccessDb studentData;
        public BLStudentBussiness()
            {
            studentData = new StudentDataAccessDb();
        }
        public List<Students> GetStudents()
        {
            return studentData.GetStudents();
        }
    }
}
