using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }
    }
}
