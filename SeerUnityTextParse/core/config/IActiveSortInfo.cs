using System;

namespace core.config
{
	// Token: 0x02001C84 RID: 7300
	public class IActiveSortInfo : IConfigItem
	{
		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x0600D2AE RID: 53934 RVA: 0x003C8848 File Offset: 0x003C6A48
		// (set) Token: 0x0600D2AF RID: 53935 RVA: 0x003C8850 File Offset: 0x003C6A50
		public string controller { get; set; }

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x0600D2B0 RID: 53936 RVA: 0x003C8859 File Offset: 0x003C6A59
		// (set) Token: 0x0600D2B1 RID: 53937 RVA: 0x003C8861 File Offset: 0x003C6A61
		public string dest { get; set; }

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x0600D2B2 RID: 53938 RVA: 0x003C886A File Offset: 0x003C6A6A
		// (set) Token: 0x0600D2B3 RID: 53939 RVA: 0x003C8872 File Offset: 0x003C6A72
		public string finishtime { get; set; }

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x0600D2B4 RID: 53940 RVA: 0x003C887B File Offset: 0x003C6A7B
		// (set) Token: 0x0600D2B5 RID: 53941 RVA: 0x003C8883 File Offset: 0x003C6A83
		public string image { get; set; }

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x0600D2B6 RID: 53942 RVA: 0x003C888C File Offset: 0x003C6A8C
		// (set) Token: 0x0600D2B7 RID: 53943 RVA: 0x003C8894 File Offset: 0x003C6A94
		public string name { get; set; }

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x003C889D File Offset: 0x003C6A9D
		// (set) Token: 0x0600D2B9 RID: 53945 RVA: 0x003C88A5 File Offset: 0x003C6AA5
		public int[] reddotid { get; set; }

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x003C88AE File Offset: 0x003C6AAE
		// (set) Token: 0x0600D2BB RID: 53947 RVA: 0x003C88B6 File Offset: 0x003C6AB6
		public int dailyRed { get; set; }

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600D2BC RID: 53948 RVA: 0x003C88BF File Offset: 0x003C6ABF
		// (set) Token: 0x0600D2BD RID: 53949 RVA: 0x003C88C7 File Offset: 0x003C6AC7
		public int id { get; set; }

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600D2BE RID: 53950 RVA: 0x003C88D0 File Offset: 0x003C6AD0
		// (set) Token: 0x0600D2BF RID: 53951 RVA: 0x003C88D8 File Offset: 0x003C6AD8
		public int iOSreviewshow { get; set; }

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600D2C0 RID: 53952 RVA: 0x003C88E1 File Offset: 0x003C6AE1
		// (set) Token: 0x0600D2C1 RID: 53953 RVA: 0x003C88E9 File Offset: 0x003C6AE9
		public int isdeadline { get; set; }

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x0600D2C2 RID: 53954 RVA: 0x003C88F2 File Offset: 0x003C6AF2
		// (set) Token: 0x0600D2C3 RID: 53955 RVA: 0x003C88FA File Offset: 0x003C6AFA
		public int isshow { get; set; }

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x0600D2C4 RID: 53956 RVA: 0x003C8903 File Offset: 0x003C6B03
		// (set) Token: 0x0600D2C5 RID: 53957 RVA: 0x003C890B File Offset: 0x003C6B0B
		public int jumptarget { get; set; }

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x0600D2C6 RID: 53958 RVA: 0x003C8914 File Offset: 0x003C6B14
		// (set) Token: 0x0600D2C7 RID: 53959 RVA: 0x003C891C File Offset: 0x003C6B1C
		public int priority { get; set; }

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600D2C8 RID: 53960 RVA: 0x003C8925 File Offset: 0x003C6B25
		// (set) Token: 0x0600D2C9 RID: 53961 RVA: 0x003C892D File Offset: 0x003C6B2D
		public int truepos { get; set; }

		// Token: 0x0600D2CA RID: 53962 RVA: 0x003C8938 File Offset: 0x003C6B38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.controller = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dailyRed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dest = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.finishtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.iOSreviewshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isdeadline = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jumptarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reddotid = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.reddotid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.truepos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
