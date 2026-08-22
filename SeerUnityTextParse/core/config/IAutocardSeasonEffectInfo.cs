namespace core.config
{
	public class IAutocardSeasonEffectInfo : IConfigItem
	{
		public string BuffDisplay { get; set; }

		public string BuffId { get; set; }

		public string BuffParam { get; set; }

		public string effectName { get; set; }

		public string effectTxt { get; set; }

		public int CountNum { get; set; }

		public int DefaultNum { get; set; }

		public int effectGroup { get; set; }

		public int id { get; set; }

		public int opTurn { get; set; }

		public int picID { get; set; }

		public int season { get; set; }

		public int stageLevel { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			BuffDisplay = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			BuffId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			BuffParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			CountNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			DefaultNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effectGroup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effectName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			effectTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opTurn = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			picID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			season = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageLevel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
