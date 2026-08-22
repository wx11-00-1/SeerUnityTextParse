namespace core.config
{
	public class ILlsCookingLvlInfo : IConfigItem
	{
		public string task { get; set; }

		public int[] target { get; set; }

		public int afterchat { get; set; }

		public int afterguide { get; set; }

		public float cooldown { get; set; }

		public int countdown { get; set; }

		public int groupid { get; set; }

		public int id { get; set; }

		public int lvlunlock { get; set; }

		public int prechat { get; set; }

		public int preguide { get; set; }

		public int rule { get; set; }

		public int waiting { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			afterchat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			afterguide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cooldown = ByteUtil.ReadFloat(bytes, ref byteIndex);
			countdown = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			groupid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lvlunlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			prechat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			preguide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				target = new int[num];
				for (int i = 0; i < num; i++)
				{
					target[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			task = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			waiting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
