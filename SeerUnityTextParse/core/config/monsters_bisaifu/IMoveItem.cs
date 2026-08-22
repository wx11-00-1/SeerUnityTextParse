namespace core.config.monsters_bisaifu
{
	public class IMoveItem
	{
		public int ID { get; set; }

		public int LearningLv { get; set; }

		public int Rec { get; set; }

		public int Tag { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LearningLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
