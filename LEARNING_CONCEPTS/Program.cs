namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			//Person person = new Person();

			//person.Gender = 10;
			//person.Marriage = 1;
			//person.FullName = "Ali Reza Alavi";

			//if (person.Gender == 20)
			//{
			//	System.Console.WriteLine("You are female!");
			//}

			Person person = new Person();

			person.Gender = Gender.Male;
			person.Marriage = Marriage.Married;
			person.FullName = "Ali Reza Alavi";

			if (person.Gender == Gender.Female)
			{
				System.Console.WriteLine("You are female!");
			}

			System.Console.WriteLine(person.Gender);
			System.Console.WriteLine((int)person.Gender);

			switch (person.Marriage)
			{
				case Marriage.Single:
				{
					break;
				}

				case Marriage.Married:
				{
					break;
				}

				case Marriage.Divorced:
				{
					break;
				}
			}

			File file = new File();

			file.Size = 1234;
			file.Name = "Somefile.txt";
			file.Attribute = FileAttribute.Hidden;
			file.Attribute = FileAttribute.Hidden | FileAttribute.System | FileAttribute.Archive;

			// Hidden:  1 -> 00000001
			// System:  2 -> 00000010
			// Archive: 4 -> 00000100
			//              ---------
			//               00000111 -> 7 = 1 + 2 + 4

			// اگر دقیقا ویژگی فایل مورد نظر مخفی بود
			if (file.Attribute == FileAttribute.Hidden)
			{
			}

			// Hidden:  1 -> 00000001
			// System:  2 -> 00000010
			// Archive: 4 -> 00000100
			//              ---------
			//               00000111 -> 7 = 1 + 2 + 4
			//               00000001
			//               --------
			//               00000001

			// اگر در بین ویژگی‌های فایل مورد نظر، ویژگی مخفی وجود داشت
			if ((file.Attribute & FileAttribute.Hidden) == FileAttribute.Hidden)
			{
			}

			// اگر در بین ویژگی‌های فایل مورد نظر، ویژگی مخفی و نیز سیستمی وجود داشت
			if ((file.Attribute & (FileAttribute.Hidden | FileAttribute.System)) == (FileAttribute.Hidden | FileAttribute.System))
			{
			}

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
