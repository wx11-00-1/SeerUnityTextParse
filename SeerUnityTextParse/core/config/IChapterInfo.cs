namespace core.config
{
	public class IChapterInfo : IConfigItem
	{
		public string bgm { get; set; }

		public string chaptername { get; set; }

		public string enddate { get; set; }

		public string imagebg { get; set; }

		public string imagelist { get; set; }

		public string imagestage { get; set; }

		public string img { get; set; }

		public string intro { get; set; }

		public string logo { get; set; }

		public string previouslyon { get; set; }

		public string startdate { get; set; }

		public string tagname { get; set; }

		public string writingimg { get; set; }

		public string writingname { get; set; }

		public int branch { get; set; }

		public int id { get; set; }

		public int needchapter { get; set; }

		public int recordid { get; set; }

		public int redbadge { get; set; }

		public int tagopen { get; set; }

		public int tagtype { get; set; }

		public int tobe { get; set; }

		public int type { get; set; }

		public int upstory { get; set; }

		public int writing { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bgm = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			branch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chaptername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			enddate = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			imagebg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			imagelist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			imagestage = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			img = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			logo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			needchapter = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			previouslyon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			recordid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			startdate = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tagname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tagopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tagtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tobe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			upstory = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			writing = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			writingimg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			writingname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
