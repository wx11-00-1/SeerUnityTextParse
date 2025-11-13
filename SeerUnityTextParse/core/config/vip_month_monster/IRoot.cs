using System;

namespace core.config.vip_month_monster
{
	// Token: 0x02001EFB RID: 7931
	public class IRoot
	{
		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600ED7E RID: 60798 RVA: 0x003F1505 File Offset: 0x003EF705
		// (set) Token: 0x0600ED7F RID: 60799 RVA: 0x003F150D File Offset: 0x003EF70D
		public IItemItem[] Item { get; set; }

		// Token: 0x0600ED80 RID: 60800 RVA: 0x003F1518 File Offset: 0x003EF718
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Item[i] = new IItemItem();
					this.Item[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
