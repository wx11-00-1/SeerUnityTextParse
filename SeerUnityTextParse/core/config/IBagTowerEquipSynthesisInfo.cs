namespace core.config
{
	public class IBagTowerEquipSynthesisInfo : IConfigItem
	{
		public string image { get; set; }

		public string name { get; set; }

		public int atkgrowth { get; set; }

		public int defaddgrowth { get; set; }

		public int geteffect { get; set; }

		public int goldaddgrowth { get; set; }

		public int hpadlimitgrowth { get; set; }

		public int hprecovergrowth { get; set; }

		public int id { get; set; }

		public int synthesislv { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atkgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			defaddgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			geteffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			goldaddgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hpadlimitgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hprecovergrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			synthesislv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
