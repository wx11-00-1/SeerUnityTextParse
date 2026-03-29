using System;

namespace core.config.side_effect
{
	// Token: 0x020024A1 RID: 9377
	public class ISideEffects
	{
		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06012252 RID: 74322 RVA: 0x004B30A3 File Offset: 0x004B12A3
		// (set) Token: 0x06012253 RID: 74323 RVA: 0x004B30AB File Offset: 0x004B12AB
		public ISideEffectItem[] SideEffect { get; set; }

		// Token: 0x06012254 RID: 74324 RVA: 0x004B30B4 File Offset: 0x004B12B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SideEffect = new ISideEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.SideEffect[i] = new ISideEffectItem();
					this.SideEffect[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
