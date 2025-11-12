//" Write a simple example where a `Person` class *has a* `Job` (composition) instead of a `Programmer` class *being a* `Person` (inheritance)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Job
    {
        public string Title { get; set;}
        public string Company { get; set; }
        public Job(string Title,string Company)
        {
            this.Title = Title;
            this.Company = Company;
        }
        public void Status()
        {
            Console.WriteLine($"Working as {Title} in {Company}");
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Job Job { get; set; }//Composition
        public Person(string Name,Job Job)
        {
            this.Name = Name;
            this.Job = Job;
        }
        public void Introduce()
        {
            if (Job != null)
            {
                Console.WriteLine($"My Name is {Name}");
                Job.Status();
            }
            else
            {
                Console.WriteLine("Looking for a Job");
            }
        }
        static void Main(string[] args)
        {
            Job jb = new Job("Engineer", "Deloitte");
            Person pr = new Person("Sumit", jb);
            pr.Introduce();
        }
    }
}
