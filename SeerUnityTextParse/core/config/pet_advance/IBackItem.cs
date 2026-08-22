namespace core.config.pet_advance
{
	public class IBackItem
	{
		public string desc { get; set; }

		public int ID { get; set; }

		public int IsBack { get; set; }

		public int MonsterId { get; set; }

		public int PerNeedCoinB { get; set; }

		public int TaskId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsBack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PerNeedCoinB = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TaskId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
