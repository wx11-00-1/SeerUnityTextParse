using System;

namespace core.config
{
	// Token: 0x02001D83 RID: 7555
	public class LoginGift : XlsConfigBase<LoginGift, ILoginGiftInfo>
	{
		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600DD8A RID: 56714 RVA: 0x003D5A00 File Offset: 0x003D3C00
		public override string fileName
		{
			get
			{
				return "LoginGift";
			}
		}

		// Token: 0x0600DD8B RID: 56715 RVA: 0x003D5A08 File Offset: 0x003D3C08
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILoginGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILoginGiftInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD8C RID: 56716 RVA: 0x003D5A5C File Offset: 0x003D3C5C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
