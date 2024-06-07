using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React_Asp_Crud.Models;

namespace React_Asp_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext studentDb;

        public StudentController(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }

        [HttpGet]
        [Route("GetStudent")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await studentDb.Students.ToListAsync();
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<Student> addStudent(Student stu)
        {
            studentDb.Students.Add(stu);
            await studentDb.SaveChangesAsync();
            return stu;
            
        }

        [HttpPatch]
        [Route("UpdateStudent/{id}")]
        public async Task<Student> UpdateStudent(Student stu)
        {
            studentDb.Entry(stu).State = EntityState.Modified;
            await studentDb.SaveChangesAsync();
            return stu;
        }

        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public bool DeleteStudent(int id)
        {
            var studen = studentDb.Students.Find(id);
            if(studen != null)
            {
                try
                {
                    studentDb.Entry(studen).State = EntityState.Deleted;
                    studentDb.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

    }
}
