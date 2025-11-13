using System;

namespace core.config.achievements
{
	// Token: 0x0200208C RID: 8332
	public class ITypeItem
	{
		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600FE67 RID: 65127 RVA: 0x0040442C File Offset: 0x0040262C
		// (set) Token: 0x0600FE68 RID: 65128 RVA: 0x00404434 File Offset: 0x00402634
		public IBranchesItem[] Branches { get; set; }

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x0600FE69 RID: 65129 RVA: 0x0040443D File Offset: 0x0040263D
		// (set) Token: 0x0600FE6A RID: 65130 RVA: 0x00404445 File Offset: 0x00402645
		public string Desc { get; set; }

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x0600FE6B RID: 65131 RVA: 0x0040444E File Offset: 0x0040264E
		// (set) Token: 0x0600FE6C RID: 65132 RVA: 0x00404456 File Offset: 0x00402656
		public int ID { get; set; }

		// Token: 0x0600FE6D RID: 65133 RVA: 0x00404460 File Offset: 0x00402660
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Branches = new IBranchesItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Branches[i] = new IBranchesItem();
					this.Branches[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
