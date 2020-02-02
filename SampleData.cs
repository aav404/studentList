using System;
using System.Linq;
using TestWebApp.Models;

namespace TestWebApp
{

    public static class SampleData
    {
        public static void Initialize(StudentContext context)
        {
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student
                    {
                        Surname = "Pupin",
                        PhoneNumber = "89005553535",
                        Birthday = new DateTime(1998, 12, 19)
                    },
                    new Student
                    {
                        Surname = "Lupin",
                        PhoneNumber = "89278874119",
                        Birthday = new DateTime(1997, 12, 20)
                    },
                    new Student
                    {
                        Surname = "Bibin",
                        PhoneNumber = "89124413243",
                        Birthday = new DateTime(1999, 01, 30)
                    },
                     new Student
                     {
                         Surname = "Bobin",
                         PhoneNumber = "89768678566",
                         Birthday = new DateTime(2000, 06, 05)
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
