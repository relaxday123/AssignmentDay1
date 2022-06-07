namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>{
                new Member{
                    FirstName = "Nguyen Van",
                    LastName = "A",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 11, 25),
                    PhoneNumber = "0782151236",
                    BirthPlace = "Hai Phong",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nguyen Thi",
                    LastName = "B",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2000, 1, 20),
                    PhoneNumber = "0124124241",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nguyen Thi",
                    LastName = "C",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1999, 8, 2),
                    PhoneNumber = "0487424412",
                    BirthPlace = "Thai Binh",
                    IsGraduated = true
                },
                new Member{
                    FirstName = "Nguyen Van",
                    LastName = "D",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 4, 6),
                    PhoneNumber = "0345751244",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
            };

            Console.WriteLine("Cau 1");

            int max = 0;

            foreach (var member in members)
            {
                if (member.Age > max)
                {
                    max = member.Age;
                }

                if (member.Gender != "Male")
                {
                    continue;
                }

                Console.WriteLine(member.Info);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Cau 2");

            foreach (var member in members)
            {
                if (member.Age == max)
                {
                    Console.WriteLine(member.Info);
                    break;
                }
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Cau 3");

            foreach (var member in members)
            {
                Console.WriteLine(member.fullName);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Cau 4");

            List<Member> age2000 = new List<Member>();

            List<Member> ageGreater2000 = new List<Member>();

            List<Member> ageLess2000 = new List<Member>();

            foreach (var member in members)
            {
                int typeAge = member.DateOfBirth.Year == 2000 ? 0 : (member.DateOfBirth.Year > 2000 ? 1 : -1);
                
                switch (typeAge)
                {
                    case 0:
                        age2000.Add(member);
                        break;
                    case 1:
                        ageGreater2000.Add(member);
                        break;
                    default:
                        ageLess2000.Add(member);
                        break;
                }
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Members have birth year is 2000");

            foreach (var member in age2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Members have birth year is greater than 2000");

            foreach (var member in ageGreater2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Members have birth year is less than 2000");

            foreach (var member in ageLess2000)
            {
                Console.WriteLine(member.Info);
            }


            Console.WriteLine("-------------------");

            Console.WriteLine("Cau 5");

            int flag = 0;

            while (true)
            {
                if (members[flag].BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(members[flag].Info);
                    break;
                }

                flag++;
            }
        }
    }
}