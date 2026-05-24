using System;

namespace core.config
{
	// Token: 0x020026BC RID: 9916
	public class StoryAnniversary2026FreeShop : XlsConfigBase<StoryAnniversary2026FreeShop, IStoryAnniversary2026FreeShopInfo>
	{
		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x060134DE RID: 79070 RVA: 0x00523493 File Offset: 0x00521693
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026FreeShop";
			}
		}

		// Token: 0x060134DF RID: 79071 RVA: 0x0052349C File Offset: 0x0052169C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026FreeShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026FreeShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060134E0 RID: 79072 RVA: 0x005234F0 File Offset: 0x005216F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
