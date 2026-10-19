namespace core.config
{
	public class IAwakenlistTempInfo : IConfigItem
	{
		public string enddate { get; set; }

		public string jumpparam { get; set; }

		public string limitid { get; set; }

		public string monstername { get; set; }

		public string startdate { get; set; }

		public int awakentype { get; set; }

		public int bosslevelid { get; set; }

		public int diamondid { get; set; }

		public int exchangepercnt { get; set; }

		public int fragmentid { get; set; }

		public int fragmentnum { get; set; }

		public int id { get; set; }

		public int itemnum { get; set; }

		public int itemurl { get; set; }

		public int mosterurl { get; set; }

		public int onekeyproductid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			awakentype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bosslevelid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			diamondid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			enddate = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			exchangepercnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			fragmentid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			fragmentnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemurl = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jumpparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			limitid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			monstername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			mosterurl = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			onekeyproductid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			startdate = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
