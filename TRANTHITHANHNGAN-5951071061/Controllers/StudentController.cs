using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TRANTHITHANHNGAN_5951071061.Models;

namespace TRANTHITHANHNGAN_5951071061.Controllers
{
    public class StudentController : ApiController
    {
		
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInList = new List<StudentInfo>();
            
                var StudentInfo = new StudentInfo
                {
                    Hovaten = "Tran Thi Thanh Ngan",
                    Mssv = "5951071061",
                    Lop = "CNTT.K59"

                };
            
            StudentInList.Add(StudentInfo);
            return StudentInList;

        }
        
           

        }

        // GET: api/Student/5
        
    }

       