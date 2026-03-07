using System;

namespace core.config
{
	// Token: 0x02001EFD RID: 7933
	public class IBagTowerPlaerExpInfo : IConfigItem
	{
		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600EADA RID: 60122 RVA: 0x0042C668 File Offset: 0x0042A868
		// (set) Token: 0x0600EADB RID: 60123 RVA: 0x0042C670 File Offset: 0x0042A870
		public int exp { get; set; }

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600EADC RID: 60124 RVA: 0x0042C679 File Offset: 0x0042A879
		// (set) Token: 0x0600EADD RID: 60125 RVA: 0x0042C681 File Offset: 0x0042A881
		public int id { get; set; }

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600EADE RID: 60126 RVA: 0x0042C68A File Offset: 0x0042A88A
		// (set) Token: 0x0600EADF RID: 60127 RVA: 0x0042C692 File Offset: 0x0042A892
		public int lv { get; set; }

		// Token: 0x0600EAE0 RID: 60128 RVA: 0x0042C69B File Offset: 0x0042A89B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
