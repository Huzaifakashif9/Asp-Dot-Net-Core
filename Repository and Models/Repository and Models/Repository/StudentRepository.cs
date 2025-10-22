using Repository_and_Models.Models;

namespace Repository_and_Models.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getallstudents()
    {
        return datasource();
    }
    public StudentModel getstudentbyid(int id)
    { 
        return datasource().Where(s => s.stdid == id).FirstOrDefault(); 

    }
    private List<StudentModel> datasource()
    {
            return new List<StudentModel> {
        new StudentModel{stdid=1,stdname="Alice",age=20},
        new StudentModel{stdid=2,stdname="Bob",age=22},
        new StudentModel{stdid=3,stdname="Charlie",age=23}
        };
    }
}
}


