using System;

namespace core.config
{
	// Token: 0x020027BD RID: 10173
	public class ISeerShipChooseGameAchievementInfo : IConfigItem
	{
		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06014327 RID: 82727 RVA: 0x005656CC File Offset: 0x005638CC
		// (set) Token: 0x06014328 RID: 82728 RVA: 0x005656D4 File Offset: 0x005638D4
		public string achieventment { get; set; }

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06014329 RID: 82729 RVA: 0x005656DD File Offset: 0x005638DD
		// (set) Token: 0x0601432A RID: 82730 RVA: 0x005656E5 File Offset: 0x005638E5
		public string achieventmentDes { get; set; }

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0601432B RID: 82731 RVA: 0x005656EE File Offset: 0x005638EE
		// (set) Token: 0x0601432C RID: 82732 RVA: 0x005656F6 File Offset: 0x005638F6
		public string achieventmentUnlockDes { get; set; }

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x0601432D RID: 82733 RVA: 0x005656FF File Offset: 0x005638FF
		// (set) Token: 0x0601432E RID: 82734 RVA: 0x00565707 File Offset: 0x00563907
		public string condition { get; set; }

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x0601432F RID: 82735 RVA: 0x00565710 File Offset: 0x00563910
		// (set) Token: 0x06014330 RID: 82736 RVA: 0x00565718 File Offset: 0x00563918
		public int id { get; set; }

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06014331 RID: 82737 RVA: 0x00565721 File Offset: 0x00563921
		// (set) Token: 0x06014332 RID: 82738 RVA: 0x00565729 File Offset: 0x00563929
		public int type { get; set; }

		// Token: 0x06014333 RID: 82739 RVA: 0x00565734 File Offset: 0x00563934
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.achieventment = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.achieventmentDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.achieventmentUnlockDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.condition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
