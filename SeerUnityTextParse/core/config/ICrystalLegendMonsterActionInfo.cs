using System;

namespace core.config
{
	// Token: 0x02001D18 RID: 7448
	public class ICrystalLegendMonsterActionInfo : IConfigItem
	{
		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600D974 RID: 55668 RVA: 0x003D08BC File Offset: 0x003CEABC
		// (set) Token: 0x0600D975 RID: 55669 RVA: 0x003D08C4 File Offset: 0x003CEAC4
		public int grow { get; set; }

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x0600D976 RID: 55670 RVA: 0x003D08CD File Offset: 0x003CEACD
		// (set) Token: 0x0600D977 RID: 55671 RVA: 0x003D08D5 File Offset: 0x003CEAD5
		public int id { get; set; }

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x0600D978 RID: 55672 RVA: 0x003D08DE File Offset: 0x003CEADE
		// (set) Token: 0x0600D979 RID: 55673 RVA: 0x003D08E6 File Offset: 0x003CEAE6
		public int multiAttack { get; set; }

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x003D08EF File Offset: 0x003CEAEF
		// (set) Token: 0x0600D97B RID: 55675 RVA: 0x003D08F7 File Offset: 0x003CEAF7
		public int power { get; set; }

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x0600D97C RID: 55676 RVA: 0x003D0900 File Offset: 0x003CEB00
		// (set) Token: 0x0600D97D RID: 55677 RVA: 0x003D0908 File Offset: 0x003CEB08
		public int shield { get; set; }

		// Token: 0x0600D97E RID: 55678 RVA: 0x003D0914 File Offset: 0x003CEB14
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.grow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.multiAttack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.shield = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
