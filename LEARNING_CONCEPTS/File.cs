namespace LEARNING_CONCEPTS
{
	//public enum Attribute : int
	//{
	//	Hidden = 1,
	//	System = 2,
	//	Archive = 3,
	//	ReadOnly = 4,
	//	Compressed = 5
	//}

























	//public enum Attribute : int
	//{
	//	Hidden = 1,
	//	System = 2,
	//	Archive = 4,
	//	ReadOnly = 8,
	//	Compressed = 16
	//}

	// با تشکر از آقای فرهاد حقیقی
	// برای شرایط ترکیبی اگر
	// byte	: 8
	// int	: 32
	// long	: 64
	// حالت بیشتر نمی‌توانیم تعریف کنیم

	//public class File
	//{
	//	public File()
	//	{
	//	}

	//	public string Name;

	//	public int Size;
	//	public Attribute Attribute;
	//}



	public class File
	{
		public enum FileAttribute : int
		{
			Hidden = 1,
			System = 2,
			Archive = 4,
			ReadOnly = 8,
			Compressed = 16
		}

		public File()
		{
		}

		public string Name;

		public int Size;
		public FileAttribute Attribute;
	}


}
