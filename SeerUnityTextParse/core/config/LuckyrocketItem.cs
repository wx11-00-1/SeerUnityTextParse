using System;

namespace core.config
{
	// Token: 0x02001D87 RID: 7559
	public class LuckyrocketItem : XlsConfigBase<LuckyrocketItem, ILuckyrocketItemInfo>
	{
		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x0600DDB0 RID: 56752 RVA: 0x003D5CB9 File Offset: 0x003D3EB9
		public override string fileName
		{
			get
			{
				return "luckyrocketItem";
			}
		}

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x003D5CC0 File Offset: 0x003D3EC0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILuckyrocketItemInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILuckyrocketItemInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x003D5D14 File Offset: 0x003D3F14
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
