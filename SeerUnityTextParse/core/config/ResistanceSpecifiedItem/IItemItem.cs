using System;

namespace core.config.ResistanceSpecifiedItem
{
	// Token: 0x02001F2D RID: 7981
	public class IItemItem
	{
		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x0600EF5E RID: 61278 RVA: 0x003F3840 File Offset: 0x003F1A40
		// (set) Token: 0x0600EF5F RID: 61279 RVA: 0x003F3848 File Offset: 0x003F1A48
		public string ExchangeCtrlSp { get; set; }

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x0600EF60 RID: 61280 RVA: 0x003F3851 File Offset: 0x003F1A51
		// (set) Token: 0x0600EF61 RID: 61281 RVA: 0x003F3859 File Offset: 0x003F1A59
		public string ExchangeWeakSp { get; set; }

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x0600EF62 RID: 61282 RVA: 0x003F3862 File Offset: 0x003F1A62
		// (set) Token: 0x0600EF63 RID: 61283 RVA: 0x003F386A File Offset: 0x003F1A6A
		public string TargetCtrlSp { get; set; }

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x0600EF64 RID: 61284 RVA: 0x003F3873 File Offset: 0x003F1A73
		// (set) Token: 0x0600EF65 RID: 61285 RVA: 0x003F387B File Offset: 0x003F1A7B
		public string TargetWeakSp { get; set; }

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x0600EF66 RID: 61286 RVA: 0x003F3884 File Offset: 0x003F1A84
		// (set) Token: 0x0600EF67 RID: 61287 RVA: 0x003F388C File Offset: 0x003F1A8C
		public int ExchangeCtrlCnt { get; set; }

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x0600EF68 RID: 61288 RVA: 0x003F3895 File Offset: 0x003F1A95
		// (set) Token: 0x0600EF69 RID: 61289 RVA: 0x003F389D File Offset: 0x003F1A9D
		public int ExchangeWeakCnt { get; set; }

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x0600EF6A RID: 61290 RVA: 0x003F38A6 File Offset: 0x003F1AA6
		// (set) Token: 0x0600EF6B RID: 61291 RVA: 0x003F38AE File Offset: 0x003F1AAE
		public int ID { get; set; }

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x0600EF6C RID: 61292 RVA: 0x003F38B7 File Offset: 0x003F1AB7
		// (set) Token: 0x0600EF6D RID: 61293 RVA: 0x003F38BF File Offset: 0x003F1ABF
		public int TargetCtrlCnt { get; set; }

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x0600EF6E RID: 61294 RVA: 0x003F38C8 File Offset: 0x003F1AC8
		// (set) Token: 0x0600EF6F RID: 61295 RVA: 0x003F38D0 File Offset: 0x003F1AD0
		public int TargetWeakCnt { get; set; }

		// Token: 0x0600EF70 RID: 61296 RVA: 0x003F38DC File Offset: 0x003F1ADC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExchangeCtrlCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeCtrlSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeWeakCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeWeakSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetCtrlCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetCtrlSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TargetWeakCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetWeakSp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
