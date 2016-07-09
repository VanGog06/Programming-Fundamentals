/*
At the Software University we often organize programming courses for beginners in different towns. We usually run a registration form and after the registration finishes, we distribute the students into study groups. Groups have different sizes in each town.
You are given a report holding the registrations for each town and the lab capacity (seats count) for each town. It comes in the following format:
•	Town name => X seats (where X is the capacity of the training lab in this town).
o	Student name | student email | registration date (in format day-month-year). The month name is given as 3 letters in English, e.g. “May”, “Aug” or “Nov”.
o	The next student come after the first, etc.
•	Then the next town and its students come, etc.
•	The input ends by a line holding “End”.

The input comes in the following structure:
Town1 => X seats
Student1 Name | student1_email@somewhere.com | day-month-year
Student2 Name | student2_email@somewhere.com | day-month-year
Student3 Name | student3_email@somewhere.com | day-month-year
…
Town2 => X seats
Student1 Name | student1_email@somewhere.com | day-month-year
Student2 Name | student2_email@somewhere.com | day-month-year
…
End

Your task is to create and print the study groups for each town as follows:
•	For each town create and print one or several study groups (depends of the number or registered students and the capacity of the lab in this town).
•	For each town order the students by registration date (ascending), then by name (ascending) then by email (ascending), then fill them into groups. If the students are less or equal to the lab capacity, create only one group. When the students are more than the lab capacity, distribute them in multiple groups.
•	Print all groups ordered by town (ascending) in the following format:
o	Created G groups and T towns:
o	Town1 => email1, email2, …
o	Town1 => email1, email2, …
o	…
o	Town2 => email1, email2, …
o	…

Examples
Input
Plovdiv => 5 seats
Ani Kirilova   |ani88@abv.bg             |27-May-2016
Todor Nikolov  | tod92@mente.org         | 28-May-2016
Kiril Stoyanov |  kirtak@gmail.com       | 27-May-2016
Stefka Petrova |   st96@abv.bg           | 26-May-2016
Ani Kirilova   |     ani.k@yahoo.co.uk   | 27-May-2016
Ivan Ivanov    |  ivan.i.ivanov@gmail.com| 27-May-2016
Veliko Tarnovo => 3 seats
Petya Stoyanova | stoyanova_p@abv.bg    | 27-May-2016
Stoyan Kirilov  | 100yan@gmail.com      | 24-May-2016
Didi Miteva     | miteva_d@yahoo.co.uk  | 28-May-2016
Kiril Nikolov   | kiro@kiro.net         | 25-May-2016
Ivan Stefanov   | ivan.stef86@gmail.com | 27-May-2016
Maria Kirova    | maria.k@abv.bg        | 26-May-2016
Varna => 2 seats
Ivan Ivanov      | ivan.ivanov96@gmail.com| 29-May-2016
Stoyan Petrov    | sto.sto.sto@gmail.com  | 27-May-2016
Ivan Ivanov      | vankata@mail.bg        | 1-Jun-2016
Kiril Anev       | anev_k@yahoo.co.uk     | 27-May-2016
Ivan Ivanov      | vanyo98@abv.bg         | 29-May-2016
Petya Vladimirova|pete98@abv.bg           | 20-May-2016
Ivan Ivanov      | ivan.94.ivan@gmail.com | 29-May-2016
End

Output
Created 8 groups in 3 towns:
Plovdiv => st96@abv.bg, ani.k@yahoo.co.uk, ani88@abv.bg, ivan.i.ivanov@gmail.com, kirtak@gmail.com
Plovdiv => tod92@mente.org
Varna => pete98@abv.bg, anev_k@yahoo.co.uk
Varna => sto.sto.sto@gmail.com, ivan.94.ivan@gmail.com
Varna => ivan.ivanov96@gmail.com, vanyo98@abv.bg
Varna => vankata@mail.bg
Veliko Tarnovo => 100yan@gmail.com, kiro@kiro.net, maria.k@abv.bg
Veliko Tarnovo => ivan.stef86@gmail.com, stoyanova_p@abv.bg, miteva_d@yahoo.co.uk

Comments
Plovdiv (group 1 – 5/5 students)
Stefka Petrova | st96@abv.bg | 26-May-2016
Ani Kirilova | ani.k@yahoo.co.uk | 27-May-2016
Ani Kirilova | ani88@abv.bg | 27-May-2016
Ivan Ivanov | ivan.i.ivanov@gmail.com | 27-May-2016
Kiril Stoyanov | kirtak@gmail.com | 27-May-2016
Plovdiv (group 2 – 1/5 students)
Todor Nikolov | tod92@mente.org | 28-May-2016
Varna (group 1 – 2/2 students)
Petya Vladimirova | pete98@abv.bg | 20-May-2016
Kiril Anev | anev_k@yahoo.co.uk | 27-May-2016
Varna (group 2 – 2/2 students)
Stoyan Petrov | sto.sto.sto@gmail.com | 27-May-2016
Ivan Ivanov | ivan.94.ivan@gmail.com | 29-May-2016
Varna (group 3 – 2/2 students)
Ivan Ivanov | ivan.ivanov96@gmail.com | 29-May-2016
Ivan Ivanov | vanyo98@abv.bg | 29-May-2016
Varna (group 4 – 1/2 students)
Ivan Ivanov | vankata@mail.bg | 1-Jun-2016
Veliko Tarnovo (group 1 – 3/3 students)
Stoyan Kirilov | 100yan@gmail.com | 24-May-2016
Kiril Nikolov | kiro@kiro.net | 25-May-2016
Maria Kirova | maria.k@abv.bg | 26-May-2016
Veliko Tarnovo (group 2 – 3/3 students)
Ivan Stefanov | ivan.stef86@gmail.com | 27-May-2016
Petya Stoyanova | stoyanova_p@abv.bg | 27-May-2016
Didi Miteva | miteva_d@yahoo.co.uk | 28-May-2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;


namespace _07.StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();

            List<Group> groups = new List<Group>();

            int townCounter = 0;

            Town town = new Town();
            Group group = new Group();

            while (firstInput != "End")
            {
                string[] firstInputArgs = Regex.Split(firstInput, " => ");

                string townName = firstInputArgs[0];
                townCounter++;
                string seats = firstInputArgs[1];
                int seatsCounter = int.Parse(string.Join("", seats.Split(' ').Take(1)));

                firstInput = Console.ReadLine();

                List<Student> allStudentsInTown = new List<Student>();

                while (!firstInput.Contains("=>"))
                {
                    if (firstInput == "End")
                    {
                        break;
                    }

                    string[] currentStudent = firstInput.Split('|').ToArray();

                    string name = currentStudent[0].Trim();
                    string email = currentStudent[1].Trim();
                    DateTime registrationDate = DateTime.ParseExact(currentStudent[2].Trim(), "d-MMM-yyyy", CultureInfo.InstalledUICulture);

                    Student student = new Student() { Name = name, Email = email, RegistrationDate = registrationDate };
                    allStudentsInTown.Add(student);

                    firstInput = Console.ReadLine();
                }

                town.Name = townName;
                town.SeatsCount = seatsCounter;

                allStudentsInTown = allStudentsInTown.OrderBy(e => e.RegistrationDate).ThenBy(e => e.Name).ThenBy(e => e.Email).ToList();

                for (int i = 0; i < allStudentsInTown.Count(); i++)
                {
                    town.Students.Add(allStudentsInTown[i]);

                    if ((town.Students.Count() == seatsCounter) || (i == allStudentsInTown.Count() - 1))
                    {
                        group.Town = town;
                        group.Students = town.Students;
                        groups.Add(group);

                        town = new Town();
                        group = new Group();

                        town.Name = townName;
                        town.SeatsCount = seatsCounter;
                    }
                }
            }

            Console.WriteLine("Created {0} groups in {1} towns: ", groups.Count(), townCounter);

            foreach (var singleTown in groups.Select(e => e.Town).OrderBy(e => e.Name))
            {
                Console.Write(singleTown.Name + " => ");

                string s = string.Empty;

                foreach (var singleStudent in singleTown.Students)
                {
                    s += singleStudent.Email + ", ";
                }

                Console.WriteLine(s.Substring(0, s.Length - 2));
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }

        public class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }

            public Town()
            {
                this.Students = new List<Student>();
            }

        }

        public class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }

            public Group()
            {
                this.Students = new List<Student>();
            }
        }
    }
}
