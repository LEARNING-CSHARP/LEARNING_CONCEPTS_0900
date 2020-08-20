namespace LEARNING_CONCEPTS
{
	//public enum FileAttributes : int
	//{
	//	Hidden = 1,
	//	System = 2,
	//	Archive = 3,
	//	ReadOnly = 4,
	//	Compressed = 5,
	//}




















	public enum FileAttributes : int
	{
		Hidden = 1,
		System = 2,
		Archive = 4,
		ReadOnly = 8,
		Compressed = 16,
	}

	// با تشکر از آقای فرهاد حقیقی
	// برای شرایط ترکیبی اگر
	// byte	: 8
	// int	: 32
	// long	: 64
	// حالت بیشتر نمی‌توانیم تعریف کنیم

	public class File
	{
		public File()
		{
		}

		public int Size { get; set; }

		public string Name { get; set; }

		public FileAttributes Attributes { get; set; }
	}

	//public class File
	//{
	//	public enum FileAttributes : int
	//	{
	//		Hidden = 1,
	//		System = 2,
	//		Archive = 4,
	//		ReadOnly = 8,
	//		Compressed = 16
	//	}

	//	public File()
	//	{
	//	}

	//	public int Size { get; set; }
	//	public string Name { get; set; }
	//	public FileAttributes Attributes { get; set; }
	//}
}
