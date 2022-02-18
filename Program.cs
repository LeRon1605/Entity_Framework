using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace EF_Practice
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // await DBService.deleteDB();
            // await DBService.createDB();
            Student student = new Student
            {
                name = "Tran Duy Quang",
                gender = "Male",
                address = "Thua Thien Hue",
                phoneNumber = "0905857763",
                email = "quangtran@gmail.com"
            };
            Subject subject = new Subject 
            {
                name = "Data Structure",
                credit = 3,
                startDate = new DateTime(2021, 1, 3),
                endDate = new DateTime(2021, 4, 11)
            };
            // await getListStudentsOfSubject(1);
            // await DBService.Add(student);
            // await StudentService.registerSubject(2, 1);
            await SubjectService.getListStudentsOfSubject(1);
        }
    }
}