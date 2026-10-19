namespace core.config
{
	public class IAutocardCollectSessionInfo : IConfigItem
	{
		public string sessionCoin { get; set; }

		public int helptips1 { get; set; }

		public int id { get; set; }

		public int redbadge1 { get; set; }

		public int redbadge2 { get; set; }

		public int redbadge3 { get; set; }

		public int redbadge4 { get; set; }

		public int redbadge5 { get; set; }

		public int redbadge6 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			helptips1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sessionCoin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
