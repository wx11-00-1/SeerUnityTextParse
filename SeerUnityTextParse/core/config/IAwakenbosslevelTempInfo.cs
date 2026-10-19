namespace core.config
{
	public class IAwakenbosslevelTempInfo : IConfigItem
	{
		public string itemid { get; set; }

		public string sceneeffect { get; set; }

		public string troopid { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sceneeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			troopid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
