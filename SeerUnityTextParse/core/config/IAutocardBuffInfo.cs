namespace core.config
{
	public class IAutocardBuffInfo : IConfigItem
	{
		public string buffDes { get; set; }

		public string buffobject { get; set; }

		public string buffparam { get; set; }

		public string effectIcon { get; set; }

		public int id { get; set; }

		public int IsBfBattleEffect { get; set; }

		public int IsColdWaveEffect { get; set; }

		public int IsDeathEffect { get; set; }

		public int IsGrowthEffect { get; set; }

		public int IsPlaceEffect { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			IsBfBattleEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsColdWaveEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsDeathEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsGrowthEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsPlaceEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			buffDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			buffobject = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			buffparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			effectIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
