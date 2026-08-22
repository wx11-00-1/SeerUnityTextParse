namespace core.config
{
	public class IAutocardBuffInfo : IConfigItem
	{
		public string effectIcon { get; set; }

		public string @object { get; set; }

		public string param { get; set; }

		public string paramDes { get; set; }

		public int id { get; set; }

		public int IsDeathEffect { get; set; }

		public int IsPlaceEffect { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			IsDeathEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsPlaceEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effectIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			@object = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			paramDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
