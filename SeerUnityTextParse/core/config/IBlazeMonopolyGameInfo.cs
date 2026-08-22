namespace core.config
{
	public class IBlazeMonopolyGameInfo : IConfigItem
	{
		public string bosspic { get; set; }

		public int[] bossbehavior { get; set; }

		public int[] reward { get; set; }

		public int bosseffects { get; set; }

		public int bosshp { get; set; }

		public float bosspicscale { get; set; }

		public int id { get; set; }

		public int opentime { get; set; }

		public int playerattack { get; set; }

		public int playerhp { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				bossbehavior = new int[num];
				for (int i = 0; i < num; i++)
				{
					bossbehavior[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			bosseffects = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bosshp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bosspic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bosspicscale = ByteUtil.ReadFloat(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerattack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					reward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
