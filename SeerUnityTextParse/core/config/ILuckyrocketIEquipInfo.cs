using System;

namespace core.config
{
	// Token: 0x02001D86 RID: 7558
	public class ILuckyrocketIEquipInfo : IConfigItem
	{
		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600DD98 RID: 56728 RVA: 0x003D5B44 File Offset: 0x003D3D44
		// (set) Token: 0x0600DD99 RID: 56729 RVA: 0x003D5B4C File Offset: 0x003D3D4C
		public string describe { get; set; }

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600DD9A RID: 56730 RVA: 0x003D5B55 File Offset: 0x003D3D55
		// (set) Token: 0x0600DD9B RID: 56731 RVA: 0x003D5B5D File Offset: 0x003D3D5D
		public string name { get; set; }

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600DD9C RID: 56732 RVA: 0x003D5B66 File Offset: 0x003D3D66
		// (set) Token: 0x0600DD9D RID: 56733 RVA: 0x003D5B6E File Offset: 0x003D3D6E
		public string showdescribe { get; set; }

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x0600DD9E RID: 56734 RVA: 0x003D5B77 File Offset: 0x003D3D77
		// (set) Token: 0x0600DD9F RID: 56735 RVA: 0x003D5B7F File Offset: 0x003D3D7F
		public int equipicon { get; set; }

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x0600DDA0 RID: 56736 RVA: 0x003D5B88 File Offset: 0x003D3D88
		// (set) Token: 0x0600DDA1 RID: 56737 RVA: 0x003D5B90 File Offset: 0x003D3D90
		public int id { get; set; }

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x0600DDA2 RID: 56738 RVA: 0x003D5B99 File Offset: 0x003D3D99
		// (set) Token: 0x0600DDA3 RID: 56739 RVA: 0x003D5BA1 File Offset: 0x003D3DA1
		public int isopen { get; set; }

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x0600DDA4 RID: 56740 RVA: 0x003D5BAA File Offset: 0x003D3DAA
		// (set) Token: 0x0600DDA5 RID: 56741 RVA: 0x003D5BB2 File Offset: 0x003D3DB2
		public int namedescribe { get; set; }

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x0600DDA6 RID: 56742 RVA: 0x003D5BBB File Offset: 0x003D3DBB
		// (set) Token: 0x0600DDA7 RID: 56743 RVA: 0x003D5BC3 File Offset: 0x003D3DC3
		public int opentime { get; set; }

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x003D5BCC File Offset: 0x003D3DCC
		// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x003D5BD4 File Offset: 0x003D3DD4
		public int priority { get; set; }

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x003D5BDD File Offset: 0x003D3DDD
		// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x003D5BE5 File Offset: 0x003D3DE5
		public int rare { get; set; }

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600DDAC RID: 56748 RVA: 0x003D5BEE File Offset: 0x003D3DEE
		// (set) Token: 0x0600DDAD RID: 56749 RVA: 0x003D5BF6 File Offset: 0x003D3DF6
		public int unlock { get; set; }

		// Token: 0x0600DDAE RID: 56750 RVA: 0x003D5C00 File Offset: 0x003D3E00
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.equipicon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.namedescribe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showdescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
