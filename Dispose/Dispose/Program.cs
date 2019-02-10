using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class Garbage : IDisposable
    {
        private bool isDispose = false;
        private string name;

        public Garbage(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}객체가 생성됨");
        }
        ~Garbage()
        {
            if(!isDispose)
            {
                Dispose();
            }
        }
        public void Dispose()
        {
            isDispose = true;
            Console.WriteLine($"{name}객체의 리소스 해제 OK...");
            GC.SuppressFinalize(this);  //소멸자 호출을 막는다.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garbage g1 = new Garbage("1번객체");
            Garbage g2 = new Garbage("2번객체");
            Garbage g3 = new Garbage("3번객체");
            Garbage g4 = new Garbage("4번객체");

            g1.Dispose();
            GC.SuppressFinalize(g2);
        }
    }
}
