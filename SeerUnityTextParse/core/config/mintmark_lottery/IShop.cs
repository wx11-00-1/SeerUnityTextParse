namespace core.config.mintmark_lottery
{
	public class IShop
	{
		public IMintMarkItem[] MintMark { get; set; }

		public string name { get; set; }

		public int num { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MintMark = new IMintMarkItem[num];
				for (int i = 0; i < num; i++)
				{
					MintMark[i] = new IMintMarkItem();
					MintMark[i].Parse(bytes, ref byteIndex);
				}
			}
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
