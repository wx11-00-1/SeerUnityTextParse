using System;

namespace core.config
{
	// Token: 0x02002393 RID: 9107
	public class IStgSkillInfo : IConfigItem
	{
		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06011716 RID: 71446 RVA: 0x0049D564 File Offset: 0x0049B764
		// (set) Token: 0x06011717 RID: 71447 RVA: 0x0049D56C File Offset: 0x0049B76C
		public string anim { get; set; }

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06011718 RID: 71448 RVA: 0x0049D575 File Offset: 0x0049B775
		// (set) Token: 0x06011719 RID: 71449 RVA: 0x0049D57D File Offset: 0x0049B77D
		public int[] args { get; set; }

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0601171A RID: 71450 RVA: 0x0049D586 File Offset: 0x0049B786
		// (set) Token: 0x0601171B RID: 71451 RVA: 0x0049D58E File Offset: 0x0049B78E
		public int accumulate { get; set; }

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0601171C RID: 71452 RVA: 0x0049D597 File Offset: 0x0049B797
		// (set) Token: 0x0601171D RID: 71453 RVA: 0x0049D59F File Offset: 0x0049B79F
		public int before { get; set; }

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0601171E RID: 71454 RVA: 0x0049D5A8 File Offset: 0x0049B7A8
		// (set) Token: 0x0601171F RID: 71455 RVA: 0x0049D5B0 File Offset: 0x0049B7B0
		public int cd { get; set; }

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06011720 RID: 71456 RVA: 0x0049D5B9 File Offset: 0x0049B7B9
		// (set) Token: 0x06011721 RID: 71457 RVA: 0x0049D5C1 File Offset: 0x0049B7C1
		public int id { get; set; }

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06011722 RID: 71458 RVA: 0x0049D5CA File Offset: 0x0049B7CA
		// (set) Token: 0x06011723 RID: 71459 RVA: 0x0049D5D2 File Offset: 0x0049B7D2
		public int type { get; set; }

		// Token: 0x06011724 RID: 71460 RVA: 0x0049D5DC File Offset: 0x0049B7DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.accumulate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.anim = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.args = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.args[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.before = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
