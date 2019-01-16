using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (UserContext database = new UserContext())
            {
                Doctor firstDoctor = new Doctor { Id = 1, Name = "Sanya", FirstName = "Sotkin", MiddleName = "Olegovich", Age = 35, Specialization = "Cardiodoc" };
                Doctor secondDoctor = new Doctor { Id = 2, Name = "Nikita", FirstName = "Michailov", MiddleName = "Andreevich", Age = 30, Specialization = "Eyedoc" };
                Doctor thirdDoctor = new Doctor { Id = 3, Name = "Niko", FirstName = "Bellic", MiddleName = "Tarasovich", Age = 40, Specialization = "Theethdoc" };

                database.doctors.Add(firstDoctor);
                database.doctors.Add(secondDoctor);
                database.doctors.Add(thirdDoctor);
                database.SaveChanges();


            }
        }
    }
}
