namespace core.config.achievements
{
	public class IRuleItem
	{
		public int branchId;

		public string branchDesc;

		public int isShowPro;

		public int IsSingle;

		public int type;

		public string abtext { get; set; }

		public string achName { get; set; }

		public string Desc { get; set; }

		public string Threshold { get; set; }

		public string title { get; set; }

		public string titleColor { get; set; }

		public int AbilityTitle { get; set; }

		public int AchievementPoint { get; set; }

		public int hide { get; set; }

		public int ID { get; set; }

		public int proicon { get; set; }

		public int SpeNameBonus { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			AbilityTitle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			AchievementPoint = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SpeNameBonus = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Threshold = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			abtext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			achName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			proicon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			titleColor = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
