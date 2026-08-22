namespace core.config
{
	public class IActiveSortInfo : IConfigItem
	{
		public string controller { get; set; }

		public string dest { get; set; }

		public string finishtime { get; set; }

		public string image { get; set; }

		public string name { get; set; }

		public string statlog { get; set; }

		public int[] reddotid { get; set; }

		public int dailyRed { get; set; }

		public int id { get; set; }

		public int iOSreviewshow { get; set; }

		public int isdeadline { get; set; }

		public int isshow { get; set; }

		public int jumptarget { get; set; }

		public int priority { get; set; }

		public int truepos { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			controller = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			dailyRed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dest = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			finishtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			iOSreviewshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isdeadline = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jumptarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reddotid = new int[num];
				for (int i = 0; i < num; i++)
				{
					reddotid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			statlog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			truepos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
