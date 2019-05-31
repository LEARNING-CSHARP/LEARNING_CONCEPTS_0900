﻿namespace LEARNING_CONCEPTS
{
	public class Human
	{
		public Human()
		{
		}

		public int Gender;
		public byte Marriage;

		public string FullName;
	}






















	//public enum Gender // Note: [int] is defautl!
	//{
	//	Male = 10,
	//	Female = 20
	//}

	//public enum Gender : int
	//{
	//	Male = 10,
	//	Female = 20
	//}

	public enum Gender : int
	{
		Male = 10,
		Female = 20,
	}

	//public enum Marriage : byte
	//{
	//	Single, // 0
	//	Married, // 1
	//	Divorced, // 2
	//}

	public enum Marriage : byte
	{
		Single = 0,
		Married = 1,
		Divorced = 2,
	}

	// New Standard:
	// Gender NOT Genders
	// Marriage NOT Marriages

	public enum SomeEnum : int
	{
		X = 10,
		Y, // 11
		Z = 20,
		T, // 21
		M, // 22
		//N = 20, // Compile OK, Runtime Error!
	}

	public class Person
	{
		public Person()
		{
		}

		public Gender Gender;
		public Marriage Marriage;

		public string FullName;
	}
}
