using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritece
{
    public abstract class Dog
    {
        public string name { get; set; }
        public abstract void jitda();
        //{
        //    Console.WriteLine(name + "가 짖다.");
        //}
    }
    public class Pudle:Dog
    {
        public override void jitda()
        {
            Console.WriteLine(name + " 푸들푸들~");
        }
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");
        }
    }
    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(name + " 진도진도~");
        }
        public void run()
        {
            Console.WriteLine(name + "가 달린다.");
        }
    }
    

    class DogManager
    {
        static void Main()
        {
            //Pudle p = new Pudle();
            object p = new Pudle();
            ((Dog)p).name = "푸들이";
            ((Dog)p).jitda();
            ((Pudle)p).work();

            //Jindo j = new Jindo();
            Dog j = new Jindo();
            j.name = "진도이";
            j.jitda();
            ((Jindo)j).run();
        }
    }
}
