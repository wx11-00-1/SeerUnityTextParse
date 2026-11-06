namespace core.config
{
	public class ISomuaWeaponConfigInfo : IConfigItem
	{
		public string fxOnHit { get; set; }

		public string prefab { get; set; }

		public int id { get; set; }

		public int shape { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			fxOnHit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			prefab = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			shape = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
