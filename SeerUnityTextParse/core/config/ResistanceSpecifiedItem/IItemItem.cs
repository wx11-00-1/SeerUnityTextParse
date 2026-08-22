namespace core.config.ResistanceSpecifiedItem
{
	public class IItemItem
	{
		public string ExchangeCtrlSp { get; set; }

		public string ExchangeWeakSp { get; set; }

		public string TargetCtrlSp { get; set; }

		public string TargetWeakSp { get; set; }

		public int ExchangeCtrlCnt { get; set; }

		public int ExchangeWeakCnt { get; set; }

		public int ID { get; set; }

		public int TargetCtrlCnt { get; set; }

		public int TargetWeakCnt { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExchangeCtrlCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeCtrlSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ExchangeWeakCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeWeakSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetCtrlCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetCtrlSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			TargetWeakCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetWeakSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
