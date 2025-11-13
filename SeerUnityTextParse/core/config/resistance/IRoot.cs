using System;

namespace core.config.resistance
{
	// Token: 0x02001F31 RID: 7985
	public class IRoot
	{
		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x0600EF84 RID: 61316 RVA: 0x003F3AB0 File Offset: 0x003F1CB0
		// (set) Token: 0x0600EF85 RID: 61317 RVA: 0x003F3AB8 File Offset: 0x003F1CB8
		public IHurtItem[] hurt { get; set; }

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x0600EF86 RID: 61318 RVA: 0x003F3AC1 File Offset: 0x003F1CC1
		// (set) Token: 0x0600EF87 RID: 61319 RVA: 0x003F3AC9 File Offset: 0x003F1CC9
		public IHurtItem[] resistance { get; set; }

		// Token: 0x0600EF88 RID: 61320 RVA: 0x003F3AD4 File Offset: 0x003F1CD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.hurt = new IHurtItem[num];
				for (int i = 0; i < num; i++)
				{
					this.hurt[i] = new IHurtItem();
					this.hurt[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.resistance = new IHurtItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.resistance[j] = new IHurtItem();
					this.resistance[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
