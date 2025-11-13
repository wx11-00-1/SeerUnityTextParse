using System;

namespace core.config
{
	// Token: 0x02001CB5 RID: 7349
	public class Banner : XlsConfigBase<Banner, IBannerInfo>
	{
		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x0600D51A RID: 54554 RVA: 0x003CB503 File Offset: 0x003C9703
		public override string fileName
		{
			get
			{
				return "banner";
			}
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x003CB50C File Offset: 0x003C970C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBannerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBannerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D51C RID: 54556 RVA: 0x003CB560 File Offset: 0x003C9760
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
