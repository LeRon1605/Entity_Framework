using System.Text;
namespace EF_Practice
{
    class Menu
    {
        public int choice { get; set;}
        public void showMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Đăng kí môn học cho sinh viên");
            Console.WriteLine("3. Thêm giáo viên");
            Console.WriteLine("4. Thêm lớp sinh hoạt");
            Console.WriteLine("5. Thêm môn học");
            Console.WriteLine("6. Thoát");
        }
        public int getChoice()
        {
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}