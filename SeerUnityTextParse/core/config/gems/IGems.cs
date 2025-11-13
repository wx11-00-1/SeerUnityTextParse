using System;

namespace core.config.gems
{
	// Token: 0x0200202D RID: 8237
	public class IGems
	{
		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600FB8B RID: 64395 RVA: 0x00400E2C File Offset: 0x003FF02C
		// (set) Token: 0x0600FB8C RID: 64396 RVA: 0x00400E34 File Offset: 0x003FF034
		public IGemItem[] Gem { get; set; }

		// Token: 0x0600FB8D RID: 64397 RVA: 0x00400E40 File Offset: 0x003FF040
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Gem = new IGemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Gem[i] = new IGemItem();
					this.Gem[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
