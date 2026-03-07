using System;

namespace core.config.achievements_temp
{
	// Token: 0x02002357 RID: 9047
	public class IAchievementRules
	{
		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x06011A3C RID: 72252 RVA: 0x0046DCCC File Offset: 0x0046BECC
		// (set) Token: 0x06011A3D RID: 72253 RVA: 0x0046DCD4 File Offset: 0x0046BED4
		public ITypeItem[] type { get; set; }

		// Token: 0x06011A3E RID: 72254 RVA: 0x0046DCE0 File Offset: 0x0046BEE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.type = new ITypeItem[num];
				for (int i = 0; i < num; i++)
				{
					this.type[i] = new ITypeItem();
					this.type[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
