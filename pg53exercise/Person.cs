using System;
namespace pg53exercise
{
    public class Person
    {
        public string FirstName { get;set;  }
        public string LastName { get; set; }
        public int Id { get;set;}


        public static bool operator== (Person person, Person person2)
        {
            bool status = true;
            return status;
        }
        public static bool operator!= (Person person, Person person2)
        {
            bool status = false;
            return status;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return Id.Equals(obj);
        }
	}
}
