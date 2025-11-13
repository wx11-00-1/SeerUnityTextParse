using System;

namespace core.config.figure_reward
{
	// Token: 0x02002037 RID: 8247
	public class IItemItem
	{
		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600FBD7 RID: 64471 RVA: 0x0040131E File Offset: 0x003FF51E
		// (set) Token: 0x0600FBD8 RID: 64472 RVA: 0x00401326 File Offset: 0x003FF526
		public int Count { get; set; }

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x0600FBD9 RID: 64473 RVA: 0x0040132F File Offset: 0x003FF52F
		// (set) Token: 0x0600FBDA RID: 64474 RVA: 0x00401337 File Offset: 0x003FF537
		public int ID { get; set; }

		// Token: 0x0600FBDB RID: 64475 RVA: 0x00401340 File Offset: 0x003FF540
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
