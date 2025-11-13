using System;

namespace core.config.servername
{
	// Token: 0x02001F2B RID: 7979
	public class IRoot
	{
		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x0600EF54 RID: 61268 RVA: 0x003F3775 File Offset: 0x003F1975
		// (set) Token: 0x0600EF55 RID: 61269 RVA: 0x003F377D File Offset: 0x003F197D
		public IListItem[] list { get; set; }

		// Token: 0x0600EF56 RID: 61270 RVA: 0x003F3788 File Offset: 0x003F1988
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.list = new IListItem[num];
				for (int i = 0; i < num; i++)
				{
					this.list[i] = new IListItem();
					this.list[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
