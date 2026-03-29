using System;

namespace core.config.fightTestLevelConfig
{
	// Token: 0x020025F3 RID: 9715
	public class IRoot
	{
		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x060131B5 RID: 78261 RVA: 0x004C502A File Offset: 0x004C322A
		// (set) Token: 0x060131B6 RID: 78262 RVA: 0x004C5032 File Offset: 0x004C3232
		public IItemItem[] item { get; set; }

		// Token: 0x060131B7 RID: 78263 RVA: 0x004C503C File Offset: 0x004C323C
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
