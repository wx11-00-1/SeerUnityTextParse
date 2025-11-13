using System;

namespace core.config.signIcon_fight
{
	// Token: 0x02001F23 RID: 7971
	public class IConfig
	{
		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x0600EED6 RID: 61142 RVA: 0x003F2DD4 File Offset: 0x003F0FD4
		// (set) Token: 0x0600EED7 RID: 61143 RVA: 0x003F2DDC File Offset: 0x003F0FDC
		public IItemItem[] item { get; set; }

		// Token: 0x0600EED8 RID: 61144 RVA: 0x003F2DE8 File Offset: 0x003F0FE8
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
