using System;

namespace core.config.map_config
{
	// Token: 0x02001FD2 RID: 8146
	public class IEntries
	{
		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600F58B RID: 62859 RVA: 0x003FAFF6 File Offset: 0x003F91F6
		// (set) Token: 0x0600F58C RID: 62860 RVA: 0x003FAFFE File Offset: 0x003F91FE
		public IEntryItem[] Entry { get; set; }

		// Token: 0x0600F58D RID: 62861 RVA: 0x003FB008 File Offset: 0x003F9208
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Entry = new IEntryItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Entry[i] = new IEntryItem();
					this.Entry[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
