using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x02002051 RID: 8273
	public class ISwapItem : IConfigItem
	{
		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600FCA3 RID: 64675 RVA: 0x00402274 File Offset: 0x00400474
		// (set) Token: 0x0600FCA4 RID: 64676 RVA: 0x0040227C File Offset: 0x0040047C
		public int id { get; set; }

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600FCA5 RID: 64677 RVA: 0x00402285 File Offset: 0x00400485
		// (set) Token: 0x0600FCA6 RID: 64678 RVA: 0x0040228D File Offset: 0x0040048D
		public int rewards { get; set; }

		// Token: 0x0600FCA7 RID: 64679 RVA: 0x00402296 File Offset: 0x00400496
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewards = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
