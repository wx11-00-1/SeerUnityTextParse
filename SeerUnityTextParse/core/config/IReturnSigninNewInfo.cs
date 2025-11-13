using System;

namespace core.config
{
	// Token: 0x02001DFE RID: 7678
	public class IReturnSigninNewInfo : IConfigItem
	{
		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x0600E2B4 RID: 58036 RVA: 0x003DC194 File Offset: 0x003DA394
		// (set) Token: 0x0600E2B5 RID: 58037 RVA: 0x003DC19C File Offset: 0x003DA39C
		public string intro1 { get; set; }

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x0600E2B6 RID: 58038 RVA: 0x003DC1A5 File Offset: 0x003DA3A5
		// (set) Token: 0x0600E2B7 RID: 58039 RVA: 0x003DC1AD File Offset: 0x003DA3AD
		public string intro2 { get; set; }

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x0600E2B8 RID: 58040 RVA: 0x003DC1B6 File Offset: 0x003DA3B6
		// (set) Token: 0x0600E2B9 RID: 58041 RVA: 0x003DC1BE File Offset: 0x003DA3BE
		public string name1 { get; set; }

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x0600E2BA RID: 58042 RVA: 0x003DC1C7 File Offset: 0x003DA3C7
		// (set) Token: 0x0600E2BB RID: 58043 RVA: 0x003DC1CF File Offset: 0x003DA3CF
		public string name2 { get; set; }

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x0600E2BC RID: 58044 RVA: 0x003DC1D8 File Offset: 0x003DA3D8
		// (set) Token: 0x0600E2BD RID: 58045 RVA: 0x003DC1E0 File Offset: 0x003DA3E0
		public int[] fiexdreward1 { get; set; }

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x0600E2BE RID: 58046 RVA: 0x003DC1E9 File Offset: 0x003DA3E9
		// (set) Token: 0x0600E2BF RID: 58047 RVA: 0x003DC1F1 File Offset: 0x003DA3F1
		public int[] fiexdreward2 { get; set; }

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x0600E2C0 RID: 58048 RVA: 0x003DC1FA File Offset: 0x003DA3FA
		// (set) Token: 0x0600E2C1 RID: 58049 RVA: 0x003DC202 File Offset: 0x003DA402
		public int[] judgepet { get; set; }

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x0600E2C2 RID: 58050 RVA: 0x003DC20B File Offset: 0x003DA40B
		// (set) Token: 0x0600E2C3 RID: 58051 RVA: 0x003DC213 File Offset: 0x003DA413
		public int[] optreward1 { get; set; }

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x0600E2C4 RID: 58052 RVA: 0x003DC21C File Offset: 0x003DA41C
		// (set) Token: 0x0600E2C5 RID: 58053 RVA: 0x003DC224 File Offset: 0x003DA424
		public int[] optreward2 { get; set; }

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x0600E2C6 RID: 58054 RVA: 0x003DC22D File Offset: 0x003DA42D
		// (set) Token: 0x0600E2C7 RID: 58055 RVA: 0x003DC235 File Offset: 0x003DA435
		public int days { get; set; }

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x0600E2C8 RID: 58056 RVA: 0x003DC23E File Offset: 0x003DA43E
		// (set) Token: 0x0600E2C9 RID: 58057 RVA: 0x003DC246 File Offset: 0x003DA446
		public int id { get; set; }

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x0600E2CA RID: 58058 RVA: 0x003DC24F File Offset: 0x003DA44F
		// (set) Token: 0x0600E2CB RID: 58059 RVA: 0x003DC257 File Offset: 0x003DA457
		public int jump1 { get; set; }

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x0600E2CC RID: 58060 RVA: 0x003DC260 File Offset: 0x003DA460
		// (set) Token: 0x0600E2CD RID: 58061 RVA: 0x003DC268 File Offset: 0x003DA468
		public int jump2 { get; set; }

		// Token: 0x0600E2CE RID: 58062 RVA: 0x003DC274 File Offset: 0x003DA474
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.days = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fiexdreward1 = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.fiexdreward1[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fiexdreward2 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.fiexdreward2[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.intro2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.judgepet = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.judgepet[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.jump1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.optreward1 = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.optreward1[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.optreward2 = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.optreward2[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
