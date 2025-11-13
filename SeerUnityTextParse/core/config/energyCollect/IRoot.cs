using System;

namespace core.config.energyCollect
{
	// Token: 0x02002045 RID: 8261
	public class IRoot
	{
		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600FC4D RID: 64589 RVA: 0x00401BF4 File Offset: 0x003FFDF4
		// (set) Token: 0x0600FC4E RID: 64590 RVA: 0x00401BFC File Offset: 0x003FFDFC
		public IEnergyItem[] energy { get; set; }

		// Token: 0x0600FC4F RID: 64591 RVA: 0x00401C08 File Offset: 0x003FFE08
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.energy = new IEnergyItem[num];
				for (int i = 0; i < num; i++)
				{
					this.energy[i] = new IEnergyItem();
					this.energy[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
