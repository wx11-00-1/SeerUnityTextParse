using System;

namespace core.config.itemFilter
{
	// Token: 0x02002021 RID: 8225
	public class IBlood
	{
		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600FB0D RID: 64269 RVA: 0x004004BC File Offset: 0x003FE6BC
		// (set) Token: 0x0600FB0E RID: 64270 RVA: 0x004004C4 File Offset: 0x003FE6C4
		public IPeakJihad GoblinKing { get; set; }

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600FB0F RID: 64271 RVA: 0x004004CD File Offset: 0x003FE6CD
		// (set) Token: 0x0600FB10 RID: 64272 RVA: 0x004004D5 File Offset: 0x003FE6D5
		public IItemItem[] Item { get; set; }

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x0600FB11 RID: 64273 RVA: 0x004004DE File Offset: 0x003FE6DE
		// (set) Token: 0x0600FB12 RID: 64274 RVA: 0x004004E6 File Offset: 0x003FE6E6
		public IPeakJihad PeakJihad { get; set; }

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600FB13 RID: 64275 RVA: 0x004004EF File Offset: 0x003FE6EF
		// (set) Token: 0x0600FB14 RID: 64276 RVA: 0x004004F7 File Offset: 0x003FE6F7
		public IPeakJihad Status { get; set; }

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600FB15 RID: 64277 RVA: 0x00400500 File Offset: 0x003FE700
		// (set) Token: 0x0600FB16 RID: 64278 RVA: 0x00400508 File Offset: 0x003FE708
		public ITopLevel TopLevel { get; set; }

		// Token: 0x0600FB17 RID: 64279 RVA: 0x00400514 File Offset: 0x003FE714
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.GoblinKing = new IPeakJihad();
				this.GoblinKing.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Item[i] = new IItemItem();
					this.Item[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.PeakJihad = new IPeakJihad();
				this.PeakJihad.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Status = new IPeakJihad();
				this.Status.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.TopLevel = new ITopLevel();
				this.TopLevel.Parse(bytes, ref byteIndex);
			}
		}
	}
}
