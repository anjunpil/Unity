using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class hero
    {
        public string sName;
        public int nHP;
        public int nMP;
        public int nPower;
        
        public void Attack(string target)
        {
            Console.WriteLine("{0}에 대미지 {1}만큼 주었습니다",target,nPower);
        }
    }
    
    class testclass
    {
        private string sName;
        public testclass(string name)
        {
            sName = name;
            Console.WriteLine(sName + "생성");
        }
        ~testclass(){
            Console.WriteLine(sName + "소멸");
        }
    }

    class test
    {
        public int nNum1 = 100;
        public int nNum2;

        string sName = "객체";

        public test()
        {
            Console.WriteLine("test() 실행");
        }
        //생성자 오버로딩
        public test(string name)
        {
            sName = name;
            Console.WriteLine(name, "생성");
        }
        //this 사용하여 자기 인스턴스에 접근
        public test(int nNum1, int nNum2)
        {
            this.nNum1 = nNum1;
            this.nNum2 = nNum2;
        }
        ~test()
        {
            Console.WriteLine(sName, "소멸");
        }
        public void show()
        {
            Console.WriteLine("{0},{1},{2}",nNum1, nNum2, sName);
        }
        //새로운 인스턴스를 생성해 새 클론을 만듬
        public test GetClone()
        {
            test newinstance = new test("클론객체");
            newinstance.nNum1 = this.nNum1;
            newinstance.nNum2 = this.nNum2;

            return newinstance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //객체를 새로 생성할 때 마다 new를 사용하면 됨
            hero newHero = new hero();
            newHero.nHP = 100;
            newHero.nMP = 50;
            newHero.nPower = 30;
            newHero.sName = "pill";

            Console.WriteLine("이름= {3} 체력 = {0} 마나 = {1} 파워 ={2}" ,newHero.nHP, newHero.nMP,newHero.nPower,newHero.sName);

            newHero.Attack("허수아비");

            testclass Aclass = new testclass("a");
            testclass Bclass = new testclass("b");
            testclass Cclass = new testclass("c");

            //소멸은 가장 나중것 부터 소멸됨 , 가비지 콜렉터각 실행된 결과
            //생산성과 안정성을 위에 가장 나중것 부터 소멸
            //되도록이면 소멸자 사용을 안하는 것을 권장

            test TestA = new test("A 객체");
            TestA.show();
            test TestB = new test(1, 2);
            TestB.show();
        }

        //생성자의 이름 클래스와 동일 , 매개변수를 받을 수 있음 ,특정 반환형식을 사용할 수 없음
        //소멸자는 앞에 ~를 붙여 사용
    }
}
