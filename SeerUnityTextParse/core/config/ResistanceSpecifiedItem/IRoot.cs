using System;

namespace core.config.ResistanceSpecifiedItem
{
	// Token: 0x02001F2E RID: 7982
	public class IRoot
	{
		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x0600EF72 RID: 61298 RVA: 0x003F3982 File Offset: 0x003F1B82
		// (set) Token: 0x0600EF73 RID: 61299 RVA: 0x003F398A File Offset: 0x003F1B8A
		public IItemItem[] item { get; set; }

		// Token: 0x0600EF74 RID: 61300 RVA: 0x003F3994 File Offset: 0x003F1B94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.item[i] = new IItemItem();
					this.item[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
