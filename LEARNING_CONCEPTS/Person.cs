namespace LEARNING_CONCEPTS
{
	//public class Person
	//{
	//	public int Gender;
	//	public byte Marriage;
	//	public string FullName;
	//}
































	public enum Genders : int // Note: int is defautl!
	{
		Male = 10,
		Female = 20
	}

	public enum Marriages : byte
	{
		Single, // 0
		Married, // 1
		Divorced // 2
	}

	public enum SomeEnum : int
	{
		X = 10,
		Y = 20,
		Z, // 21
		T, // 22
		M, // 23
		N // 24
	}

	public class Person
	{
		public string FullName;

		public Genders Gender;
		public Marriages Marriage;
	}
}
