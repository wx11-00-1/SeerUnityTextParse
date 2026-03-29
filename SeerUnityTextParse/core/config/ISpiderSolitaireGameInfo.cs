using System;

namespace core.config
{
	// Token: 0x0200236F RID: 9071
	public class ISpiderSolitaireGameInfo : IConfigItem
	{
		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06011590 RID: 71056 RVA: 0x0049B6F4 File Offset: 0x004998F4
		// (set) Token: 0x06011591 RID: 71057 RVA: 0x0049B6FC File Offset: 0x004998FC
		public int id { get; set; }

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06011592 RID: 71058 RVA: 0x0049B705 File Offset: 0x00499905
		// (set) Token: 0x06011593 RID: 71059 RVA: 0x0049B70D File Offset: 0x0049990D
		public int magicDef { get; set; }

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06011594 RID: 71060 RVA: 0x0049B716 File Offset: 0x00499916
		// (set) Token: 0x06011595 RID: 71061 RVA: 0x0049B71E File Offset: 0x0049991E
		public int physicsDef { get; set; }

		// Token: 0x06011596 RID: 71062 RVA: 0x0049B727 File Offset: 0x00499927
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.magicDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.physicsDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
