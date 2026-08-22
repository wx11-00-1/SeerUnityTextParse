namespace core.config
{
	public class IBagTowerEquipUpgradeInfo : IConfigItem
	{
		public string icon { get; set; }

		public string name { get; set; }

		public int[] cost { get; set; }

		public int atk { get; set; }

		public int defadd { get; set; }

		public int flyspeed { get; set; }

		public int goldadd { get; set; }

		public int hpaddlimit { get; set; }

		public int hprecover { get; set; }

		public int id { get; set; }

		public int isshow { get; set; }

		public int lv { get; set; }

		public int opensynthesis { get; set; }

		public int range { get; set; }

		public int size { get; set; }

		public int subtype { get; set; }

		public int target { get; set; }

		public int type { get; set; }

		public int unlockeffect { get; set; }

		public int usespeed { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				cost = new int[num];
				for (int i = 0; i < num; i++)
				{
					cost[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			defadd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			flyspeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			goldadd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hpaddlimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hprecover = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			opensynthesis = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			range = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			size = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlockeffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			usespeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
