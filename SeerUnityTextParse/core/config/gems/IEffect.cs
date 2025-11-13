using System;

namespace core.config.gems
{
	// Token: 0x0200202B RID: 8235
	public class IEffect
	{
		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600FB71 RID: 64369 RVA: 0x00400C44 File Offset: 0x003FEE44
		// (set) Token: 0x0600FB72 RID: 64370 RVA: 0x00400C4C File Offset: 0x003FEE4C
		public int[] Param { get; set; }

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x0600FB73 RID: 64371 RVA: 0x00400C55 File Offset: 0x003FEE55
		// (set) Token: 0x0600FB74 RID: 64372 RVA: 0x00400C5D File Offset: 0x003FEE5D
		public int EffectId { get; set; }

		// Token: 0x0600FB75 RID: 64373 RVA: 0x00400C68 File Offset: 0x003FEE68
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.EffectId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Param = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.Param[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
