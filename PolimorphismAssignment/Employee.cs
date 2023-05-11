using System;
using System.Collections.Generic;
using System.Text;

namespace IQuittable
{
    class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("Employee has quit the company.");
        }

    }
}
