using System;

class Program
{
    static void Main()
    {
        // قراءة المدخلات
        string[] input = Console.ReadLine().Split(' ');
        int l = int.Parse(input[0]);
        int r = int.Parse(input[1]);
        int k = int.Parse(input[2]);

        // حساب عدد الأرقام التي تقبل القسمة على k
        int count = 0;
        for (int i = l; i <= r; i++)
        {
            if (i % k == 0)
            {
                count++;
            }
        }

        // طباعة النتيجة
        Console.WriteLine(count);
    }
}

