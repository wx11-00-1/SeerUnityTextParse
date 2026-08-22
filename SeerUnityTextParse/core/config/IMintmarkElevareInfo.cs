namespace core.config
{
	public class IMintmarkElevareInfo : IConfigItem
	{
		public string desc { get; set; }

		public int[] cost { get; set; }

		public int elevareMintmark { get; set; }

		public int id { get; set; }

		public int originMintmark { get; set; }

		public int primumMintmark { get; set; }

		public int statinfo { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				cost = new int[num];
				for (int i = 0; i < num; i++)
				{
					cost[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			elevareMintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			originMintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			primumMintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			statinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
