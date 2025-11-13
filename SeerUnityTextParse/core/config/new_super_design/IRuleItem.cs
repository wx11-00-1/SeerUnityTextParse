using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F8B RID: 8075
	public class IRuleItem
	{
		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x0600F252 RID: 62034 RVA: 0x003F7250 File Offset: 0x003F5450
		// (set) Token: 0x0600F253 RID: 62035 RVA: 0x003F7258 File Offset: 0x003F5458
		public string Args { get; set; }

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x0600F254 RID: 62036 RVA: 0x003F7261 File Offset: 0x003F5461
		// (set) Token: 0x0600F255 RID: 62037 RVA: 0x003F7269 File Offset: 0x003F5469
		public string CheckTips { get; set; }

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x0600F256 RID: 62038 RVA: 0x003F7272 File Offset: 0x003F5472
		// (set) Token: 0x0600F257 RID: 62039 RVA: 0x003F727A File Offset: 0x003F547A
		public string FailTips { get; set; }

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x0600F258 RID: 62040 RVA: 0x003F7283 File Offset: 0x003F5483
		// (set) Token: 0x0600F259 RID: 62041 RVA: 0x003F728B File Offset: 0x003F548B
		public string RepeatTips { get; set; }

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x0600F25A RID: 62042 RVA: 0x003F7294 File Offset: 0x003F5494
		// (set) Token: 0x0600F25B RID: 62043 RVA: 0x003F729C File Offset: 0x003F549C
		public string UserInfo { get; set; }

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x0600F25C RID: 62044 RVA: 0x003F72A5 File Offset: 0x003F54A5
		// (set) Token: 0x0600F25D RID: 62045 RVA: 0x003F72AD File Offset: 0x003F54AD
		public int ID { get; set; }

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600F25E RID: 62046 RVA: 0x003F72B6 File Offset: 0x003F54B6
		// (set) Token: 0x0600F25F RID: 62047 RVA: 0x003F72BE File Offset: 0x003F54BE
		public int MouldID { get; set; }

		// Token: 0x0600F260 RID: 62048 RVA: 0x003F72C8 File Offset: 0x003F54C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.CheckTips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.FailTips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MouldID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RepeatTips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.UserInfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
