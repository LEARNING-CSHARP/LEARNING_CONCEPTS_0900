namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			Human human = new Human();

			human.Gender = 2;
			human.Marriage = 11;
			human.FullName = "Ali Reza Alavi";

			if (human.Gender == 2)
			{
				System.Console.WriteLine("You are female!");
			}



















			Person person = new Person();

			person.Gender = Gender.Male;
			person.Marriage = Marriage.Married;
			person.FullName = "Ali Reza Alavi";

			if (person.Gender == Gender.Female)
			{
				System.Console.WriteLine("You are female!");
			}

			System.Console.WriteLine(person.Gender); // Male
			System.Console.WriteLine((int)person.Gender); // 10

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

			file.Attributes = FileAttributes.Hidden;

			file.Attributes =
				FileAttributes.Hidden | FileAttributes.System | FileAttributes.Archive;

			// Hidden:  1 -> 00000001 OR
			// System:  2 -> 00000010 OR
			// Archive: 4 -> 00000100
			//              ---------
			//               00000111 -> 7 = 1 + 2 + 4

			// اگر دقیقا ویژگی فایل مورد نظر سیستمی بود
			if (file.Attributes == FileAttributes.System)
			{
			}

			// Hidden:  1 -> 00000001
			// System:  2 -> 00000010
			// Archive: 4 -> 00000100
			//              ---------
			//               00000111 -> 7 = 1 + 2 + 4
			// System:  2 -> 00000010
			//               --------
			// System:  2 -> 00000010

			// اگر در بین ویژگی‌های فایل مورد نظر، ویژگی سیستمی وجود داشت
			if ((file.Attributes & FileAttributes.System) == FileAttributes.System)
			{
			}

			// اگر در بین ویژگی‌های فایل مورد نظر، ویژگی مخفی و نیز سیستمی وجود داشت
			if ((file.Attributes & (FileAttributes.Hidden | FileAttributes.System)) ==
				(FileAttributes.Hidden | FileAttributes.System))
			{
			}

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
