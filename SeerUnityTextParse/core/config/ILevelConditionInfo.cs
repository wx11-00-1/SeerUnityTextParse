using System;

namespace core.config
{
	// Token: 0x02001D74 RID: 7540
	public class ILevelConditionInfo : IConfigItem
	{
		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x0600DCEC RID: 56556 RVA: 0x003D4EE4 File Offset: 0x003D30E4
		// (set) Token: 0x0600DCED RID: 56557 RVA: 0x003D4EEC File Offset: 0x003D30EC
		public string script { get; set; }

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x0600DCEE RID: 56558 RVA: 0x003D4EF5 File Offset: 0x003D30F5
		// (set) Token: 0x0600DCEF RID: 56559 RVA: 0x003D4EFD File Offset: 0x003D30FD
		public int count { get; set; }

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x003D4F06 File Offset: 0x003D3106
		// (set) Token: 0x0600DCF1 RID: 56561 RVA: 0x003D4F0E File Offset: 0x003D310E
		public int id { get; set; }

		// Token: 0x0600DCF2 RID: 56562 RVA: 0x003D4F17 File Offset: 0x003D3117
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.script = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
