using System;

namespace core.config
{
	// Token: 0x02001D8B RID: 7563
	public class LuckyrocketLevelcontent : XlsConfigBase<LuckyrocketLevelcontent, ILuckyrocketLevelcontentInfo>
	{
		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x0600DDDE RID: 56798 RVA: 0x003D5FF1 File Offset: 0x003D41F1
		public override string fileName
		{
			get
			{
				return "luckyrocketLevelcontent";
			}
		}

		// Token: 0x0600DDDF RID: 56799 RVA: 0x003D5FF8 File Offset: 0x003D41F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILuckyrocketLevelcontentInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILuckyrocketLevelcontentInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DDE0 RID: 56800 RVA: 0x003D604C File Offset: 0x003D424C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
