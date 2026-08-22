namespace core.config
{
	public class DailytaskGift : XlsConfigBase<DailytaskGift, IDailytaskGiftInfo>
	{
		public override string fileName
		{
			get
			{
				return "dailytask_gift";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDailytaskGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDailytaskGiftInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
