using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//conpile : 코드의 문법등을 분석해 기계어로 번역
//build : 코드로 변연된 것과 여러 잡다한 것들을 모아 실행가능한 파일로 만드는 것
//f5 는 디버깅시도 , ctrl f5는 디버깅없이 실행
//namespace - 성격이 비슷한 class struct interface 등을 그룹화한 것
//정적이 것은 field , 동적인 것은 method 

namespace ConsoleApp1
{
    class Program
    {
        //static 한정자 , 정적인 method 
        //void 반환값이 없다
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요");

            //vlaue 변수가 값을 담는 데이터 형식 타입은 struct 형
            //struct 언어가 구조화 된 데이터를 처리할 때 사용하는 구조체
            //reference 변수가 값대신 값이 있는 위치를 담는 데이터 형식, 타입은 class 형


            int a = 10;

            Console.WriteLine(a);
            Console.WriteLine("int형 max = {0} int형 min ={1} size = {2} byte", int.MaxValue, int.MinValue, sizeof(int));

            //실수의 변수 선언 값 할당 시 double 형태로 인식 , 실수형 접미사를 정확히 사용하여야 함
            int b = 1; int c = 2;

            Console.WriteLine("b+c = {0}", b + c);
            Console.WriteLine("b%c = {0}", b % c);

            //c#에서는 f % f 연산이 가능함
            float fa = 0.12345f;
            float fb = 0.25123f;
            Console.WriteLine("fa%fb = {0}", fa % fb);

            Console.WriteLine(b += c);
            Console.WriteLine(b += c);
            Console.WriteLine(b *= c);

            //f9 를 누르면 브레이크 포인트 발생 , 그부분까지 연산
            //f10 정지된 상태에서 누르면 다음라인까지 실행
            //f11 다음라인까지 실행,다른 참조된 라이브러리도 차례로 들어감

            //논리연산자

            Console.WriteLine("b>c = {0}", b > c);
            Console.WriteLine("b<c = {0}", b < c);
            Console.WriteLine("b!=c = {0}", b != c);
            Console.WriteLine("b=c", b == c);

            //이항논리연산자
            // 두개가 같거나 && 다르거나 ||
            //증감연산자

            Console.WriteLine("b= {0}", b);
            Console.WriteLine("b++ = {0}", b++);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("++b = {0}", ++b);

            //삼항연산자  - 가독성을 올리고 간단한 논리의 오류가 적어보일때 사용

            //if 문 a+b =c
            //switch 문 a+=b

            if (10 > b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("{0}'b'은 10보다 작은 값입니다", b);
            }

            switch (b)
            {
                case 10:
                    Console.WriteLine(b);
                    break;
                case 11:
                    Console.WriteLine(b);
                    break;
                default:
                    Console.WriteLine("12이상입니다");
                    break;

            }
            //while 문 계속 반복, 끝날 때 까지
            //무한루프를 조심 
            int num = 10;
            while (num > 0)
            {
                Console.WriteLine("num = {0}", num--);
                if (num == 5)
                    break;
            }

            //do while 문 무조건 한번 먼저 실행되고 반복함
            int num2 = 10;
            do
            {
                Console.WriteLine("num2 = {0}", num2--);
            }
            while (num2 > 5);

            //for 반복문
            //변수초기화 할때  이름을 i j k 등을 암묵적으로 사용

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                if (i == 5) break;
            }
            //다중 for문 2차원 배열 등을 구현할 때 사용

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                }
            }

            //배열 똑같은 타입의 변수를 순서대로 가지고 있는 타입의 덩어리
            //배열을 가지고 있을 때 사용할 수 있는 방법이 foreach 문
            //foreach문이 배열 데이터들을 처리할 때 for 나 while 보다 처리속도가 더 빠름
            int[] nArr = { 0, 2, 4, 7, 4, 5 };
            Console.WriteLine(nArr);

            int indexx = 0;
            foreach (int i in nArr)
            {
                Console.WriteLine("nArr[{0}]={1}", indexx++, i);
            }

            //break 실행을 중지할때
            //continue문 중지하지않고  다음 반복 계속 수행

            //goto 상관없이 원하는 위치로 점프하려할때, 가독성 떨어지고  코드 흐름을 끊게 할 수 있으니 주의







        }
    }
}

namespace ConsoleApp2
{
    class Program2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("반가워여");
        }
    }
}