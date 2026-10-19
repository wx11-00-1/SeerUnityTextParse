namespace core.config
{
	public class IWarGameLevelInfo : IConfigItem
	{
		public string name { get; set; }

		public string rewardinfo { get; set; }

		public int id { get; set; }

		public int npcFallExp { get; set; }

		public int npcFallHp { get; set; }

		public int npcLvUp { get; set; }

		public int npcNum { get; set; }

		public int npcTime { get; set; }

		public int petLvUp { get; set; }

		public int score { get; set; }

		public int times { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npcFallExp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			npcFallHp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			npcLvUp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			npcNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			npcTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petLvUp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			score = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
