namespace Assignment_OOP_2
{
    #region Struct Q1
   //internal struct Person
   //{
   //    public string Name;
   //    public int Age;
   //
   //    public Person(string name, int age)
   //    {
   //        Name = name;
   //        Age = age;
   //    }
   //}
    #endregion

    #region Struct Q2
    internal struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Person[] people = new Person[3];
            //people[0] = new Person("Hassan", 20);
            //people[1] = new Person("Mohamed", 24);
            //people[2] = new Person("Ahmed", 16);
            //Console.WriteLine("Person Details : ");
            //
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name : {person.Name}, Age: {person.Age}");
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter Coordinates For Point 1 : ");
            //Console.WriteLine("X1 : ");
            //double X1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Y1 : ");
            //double Y1 = Convert.ToDouble(Console.ReadLine());   
            //Point P1 = new Point(X1, Y1);
            //
            //Console.WriteLine("Enter Coordinates For Point 2 : ");
            //Console.WriteLine("X2 : ");
            //double X2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Y2 : ");
            //double Y2 = Convert.ToDouble(Console.ReadLine());
            //Point P2 = new Point(X2, Y2);
            //
            //double Distance = Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));
            //Console.WriteLine($"The Distance Between The Two Points  = {Distance}");
            #endregion
        }
    }
}
