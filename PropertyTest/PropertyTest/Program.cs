using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    //모든 클래스의 최상위 부모는 Object
    class Emp : Object
    {
       // private int empno;    //자동구현 속성 사용시 필요 없음
        /*
        //인스턴스 변수에 직접 접근보다는 변경 함수를 생성
        public void SetEmpno(int Empno)
        {
            this.empno = Empno;
        }
        public int GetEmpno()
        {
            return this.empno;
        }
        */
        //일반 속성
        public int Empno
        {
            get;    //자동 구현 속성
            /*
            {
                return this.empno;
            }
            */
            set;
            /*
            {
                this.empno = value;
            }
            */
        }

        public override string ToString()   //Object에 있어서 오버라이딩
        {
            return $"사원: {Empno}";
        }
    }

    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            //e.empno = 999;
            //e.SetEmpno(999);
            //Console.WriteLine(e.GetEmpno());
            e.Empno = 999;
            Console.WriteLine(e.Empno);
            Console.WriteLine(e);
            Console.WriteLine(e.ToString());
        }
    }
}
