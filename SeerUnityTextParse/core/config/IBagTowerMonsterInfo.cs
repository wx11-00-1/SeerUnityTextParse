namespace core.config
{
	public class IBagTowerMonsterInfo : IConfigItem
	{
		public string name { get; set; }

		public int[] issplit { get; set; }

		public int id { get; set; }

		public int initialatk { get; set; }

		public int initialhp { get; set; }

		public int monstertype { get; set; }

		public int move { get; set; }

		public int range { get; set; }

		public int speed { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initialatk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initialhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				issplit = new int[num];
				for (int i = 0; i < num; i++)
				{
					issplit[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monstertype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			move = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			range = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
