namespace core.config.open_time_limit
{
	public class ITimeLimitItem
	{
		public string EndTime { get; set; }

		public string StartTime { get; set; }

		public int TID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			EndTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			StartTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			TID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
