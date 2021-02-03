using System;

namespace Abstractclass
{

    public abstract class Marks
    {

        
        public abstract void  getPercentage();

    }

    public class A : Marks
    {
        int sub1;
        int sub2;
        int sub3;
        public A(int sub1,int sub2,int sub3)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;

        }
        public override void getPercentage()
        {
            int sum = sub1 + sub2 + sub3;
            int per = sum / 3;
            Console.WriteLine("The percentage of marks for A is :{0}",per);
        }
    }
    public class B : Marks
    {
        int sub1;
        int sub2;
        int sub3;
        int sub4;
     public B(int sub1, int sub2, int sub3,int sub4)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.sub4 = sub4;

        }

        public override void getPercentage()
        {
            int sum = sub1 + sub2 + sub3+sub4;
            int per = sum / 4;
            Console.WriteLine("The percentage of marks for B is :{0}", per);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks ]of subject 1");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks ]of subject 2");
            int sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks ]of subject 3");
            int sub3 = int.Parse(Console.ReadLine());

            A a = new A(sub1, sub2, sub3);
            a.getPercentage();

            Console.WriteLine("Enter marks ]of subject 1");
            int suba = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks ]of subject 2");
            int subb = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks ]of subject 3");
            int subc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks ]of subject 4");
            int subd = int.Parse(Console.ReadLine());
            B b = new B(suba, subb, subc, subd);
            b.getPercentage();
        }
    }
}
