using System;

namespace core.config.effectInfo
{
	// Token: 0x02002055 RID: 8277
	public class IRoot
	{
		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600FCBD RID: 64701 RVA: 0x00402440 File Offset: 0x00400640
		// (set) Token: 0x0600FCBE RID: 64702 RVA: 0x00402448 File Offset: 0x00400648
		public IEffectItem[] Effect { get; set; }

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600FCBF RID: 64703 RVA: 0x00402451 File Offset: 0x00400651
		// (set) Token: 0x0600FCC0 RID: 64704 RVA: 0x00402459 File Offset: 0x00400659
		public IParamTypeItem[] ParamType { get; set; }

		// Token: 0x0600FCC1 RID: 64705 RVA: 0x00402464 File Offset: 0x00400664
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Effect = new IEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Effect[i] = new IEffectItem();
					this.Effect[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ParamType = new IParamTypeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.ParamType[j] = new IParamTypeItem();
					this.ParamType[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
