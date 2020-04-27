using System;

namespace Test_Logic_NawaData_3
{
    class Nomor3
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Masukkan Jumlah Count Angka : ");
			string input = Console.ReadLine();
			int count = Convert.ToInt32(input);

			Console.WriteLine();

			int kk = 1;
			for (int i = 10; i < 100000; i++)
			{
				char[] charArray = Convert.ToString(i).ToCharArray();
				Array.Reverse(charArray);

				string result = new string(charArray);

				if (CekPrima(Convert.ToInt32(i)) && CekPrima(Convert.ToInt32(result)))
				{
					if (kk == count + 1)
					{
						break;
					}

					Console.Write(kk + ". ");
					Console.Write(i + " and ");
					Console.Write(Convert.ToInt32(result));
					Console.Write(" are match");
					kk++;

					Console.WriteLine();
				}
			}
		}

		static bool CekPrima(int bilangan)
		{
			bool status = true;
			if (bilangan == 0 || bilangan == 1 || bilangan == -1)
			{
				status = false;
			}
			else
			{
				for (int i = 2; i < bilangan; i++)
				{
					if (bilangan % i == 0)
					{
						status = false;
						break;
					}
				}
			}
			return status;
		}
	}
}
