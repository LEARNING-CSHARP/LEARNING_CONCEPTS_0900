namespace LEARNING_CONCEPTS
{
	//public enum FileAttribute : int
	//{
	//	Hidden = 1,
	//	System = 2,
	//	Archive = 3,
	//	ReadOnly = 4,
	//	Compressed = 5
	//}

	public enum FileAttribute : int
	{
		Hidden = 1,
		System = 2,
		Archive = 4,
		ReadOnly = 8,
		Compressed = 16
	}

	// با تشکر از آقای فرهاد حقیقی
	// برای شرایط ترکیبی اگر
	// byte	: 8
	// int	: 32
	// long	: 64
	// حالت بیشتر نمی‌توانیم تعریف کنیم

	public class File
	{
		public string Name;

		public int Size;
		public FileAttribute Attribute;
		//public FileAttribute FileAttribute; // Not Recommended!
	}
}
