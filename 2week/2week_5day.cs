namespace RandomApp01
{
    internal class Program
    {   //국어, 영어, 수학 성적을 Rando을 사용하여 받고 평균만 출력해 보세요!
        //
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] score = new int[3];
            int total = 0;
            double avg = 0;
            for (int i = 0; i < 3; i++)
            {
                score[i] = random.Next(0, 101);
                Console.WriteLine(score[i]);
                total += score[i];
            }
            avg = (double)total / score.Length;
            Console.WriteLine(avg);
        }
    }
}
---------------------------------------------------------------------------
namespace RandomApp01
{//로또번호 구하기 2단계 - 중복불가 내가한거
    internal class Program
    {   
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] rotto = new int[6];
            int[] num = new int[6];
            int bonus;
            Console.Write($"로또번호: ");
            for(int i = 0; i < 6; i++)
            {
                rotto[i] = random.Next(1, 50);
                num[i] = rotto[i];
            }
            for(int i = 0;i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (rotto[i] == num[j] && i != j)
                    {
                        rotto[i] = random.Next(1, 50);
                        rotto[j] = random.Next(1, 50);
                        num[i] = rotto[i];
                        num[j] = rotto[j];
                        i = 0; j =0;
                        break;
                    }
                }
            
            }
          
            bonus = random.Next(1, 50);
            for (int i = 0; i < rotto.Length; i++)
            {
                if(bonus == rotto[i])
                {
                    bonus = random.Next(1, 50);
                    i = 0;
                }
            }
            for (int i = 0; i < rotto.Length; i++)
            {
                Console.Write($"{rotto[i]} ");
            }
            Console.Write($"\n보너스 번호: {bonus}");
        }
    }
}
---------------------------------------------------------------------
namespace RandomApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {//강사님이 한거
            int[] numbers = new int[7];
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                numbers[i] = random.Next(1, 46);
                //전수조사
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            int bonusNumber = numbers[6];
            int[] lottoNumbers = new int[6];
            Array.Copy(numbers, 0, lottoNumbers, 0, 6);

            Array.Sort(lottoNumbers);
            foreach (int i in lottoNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호 {bonusNumber}");

        }
    }
}
------------------------------------------------------------------------------
namespace LottoApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> lottoNumberList = new List<int>(); //리스트 사용

            while (lottoNumberList.Count < 7)
            {
                int number = random.Next(1, 46);
                //중복 체크
                if (!lottoNumberList.Contains(number))
                {
                    lottoNumberList.Add(number);
                }
            }
            //보너스 번호 뽑기 0번지 첫번째 요소를 보너스 번호로 하자.
            int bounusNumber = lottoNumberList[0];
            lottoNumberList.RemoveAt(0);
            //로또번호 6개만 오름차순 정령
            lottoNumberList.Sort();

            foreach (int i in lottoNumberList)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            Console.WriteLine($"보너스 번호 : {bounusNumber}");
        }
    }
}
-----------------------------------------------------------------------------
namespace LottoApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //HashSet은 중복을 허용하지 않음
            HashSet<int> lottoNumbers = new HashSet<int>(); //해쉬셋 사용

            while ( lottoNumbers.Count < 6 )
            {
                int number = random.Next(1, 46);
                lottoNumbers.Add(number);
            }// 로또번호 6개 만들기

            //보너스 번호
            int bonusNumber;
            do
            {
                bonusNumber = random.Next(1, 46);
            }while (lottoNumbers.Contains(bonusNumber));

            //출력
            //로또번호
            foreach (int number in lottoNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //보너스
            Console.WriteLine($"보너스 번호 : " + bonusNumber);
        }
    }
}
------------------------------------------------------------------------------
