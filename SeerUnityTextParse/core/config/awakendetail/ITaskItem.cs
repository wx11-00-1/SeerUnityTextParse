namespace core.config.awakendetail
{
	public class ITaskItem
	{
		public IAdvances Advances { get; set; }

		public int ID { get; set; }

		public int NewEffID { get; set; }

		public int OldEffID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Advances = new IAdvances();
				Advances.Parse(bytes, ref byteIndex);
			}
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewEffID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			OldEffID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
