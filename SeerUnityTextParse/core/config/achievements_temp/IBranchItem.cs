namespace core.config.achievements_temp
{
	public class IBranchItem
	{
		public string _text { get; set; }

		public string Desc { get; set; }

		public IRuleItem[] Rule { get; set; }

		public int ID { get; set; }

		public int isShowPro { get; set; }

		public int IsSingle { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsSingle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Rule = new IRuleItem[num];
				for (int i = 0; i < num; i++)
				{
					Rule[i] = new IRuleItem();
					Rule[i].Parse(bytes, ref byteIndex);
				}
			}
			_text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isShowPro = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
