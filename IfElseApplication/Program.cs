namespace IfElseApplication
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Lutfen bir sayi giriniz: ");
			int sayi = Convert.ToInt32(Console.ReadLine());

			if (sayi > 10) // Girilen sayi 10'dan buyukse
			{
				Console.WriteLine("Girilen sayi 10'dan buyuktur.");
			}
			else if (sayi < 10) // Girilen sayi 10'dan kucukse
			{
				Console.WriteLine("Girilen sayi 10'dan kucuktur.");
			}
			else // Girilen sayi 10'a esitse
			{
				Console.WriteLine("Girilen sayi 10'a esittir.");
			}

			if (sayi % 2 == 0) // Girilen sayi ciftse
			{
				Console.WriteLine("Girilen sayi cifttir.");
			}
			else // Girilen sayi tekse
			{
				Console.WriteLine("Girilen sayi tektir.");
			}


		}
	}
}
			

			
		
	

