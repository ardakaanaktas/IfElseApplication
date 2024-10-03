namespace IfElseApplication
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Lutfen bir sayi giriniz: ");
			int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Girilen sayi 10'dan buyuktur.");
            }
			else if (sayi < 10)
			{
				Console.WriteLine("Girilen sayi 10'dan kucuktur.");
			}
			else
			{
				Console.WriteLine("Girilen sayi 10'a esittir.");
			}

			if (sayi % 2 == 0)
			{
				Console.WriteLine("Girilen sayi cifttir.");
			}
			else
			{
				Console.WriteLine("Girilen sayi tektir.");
			}
		}
	}
}
