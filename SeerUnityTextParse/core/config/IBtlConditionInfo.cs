using System;

namespace core.config
{
	// Token: 0x02001CE0 RID: 7392
	public class IBtlConditionInfo : IConfigItem
	{
		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x0600D69A RID: 54938 RVA: 0x003CD270 File Offset: 0x003CB470
		// (set) Token: 0x0600D69B RID: 54939 RVA: 0x003CD278 File Offset: 0x003CB478
		public string btldesc { get; set; }

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600D69C RID: 54940 RVA: 0x003CD281 File Offset: 0x003CB481
		// (set) Token: 0x0600D69D RID: 54941 RVA: 0x003CD289 File Offset: 0x003CB489
		public int baseconid { get; set; }

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x0600D69E RID: 54942 RVA: 0x003CD292 File Offset: 0x003CB492
		// (set) Token: 0x0600D69F RID: 54943 RVA: 0x003CD29A File Offset: 0x003CB49A
		public int id { get; set; }

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x003CD2A3 File Offset: 0x003CB4A3
		// (set) Token: 0x0600D6A1 RID: 54945 RVA: 0x003CD2AB File Offset: 0x003CB4AB
		public int sendNumber { get; set; }

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x003CD2B4 File Offset: 0x003CB4B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.baseconid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.btldesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sendNumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
