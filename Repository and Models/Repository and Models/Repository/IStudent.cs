using Repository_and_Models.Models;

namespace Repository_and_Models.Repository
{
    public interface IStudent
    {
        List<StudentModel> getallstudents();
        StudentModel getstudentbyid(int id);
    }
}
