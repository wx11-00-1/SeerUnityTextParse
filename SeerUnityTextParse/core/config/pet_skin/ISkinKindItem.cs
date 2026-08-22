namespace core.config.pet_skin
{
	public class ISkinKindItem
	{
		public int ID { get; set; }

		public int LifeTime { get; set; }

		public int SkinType { get; set; }

		public int Type { get; set; }

		public int Year { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SkinType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Year = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
