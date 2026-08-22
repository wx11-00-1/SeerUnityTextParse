namespace core.config
{
	public class IAdAstraGalaxyInfo : IConfigItem
	{
		public string galaxyName { get; set; }

		public string galaxyNameEn { get; set; }

		public string starLevel { get; set; }

		public string starName { get; set; }

		public string unlockStar { get; set; }

		public int endTime { get; set; }

		public int galaxyId { get; set; }

		public int galaxyType { get; set; }

		public int id { get; set; }

		public int starId { get; set; }

		public int starProgressAll { get; set; }

		public int unlockTime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			endTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			galaxyId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			galaxyName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			galaxyNameEn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			galaxyType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starLevel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			starName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			starProgressAll = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlockStar = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlockTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
