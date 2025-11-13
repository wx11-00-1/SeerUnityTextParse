using System;

namespace core.config
{
	// Token: 0x02001DFC RID: 7676
	public class IReturnSigninInfo : IConfigItem
	{
		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x0600E2A0 RID: 58016 RVA: 0x003DBF40 File Offset: 0x003DA140
		// (set) Token: 0x0600E2A1 RID: 58017 RVA: 0x003DBF48 File Offset: 0x003DA148
		public int[] changereward { get; set; }

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x0600E2A2 RID: 58018 RVA: 0x003DBF51 File Offset: 0x003DA151
		// (set) Token: 0x0600E2A3 RID: 58019 RVA: 0x003DBF59 File Offset: 0x003DA159
		public int[] judgepet { get; set; }

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x0600E2A4 RID: 58020 RVA: 0x003DBF62 File Offset: 0x003DA162
		// (set) Token: 0x0600E2A5 RID: 58021 RVA: 0x003DBF6A File Offset: 0x003DA16A
		public int[] previewreward1 { get; set; }

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x0600E2A6 RID: 58022 RVA: 0x003DBF73 File Offset: 0x003DA173
		// (set) Token: 0x0600E2A7 RID: 58023 RVA: 0x003DBF7B File Offset: 0x003DA17B
		public int[] previewreward2 { get; set; }

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x0600E2A8 RID: 58024 RVA: 0x003DBF84 File Offset: 0x003DA184
		// (set) Token: 0x0600E2A9 RID: 58025 RVA: 0x003DBF8C File Offset: 0x003DA18C
		public int[] reward { get; set; }

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x0600E2AA RID: 58026 RVA: 0x003DBF95 File Offset: 0x003DA195
		// (set) Token: 0x0600E2AB RID: 58027 RVA: 0x003DBF9D File Offset: 0x003DA19D
		public int days { get; set; }

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x003DBFA6 File Offset: 0x003DA1A6
		// (set) Token: 0x0600E2AD RID: 58029 RVA: 0x003DBFAE File Offset: 0x003DA1AE
		public int id { get; set; }

		// Token: 0x0600E2AE RID: 58030 RVA: 0x003DBFB8 File Offset: 0x003DA1B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.changereward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.changereward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.days = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.judgepet = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.judgepet[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.previewreward1 = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.previewreward1[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.previewreward2 = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.previewreward2[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.reward[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
