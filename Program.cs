class Program
{
    static void Main(string[] args)
    {
        // สร้าง User จาก การ input 
        User[] users = InputUsers();

        PrintUsersInformation(users);
    }

    static User[] InputUsers()
    {
        // ประกาศ Users โดยกำหนดให้มีทั้งหมด 8 คน
        User[] users = new User[1];

        // วนลูป เพื่อสร้าง User ทั้ง 8 คน
        for (int index = 0; index < users.Length; index++)
        {
            Console.WriteLine("********************");
            Console.Write("Input Name: ");
            string name = Console.ReadLine();

            Console.Write("Input Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Input Student ID: ");
            string studentID = Console.ReadLine();

            Console.Write("Input Score:");
            int score = ConvertStringToInt(Console.ReadLine());

            // สร้าง Grade จาก score
            Grade grade = new Grade(score);

            // สร้าง User จากข้อมูลที่ input
            User user = new User(name, surname, studentID, grade);

            // เปลี่ยนตำแหน่ง Ref user จาก ค่าว่างเปล่าไปที่ User ที่เราสร้างขึ้น
            users[index] = user;
            Console.WriteLine("********************");
            Console.WriteLine();
        }

        return users;
    }

    // เช็คว่า สามารถแปลงเป็น ตัวเลขได้หรือไม่
    static int ConvertStringToInt(string score)
    {
        if (int.TryParse(score, out int number))
        {
            return number;
        }

        throw new Exception("Please input decimal data.");
    }

    static void PrintUsersInformation(User[] users)
    {
        foreach (User user in users)
        {
            Console.WriteLine(user.PrintUserInformation());
        }
    }
}