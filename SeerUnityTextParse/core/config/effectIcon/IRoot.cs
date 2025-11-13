using System;

namespace core.config.effectIcon
{
	// Token: 0x02002058 RID: 8280
	public class IRoot
	{
		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600FCED RID: 64749 RVA: 0x00402888 File Offset: 0x00400A88
		// (set) Token: 0x0600FCEE RID: 64750 RVA: 0x00402890 File Offset: 0x00400A90
		public IEffectItem[] effect { get; set; }

		// Token: 0x0600FCEF RID: 64751 RVA: 0x0040289C File Offset: 0x00400A9C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.effect = new IEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.effect[i] = new IEffectItem();
					this.effect[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
