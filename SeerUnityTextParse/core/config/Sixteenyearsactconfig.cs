using System;

namespace core.config
{
	// Token: 0x02001E21 RID: 7713
	public class Sixteenyearsactconfig : XlsConfigBase<Sixteenyearsactconfig, ISixteenyearsactconfigInfo>
	{
		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x0600E448 RID: 58440 RVA: 0x003DE31D File Offset: 0x003DC51D
		public override string fileName
		{
			get
			{
				return "sixteenyearsactconfig";
			}
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x003DE324 File Offset: 0x003DC524
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISixteenyearsactconfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISixteenyearsactconfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E44A RID: 58442 RVA: 0x003DE378 File Offset: 0x003DC578
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
