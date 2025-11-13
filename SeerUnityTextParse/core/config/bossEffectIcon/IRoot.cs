using System;

namespace core.config.bossEffectIcon
{
	// Token: 0x02002061 RID: 8289
	public class IRoot
	{
		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x0600FD33 RID: 64819 RVA: 0x00402D59 File Offset: 0x00400F59
		// (set) Token: 0x0600FD34 RID: 64820 RVA: 0x00402D61 File Offset: 0x00400F61
		public IBossEffectItem[] bossEffect { get; set; }

		// Token: 0x0600FD35 RID: 64821 RVA: 0x00402D6C File Offset: 0x00400F6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.bossEffect = new IBossEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.bossEffect[i] = new IBossEffectItem();
					this.bossEffect[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
