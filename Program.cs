using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EF_Practice
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Menu menu = new Menu();
            do
            {
                menu.showMenu();
                menu.getChoice();
                switch (menu.choice)
                {
                    case 1:
                        {
                            Student student = new Student();
                            await student.input();
                            await DBService.Add(student);
                        }
                        break;
                        case 4:
                            {
                                Class classroom = new Class();
                                classroom.input();
                                await DBService.Add(classroom);
                            }
                            break;
                }
            } while (menu.choice != 6);
            // await DBService.deleteDB();
            // await DBService.createDB();
        }
    }
}