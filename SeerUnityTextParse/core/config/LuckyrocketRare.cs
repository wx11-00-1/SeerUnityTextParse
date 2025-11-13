using System;

namespace core.config
{
	// Token: 0x02001D8D RID: 7565
	public class LuckyrocketRare : XlsConfigBase<LuckyrocketRare, ILuckyrocketRareInfo>
	{
		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x0600DDF4 RID: 56820 RVA: 0x003D61DC File Offset: 0x003D43DC
		public override string fileName
		{
			get
			{
				return "luckyrocketRare";
			}
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x003D61E4 File Offset: 0x003D43E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILuckyrocketRareInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILuckyrocketRareInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x003D6238 File Offset: 0x003D4438
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
