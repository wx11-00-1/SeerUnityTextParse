namespace core.config
{
	public class MountTail : XlsConfigBase<MountTail, IMountTailInfo>
	{
		public override string fileName
		{
			get
			{
				return "mount_tail";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IMountTailInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IMountTailInfo();
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
