namespace core.config
{
	public class SkinMon : XlsConfigBase<SkinMon, ISkinMonInfo>
	{
		public override string fileName
		{
			get
			{
				return "skinMon";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISkinMonInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISkinMonInfo();
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
