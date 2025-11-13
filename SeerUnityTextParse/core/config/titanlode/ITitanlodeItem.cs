using System;

namespace core.config.titanlode
{
	// Token: 0x02001F0E RID: 7950
	public class ITitanlodeItem
	{
		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x0600EE04 RID: 60932 RVA: 0x003F1EBC File Offset: 0x003F00BC
		// (set) Token: 0x0600EE05 RID: 60933 RVA: 0x003F1EC4 File Offset: 0x003F00C4
		public int ID { get; set; }

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x0600EE06 RID: 60934 RVA: 0x003F1ECD File Offset: 0x003F00CD
		// (set) Token: 0x0600EE07 RID: 60935 RVA: 0x003F1ED5 File Offset: 0x003F00D5
		public int bsrewardid { get; set; }

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x003F1EDE File Offset: 0x003F00DE
		// (set) Token: 0x0600EE09 RID: 60937 RVA: 0x003F1EE6 File Offset: 0x003F00E6
		public int[] cltboss { get; set; }

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x0600EE0A RID: 60938 RVA: 0x003F1EEF File Offset: 0x003F00EF
		// (set) Token: 0x0600EE0B RID: 60939 RVA: 0x003F1EF7 File Offset: 0x003F00F7
		public string desc { get; set; }

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x0600EE0C RID: 60940 RVA: 0x003F1F00 File Offset: 0x003F0100
		// (set) Token: 0x0600EE0D RID: 60941 RVA: 0x003F1F08 File Offset: 0x003F0108
		public string exrewardid { get; set; }

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x0600EE0E RID: 60942 RVA: 0x003F1F11 File Offset: 0x003F0111
		// (set) Token: 0x0600EE0F RID: 60943 RVA: 0x003F1F19 File Offset: 0x003F0119
		public int mapid { get; set; }

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x0600EE10 RID: 60944 RVA: 0x003F1F22 File Offset: 0x003F0122
		// (set) Token: 0x0600EE11 RID: 60945 RVA: 0x003F1F2A File Offset: 0x003F012A
		public int mode { get; set; }

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x0600EE12 RID: 60946 RVA: 0x003F1F33 File Offset: 0x003F0133
		// (set) Token: 0x0600EE13 RID: 60947 RVA: 0x003F1F3B File Offset: 0x003F013B
		public int[] passarg { get; set; }

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x0600EE14 RID: 60948 RVA: 0x003F1F44 File Offset: 0x003F0144
		// (set) Token: 0x0600EE15 RID: 60949 RVA: 0x003F1F4C File Offset: 0x003F014C
		public int passtype { get; set; }

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x0600EE16 RID: 60950 RVA: 0x003F1F55 File Offset: 0x003F0155
		// (set) Token: 0x0600EE17 RID: 60951 RVA: 0x003F1F5D File Offset: 0x003F015D
		public int sebossid { get; set; }

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x0600EE18 RID: 60952 RVA: 0x003F1F66 File Offset: 0x003F0166
		// (set) Token: 0x0600EE19 RID: 60953 RVA: 0x003F1F6E File Offset: 0x003F016E
		public int step { get; set; }

		// Token: 0x0600EE1A RID: 60954 RVA: 0x003F1F78 File Offset: 0x003F0178
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bsrewardid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.cltboss = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.cltboss[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exrewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.mapid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.passarg = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.passarg[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.passtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sebossid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F08B RID: 61579
		private bool b;
	}
}
