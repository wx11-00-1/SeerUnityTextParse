using System;

namespace core.config.Monsterpool
{
	// Token: 0x02001FBA RID: 8122
	public class IPoolItem : IConfigItem
	{
		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x0600F4C0 RID: 62656 RVA: 0x003FA01B File Offset: 0x003F821B
		// (set) Token: 0x0600F4C1 RID: 62657 RVA: 0x003FA023 File Offset: 0x003F8223
		public IItemItem[] item { get; set; }

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x0600F4C2 RID: 62658 RVA: 0x003FA02C File Offset: 0x003F822C
		// (set) Token: 0x0600F4C3 RID: 62659 RVA: 0x003FA034 File Offset: 0x003F8234
		public int id { get; set; }

		// Token: 0x0600F4C4 RID: 62660 RVA: 0x003FA040 File Offset: 0x003F8240
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
