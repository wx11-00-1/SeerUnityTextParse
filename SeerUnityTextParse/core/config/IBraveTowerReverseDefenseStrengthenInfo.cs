using System;

namespace core.config
{
	// Token: 0x02001CD4 RID: 7380
	public class IBraveTowerReverseDefenseStrengthenInfo : IConfigItem
	{
		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x0600D644 RID: 54852 RVA: 0x003CCAF0 File Offset: 0x003CACF0
		// (set) Token: 0x0600D645 RID: 54853 RVA: 0x003CCAF8 File Offset: 0x003CACF8
		public string name { get; set; }

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x0600D646 RID: 54854 RVA: 0x003CCB01 File Offset: 0x003CAD01
		// (set) Token: 0x0600D647 RID: 54855 RVA: 0x003CCB09 File Offset: 0x003CAD09
		public int cost { get; set; }

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x0600D648 RID: 54856 RVA: 0x003CCB12 File Offset: 0x003CAD12
		// (set) Token: 0x0600D649 RID: 54857 RVA: 0x003CCB1A File Offset: 0x003CAD1A
		public int des { get; set; }

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x0600D64A RID: 54858 RVA: 0x003CCB23 File Offset: 0x003CAD23
		// (set) Token: 0x0600D64B RID: 54859 RVA: 0x003CCB2B File Offset: 0x003CAD2B
		public int id { get; set; }

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x0600D64C RID: 54860 RVA: 0x003CCB34 File Offset: 0x003CAD34
		// (set) Token: 0x0600D64D RID: 54861 RVA: 0x003CCB3C File Offset: 0x003CAD3C
		public int level { get; set; }

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x0600D64E RID: 54862 RVA: 0x003CCB45 File Offset: 0x003CAD45
		// (set) Token: 0x0600D64F RID: 54863 RVA: 0x003CCB4D File Offset: 0x003CAD4D
		public int type { get; set; }

		// Token: 0x0600D650 RID: 54864 RVA: 0x003CCB58 File Offset: 0x003CAD58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
