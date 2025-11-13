using System;

namespace core.config
{
	// Token: 0x02001DCE RID: 7630
	public class IPrivateTrainTaskInfo : IConfigItem
	{
		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x003D9868 File Offset: 0x003D7A68
		// (set) Token: 0x0600E0A7 RID: 57511 RVA: 0x003D9870 File Offset: 0x003D7A70
		public string rewardinfo { get; set; }

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x003D9879 File Offset: 0x003D7A79
		// (set) Token: 0x0600E0A9 RID: 57513 RVA: 0x003D9881 File Offset: 0x003D7A81
		public string title { get; set; }

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x0600E0AA RID: 57514 RVA: 0x003D988A File Offset: 0x003D7A8A
		// (set) Token: 0x0600E0AB RID: 57515 RVA: 0x003D9892 File Offset: 0x003D7A92
		public int group { get; set; }

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x0600E0AC RID: 57516 RVA: 0x003D989B File Offset: 0x003D7A9B
		// (set) Token: 0x0600E0AD RID: 57517 RVA: 0x003D98A3 File Offset: 0x003D7AA3
		public int id { get; set; }

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x0600E0AE RID: 57518 RVA: 0x003D98AC File Offset: 0x003D7AAC
		// (set) Token: 0x0600E0AF RID: 57519 RVA: 0x003D98B4 File Offset: 0x003D7AB4
		public int jump { get; set; }

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x0600E0B0 RID: 57520 RVA: 0x003D98BD File Offset: 0x003D7ABD
		// (set) Token: 0x0600E0B1 RID: 57521 RVA: 0x003D98C5 File Offset: 0x003D7AC5
		public int value { get; set; }

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x003D98D0 File Offset: 0x003D7AD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
