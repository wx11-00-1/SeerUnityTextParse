using System;

namespace core.config
{
	// Token: 0x02001D7E RID: 7550
	public class ILlrestaurantLvlInfo : IConfigItem
	{
		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x0600DD44 RID: 56644 RVA: 0x003D5558 File Offset: 0x003D3758
		// (set) Token: 0x0600DD45 RID: 56645 RVA: 0x003D5560 File Offset: 0x003D3760
		public int condition { get; set; }

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x0600DD46 RID: 56646 RVA: 0x003D5569 File Offset: 0x003D3769
		// (set) Token: 0x0600DD47 RID: 56647 RVA: 0x003D5571 File Offset: 0x003D3771
		public int id { get; set; }

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x0600DD48 RID: 56648 RVA: 0x003D557A File Offset: 0x003D377A
		// (set) Token: 0x0600DD49 RID: 56649 RVA: 0x003D5582 File Offset: 0x003D3782
		public int lvlcondition { get; set; }

		// Token: 0x0600DD4A RID: 56650 RVA: 0x003D558B File Offset: 0x003D378B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.condition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lvlcondition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
