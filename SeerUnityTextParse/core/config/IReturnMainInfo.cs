using System;

namespace core.config
{
	// Token: 0x02001DFA RID: 7674
	public class IReturnMainInfo : IConfigItem
	{
		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600E28E RID: 57998 RVA: 0x003DBD3C File Offset: 0x003D9F3C
		// (set) Token: 0x0600E28F RID: 57999 RVA: 0x003DBD44 File Offset: 0x003D9F44
		public int[] onespet { get; set; }

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600E290 RID: 58000 RVA: 0x003DBD4D File Offset: 0x003D9F4D
		// (set) Token: 0x0600E291 RID: 58001 RVA: 0x003DBD55 File Offset: 0x003D9F55
		public int[] onesreward { get; set; }

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x0600E292 RID: 58002 RVA: 0x003DBD5E File Offset: 0x003D9F5E
		// (set) Token: 0x0600E293 RID: 58003 RVA: 0x003DBD66 File Offset: 0x003D9F66
		public int[] previewitem { get; set; }

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x0600E294 RID: 58004 RVA: 0x003DBD6F File Offset: 0x003D9F6F
		// (set) Token: 0x0600E295 RID: 58005 RVA: 0x003DBD77 File Offset: 0x003D9F77
		public int[] previewpet { get; set; }

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x0600E296 RID: 58006 RVA: 0x003DBD80 File Offset: 0x003D9F80
		// (set) Token: 0x0600E297 RID: 58007 RVA: 0x003DBD88 File Offset: 0x003D9F88
		public int id { get; set; }

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x0600E298 RID: 58008 RVA: 0x003DBD91 File Offset: 0x003D9F91
		// (set) Token: 0x0600E299 RID: 58009 RVA: 0x003DBD99 File Offset: 0x003D9F99
		public int level { get; set; }

		// Token: 0x0600E29A RID: 58010 RVA: 0x003DBDA4 File Offset: 0x003D9FA4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.onespet = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.onespet[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.onesreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.onesreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.previewitem = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.previewitem[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.previewpet = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.previewpet[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
