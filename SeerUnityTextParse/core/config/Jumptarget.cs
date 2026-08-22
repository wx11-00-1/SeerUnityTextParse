namespace core.config
{
	public class Jumptarget : XlsConfigBase<Jumptarget, IJumptargetInfo>
	{
		public override string fileName
		{
			get
			{
				return "jumptarget";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IJumptargetInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IJumptargetInfo();
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
