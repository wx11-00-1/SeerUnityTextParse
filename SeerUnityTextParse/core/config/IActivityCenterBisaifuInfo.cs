using System;

namespace core.config
{
	// Token: 0x02001C8A RID: 7306
	public class IActivityCenterBisaifuInfo : IConfigItem
	{
		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600D31A RID: 54042 RVA: 0x003C9004 File Offset: 0x003C7204
		// (set) Token: 0x0600D31B RID: 54043 RVA: 0x003C900C File Offset: 0x003C720C
		public string args { get; set; }

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x0600D31C RID: 54044 RVA: 0x003C9015 File Offset: 0x003C7215
		// (set) Token: 0x0600D31D RID: 54045 RVA: 0x003C901D File Offset: 0x003C721D
		public string beginning { get; set; }

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600D31E RID: 54046 RVA: 0x003C9026 File Offset: 0x003C7226
		// (set) Token: 0x0600D31F RID: 54047 RVA: 0x003C902E File Offset: 0x003C722E
		public string ending { get; set; }

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x0600D320 RID: 54048 RVA: 0x003C9037 File Offset: 0x003C7237
		// (set) Token: 0x0600D321 RID: 54049 RVA: 0x003C903F File Offset: 0x003C723F
		public string labelName { get; set; }

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600D322 RID: 54050 RVA: 0x003C9048 File Offset: 0x003C7248
		// (set) Token: 0x0600D323 RID: 54051 RVA: 0x003C9050 File Offset: 0x003C7250
		public string name { get; set; }

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600D324 RID: 54052 RVA: 0x003C9059 File Offset: 0x003C7259
		// (set) Token: 0x0600D325 RID: 54053 RVA: 0x003C9061 File Offset: 0x003C7261
		public int channel { get; set; }

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x0600D326 RID: 54054 RVA: 0x003C906A File Offset: 0x003C726A
		// (set) Token: 0x0600D327 RID: 54055 RVA: 0x003C9072 File Offset: 0x003C7272
		public int Go { get; set; }

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x0600D328 RID: 54056 RVA: 0x003C907B File Offset: 0x003C727B
		// (set) Token: 0x0600D329 RID: 54057 RVA: 0x003C9083 File Offset: 0x003C7283
		public int helptips { get; set; }

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x0600D32A RID: 54058 RVA: 0x003C908C File Offset: 0x003C728C
		// (set) Token: 0x0600D32B RID: 54059 RVA: 0x003C9094 File Offset: 0x003C7294
		public int id { get; set; }

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600D32C RID: 54060 RVA: 0x003C909D File Offset: 0x003C729D
		// (set) Token: 0x0600D32D RID: 54061 RVA: 0x003C90A5 File Offset: 0x003C72A5
		public int iOSreviewshow { get; set; }

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600D32E RID: 54062 RVA: 0x003C90AE File Offset: 0x003C72AE
		// (set) Token: 0x0600D32F RID: 54063 RVA: 0x003C90B6 File Offset: 0x003C72B6
		public int isShow { get; set; }

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600D330 RID: 54064 RVA: 0x003C90BF File Offset: 0x003C72BF
		// (set) Token: 0x0600D331 RID: 54065 RVA: 0x003C90C7 File Offset: 0x003C72C7
		public int redbadge { get; set; }

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600D332 RID: 54066 RVA: 0x003C90D0 File Offset: 0x003C72D0
		// (set) Token: 0x0600D333 RID: 54067 RVA: 0x003C90D8 File Offset: 0x003C72D8
		public int signType { get; set; }

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600D334 RID: 54068 RVA: 0x003C90E1 File Offset: 0x003C72E1
		// (set) Token: 0x0600D335 RID: 54069 RVA: 0x003C90E9 File Offset: 0x003C72E9
		public int sorting { get; set; }

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x0600D336 RID: 54070 RVA: 0x003C90F2 File Offset: 0x003C72F2
		// (set) Token: 0x0600D337 RID: 54071 RVA: 0x003C90FA File Offset: 0x003C72FA
		public int type { get; set; }

		// Token: 0x0600D338 RID: 54072 RVA: 0x003C9104 File Offset: 0x003C7304
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.channel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.helptips = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.iOSreviewshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.labelName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.signType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
