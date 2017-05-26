using System;

namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			//Person oPerson = new Person();

			//oPerson.Gender = 2;
			//oPerson.Marriage = 20;
			//oPerson.FullName = "Ali Reza Alavi";

			//if (oPerson.Gender == 1)
			//{
			//	System.Console.WriteLine("You are female!");
			//}

			//Person oPerson = new Person();

			//oPerson.Gender = Genders.Male;
			//oPerson.Marriage = Marriages.Married;
			//oPerson.FullName = "Ali Reza Alavi";

			//if (oPerson.Gender == Genders.Female)
			//{
			//	System.Console.WriteLine("You are female!");
			//}

			//System.Console.WriteLine(oPerson.Gender);
			//System.Console.WriteLine((int)oPerson.Gender);

			//switch (oPerson.Marriage)
			//{
			//	case Marriages.Single:
			//	{
			//		break;
			//	}

			//	case Marriages.Married:
			//	{
			//		break;
			//	}

			//	case Marriages.Divorced:
			//	{
			//		break;
			//	}
			//}

			File oFile = new File();

			oFile.Size = 1234;
			oFile.Name = "Somefile.txt";
			oFile.Attribute = FileAttributes.Hidden;
			oFile.Attribute = FileAttributes.Hidden | FileAttributes.System | FileAttributes.Archive;

			// Hidden: 1  -> 00000001
			// System: 2  -> 00000010
			// Archive: 4 -> 00000100
			//              ---------
			//               00000111 -> 7

			// اگر دقیقا ویژگی فایل مورد نظر مخفی بود
			if (oFile.Attribute == FileAttributes.Hidden)
			{
			}

			// Hidden: 1  -> 00000001
			// System: 2  -> 00000010
			// Archive: 4 -> 00000100
			//              ---------
			//               00000111 -> 7
			//               00000001
			//               --------
			//               00000001

			// اگر در بین ویژگی‌های فایل مورد نظر، ویژگی مخفی وجود داشت
			if ((oFile.Attribute & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
			}

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
