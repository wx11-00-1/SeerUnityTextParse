namespace core.config
{
	public class IBagTowerEquipEffectInfo : IConfigItem
	{
		public string desc { get; set; }

		public string image { get; set; }

		public int[] param2 { get; set; }

		public int effectclass { get; set; }

		public int effectsubtype { get; set; }

		public int effecttype { get; set; }

		public int front { get; set; }

		public int id { get; set; }

		public int isfive { get; set; }

		public int needsynthesis { get; set; }

		public int @object { get; set; }

		public int param1 { get; set; }

		public int quality { get; set; }

		public int repeat { get; set; }

		public int taketime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			effectclass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effectsubtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effecttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			front = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isfive = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			needsynthesis = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			@object = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			param1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				param2 = new int[num];
				for (int i = 0; i < num; i++)
				{
					param2[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			repeat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			taketime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
