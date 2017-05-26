namespace LEARNING_CONCEPTS
{
	//public enum FileAttributes : int
	//{
	//	Hidden = 1,
	//	System = 2,
	//	Archive = 3,
	//	ReadOnly = 4,
	//	Compressed = 5
	//}

	public enum FileAttributes : int
	{
		Hidden = 1,
		System = 2,
		Archive = 4,
		ReadOnly = 8,
		Compressed = 16
	}

	public class File
	{
		public string Name;

		public int Size;
		public FileAttributes Attribute;
	}
}
