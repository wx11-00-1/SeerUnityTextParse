namespace core.config
{
	public class Year2025StgBullet : XlsConfigBase<Year2025StgBullet, IYear2025StgBulletInfo>
	{
		public override string fileName
		{
			get
			{
				return "year2025_stg_bullet";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IYear2025StgBulletInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IYear2025StgBulletInfo();
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
