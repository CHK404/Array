using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_03_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //#1. 배열 (Array)
            //같은 자료형 변수 여러개를 하나의 배열로 처리
            //ㄴ 한번에 여러 값을 저장할 수 있음
            //int num1, num2, num3, num4, num5, num6, num7, num8.. 번거롭다

            int[] nums = new int[8]; //정수형 8개를 저장할 수 있는 배열

            //구조
            //배열의 이름: nums
            //배열의 자료형: int[] --> 정수형 배열
            //배열 선언 및 메모리 공간 확보: nums = new int[8]
            //ㄴ 8개 짜리 공가능ㄹ 만듬
            //배열의 요소(아이템): 배열 안에 있는 데이터 하나하나
            //배열의 위치(인덱스): 0부터 시작 - zero based numbering
            //배열의 길이(크기): 요소의 개수와 동일

            //입력되는 데이터의 크기를 알 수 없을 때, 배열로 처리
            int inputCount = 10;
            int[] inputData = new int[inputCount];
            //[20,0,0,0,0,0,0,0,0,0]
            //배열의 각 요소에 접근, Index는 0 부터 시작
            inputData[0] = 20;
            int oneOfData = inputData[0]; //20

            //배열 할당 및 초기화
            int[] array1 = new int[5];
            int[] array2 = { 1, 2, 3, 4, 5, 6 };

            //2차원 배열(행과 열로 구성)
            //ㄴ 행: 가로줄, 열: 세로줄
            //ㄴ 배열 안에 배열이 들어갈 수 있음 (n차 중첩 가능)
            //[,] -> 배열의 모양을 미리 정하는 표시
            //[] -> 하나(1차원 배열), [,] -> 2개(2차원 배열)
            //{} -> 실제 값 넣기
            int[,] multiArray1 = new int[2, 3];
            int[,] multiArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            string[,] korean = new string[,]
            {
                { "가", "나", "다" },
                { "라", "마", "바" },
                { "사", "아", "자" },
            };
            textBox1.Text = korean[0, 0]; //가
            textBox1.Text = korean[0, 2]; //다
            textBox1.Text = korean[1, 1]; //마

            //Ex1) 가자 글씨 출력해보기
            textBox1.Text = korean[0, 0] + korean[2, 2];

            //EX2) 3차원 배열에서 숫자 8 출력
            int[,,] nums2 = new int[,,]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };
            textBox1.Text = nums2[1, 0, 1].ToString();

            //jagged array (가변 배열)
            //ㄴ 들쭉날쭉한 배열
            //[][] 중첩된 대괄호 사용
            //첫 번째 []: 바깥쪽 배열
            //두 번째 []: 안쪽 배열

            int[][] jaggedArray = new int[6][];
            //행은 6으로 고정, 열의 길이는 자유
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 }; //첫 번째 줄: 4개
            jaggedArray[1] = new int[3] { 1, 2, 3 }; //두 번째 줄: 3개

            //jagged array 실습
            string[][] classArray = new string[3][];
            classArray[0] = new string[2] { "Ethan", "Sophia" };
            classArray[1] = new string[3] { "Liam", "Olivia", "Mason" };
            classArray[2] = new string[1] { "Ava" };

            textBox1.Text = "1반 학생 목록\r\n" + classArray[0][0] + "\r\n" + classArray[0][1] + "\r\n" + "2반 학생 목록\r\n" + classArray[1][0] + "\r\n" + classArray[1][1] + "\r\n" + classArray[1][2] + "\r\n" + "3반 학생 목록\r\n" + classArray[2][0] + "\r\n";

            //실습) 문자열 및 배열
            string[] exArray= new string[10];
            string KS = "동해 물과 백두산이";
            exArray[0] = KS.IndexOf("백두산").ToString();
            string To = "토요일에 먹는 토마토";
            exArray[1] = To.LastIndexOf("토").ToString();
            string expel = "질서 있는 퇴장";
            exArray[2] = expel.Contains("퇴").ToString();
            string shadow = "그 사람의 그림자는 그랬다.";
            exArray[3] = shadow.Replace("그", "이");
            string sG = "삼성갤럭시";
            exArray[4] = sG.Insert(2, "애플");
            string hung = "오늘은 왠지 더 배고프다";
            exArray[5] = hung.Remove(6, 2);
            string info = "이름, 나이, 전화번호";
            //Trim() = 앞 뒤 공백 제거
            exArray[6] = info.Split(',')[0].Trim();
            exArray[7] = info.Split(',')[1].Trim();
            exArray[8] = info.Split(',')[2].Trim();
            string hK = "우리 나라 만세";
            exArray[9] = hK.Substring(3, 2);
            
            textBox1.Text = exArray[0] + "\r\n" + exArray[1] + "\r\n" + exArray[2] + "\r\n" + exArray[3] + "\r\n" +
                exArray[4] + "\r\n" + exArray[5] + "\r\n" + exArray[6] + "\r\n" + exArray[7] + "\r\n" +
                exArray[8] + "\r\n" + exArray[9] + "\r\n";

            //# 2.문자열 내장 메서드
            //ㄴ string 타입 문자열이 기본적으로 가지고 있는 기능

            //문자열도 string 타입이기 때문에
            //.을 찍고 다양한 기능 사용 가능
            //ex1) 문자열 자체에 .찍어서 기능 사용
            string[] a = "1 2 3".Split(' ');
            //ex2) 
            string codingon = "codingon";
            codingon.Replace("on", "off");
            //ex3)
            string q = "string 5";
            string[] parsed = q.Split(' '); // [string, 5]
            int count = int.Parse(parsed[1]);

            //#3-1. 함수 실행(사용)
            int num = 200;
            int result = Add(100, num);

            textBox1.Text = result.ToString();
            Nothing();

            //실습. 함수
            int[] Div(int x, int y)
            {
                int[] divide = new int[2];
                divide[0] = x / y;
                divide[1] = x % y;
                return divide;
            }
            textBox1.Text = $"{Div(13, 2)[0]}\r\n{Div(13, 2)[1]}\r\n";

        }
        int[] Div(int x, int y)
        {
            int[] divide = new int[2];
            divide[0] = x / y;
            divide[1] = x % y;
            return divide;
        }
        //#3. 함수
        //- 특정 작업을 수행하기 위해 독립적으로 설계된 코드 집합

        //구조
        //- int(자료형): 이 함수가 돌려줄 값(return 값)의 타입
        //- Add: 함수명
        //- x, y: parameter
        //ㄴ 함수 선언 시 함수가 받아야 하는 입력값
        //ㄴ 함수에 전달되는 외부 데이터
        //- {} Scope: 코드 실행 범위(유효 범위)

        //용어 정리
        //- 함수 정의(선언): 함수를 생성
        //- 함수 호출: 함수를 사용

        //return (반환값)
        //함수 내부 코드의 최종 반환 값
        //- 함수 본문에서 최종 결과를 저장하고 돌려주는 키워드
        //return 키워드를 만나면 함수 실행 중단

        //함수 선언
        //#1. return 값이 있는 함수
        int Add(int x, int y)
        {
            return x + y;
        }

        //#2. return 값이 없는 함수
        //void
        //- 반환값이 없을 때 사용하는 키워드

        void Nothing()
        {
            textBox1.Text += "Nothing";
        }

    }
}
