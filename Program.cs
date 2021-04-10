using System;

namespace Learn_CSharp
{ 

    public class BaseClass {

        public string name = "Indra Mahesa";

        public void Method() {
            System.Console.WriteLine("Ini Method Pada BaseClass");
        }

    }

    public class ChildClass : BaseClass {

        public void TampilName() {
            System.Console.WriteLine(name);
        }

    }

    public class Program {
        public static void Main() {
            ChildClass child = new ChildClass();
            child.TampilName();
        }
    }

}
