using System;

namespace core.config
{
	// Token: 0x02001C8D RID: 7309
	public class ActivityShopConfig : XlsConfigBase<ActivityShopConfig, IActivityShopConfigInfo>
	{
		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x0600D360 RID: 54112 RVA: 0x003C94A7 File Offset: 0x003C76A7
		public override string fileName
		{
			get
			{
				return "Activity_ShopConfig";
			}
		}

		// Token: 0x0600D361 RID: 54113 RVA: 0x003C94B0 File Offset: 0x003C76B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityShopConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityShopConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D362 RID: 54114 RVA: 0x003C9504 File Offset: 0x003C7704
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
