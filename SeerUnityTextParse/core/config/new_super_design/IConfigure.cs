using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F84 RID: 8068
	public class IConfigure
	{
		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x0600F1FE RID: 61950 RVA: 0x003F6BEA File Offset: 0x003F4DEA
		// (set) Token: 0x0600F1FF RID: 61951 RVA: 0x003F6BF2 File Offset: 0x003F4DF2
		public int[] ExchangeID { get; set; }

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x0600F200 RID: 61952 RVA: 0x003F6BFB File Offset: 0x003F4DFB
		// (set) Token: 0x0600F201 RID: 61953 RVA: 0x003F6C03 File Offset: 0x003F4E03
		public int[] ExchangeProductID { get; set; }

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x0600F202 RID: 61954 RVA: 0x003F6C0C File Offset: 0x003F4E0C
		// (set) Token: 0x0600F203 RID: 61955 RVA: 0x003F6C14 File Offset: 0x003F4E14
		public int Exchange_mintmark { get; set; }

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x0600F204 RID: 61956 RVA: 0x003F6C1D File Offset: 0x003F4E1D
		// (set) Token: 0x0600F205 RID: 61957 RVA: 0x003F6C25 File Offset: 0x003F4E25
		public int FailTimes { get; set; }

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x0600F206 RID: 61958 RVA: 0x003F6C2E File Offset: 0x003F4E2E
		// (set) Token: 0x0600F207 RID: 61959 RVA: 0x003F6C36 File Offset: 0x003F4E36
		public int needmon { get; set; }

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x0600F208 RID: 61960 RVA: 0x003F6C3F File Offset: 0x003F4E3F
		// (set) Token: 0x0600F209 RID: 61961 RVA: 0x003F6C47 File Offset: 0x003F4E47
		public int ProgressValue { get; set; }

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x0600F20A RID: 61962 RVA: 0x003F6C50 File Offset: 0x003F4E50
		// (set) Token: 0x0600F20B RID: 61963 RVA: 0x003F6C58 File Offset: 0x003F4E58
		public int Times { get; set; }

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x0600F20C RID: 61964 RVA: 0x003F6C61 File Offset: 0x003F4E61
		// (set) Token: 0x0600F20D RID: 61965 RVA: 0x003F6C69 File Offset: 0x003F4E69
		public int TimeValue { get; set; }

		// Token: 0x0600F20E RID: 61966 RVA: 0x003F6C74 File Offset: 0x003F4E74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ExchangeID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.ExchangeID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ExchangeProductID = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.ExchangeProductID[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.Exchange_mintmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FailTimes = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ProgressValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TimeValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needmon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
