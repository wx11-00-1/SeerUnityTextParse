namespace core.config.awakendetail
{
	public class IRoot
	{
		public ITaskItem[] Task { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Task = new ITaskItem[num];
				for (int i = 0; i < num; i++)
				{
					Task[i] = new ITaskItem();
					Task[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
