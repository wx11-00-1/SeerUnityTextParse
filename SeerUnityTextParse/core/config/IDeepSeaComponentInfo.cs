namespace core.config
{
	public class IDeepSeaComponentInfo : IConfigItem
	{
		public string monsterTxt { get; set; }

		public string rewardDrop { get; set; }

		public string type { get; set; }

		public int battleUseID { get; set; }

		public int firstTalkID { get; set; }

		public int id { get; set; }

		public int monsterID { get; set; }

		public int originalState { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			battleUseID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			firstTalkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			originalState = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardDrop = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
