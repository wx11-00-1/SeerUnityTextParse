using System;

namespace core.config
{
	// Token: 0x02001D47 RID: 7495
	public class ExpressJump : XlsConfigBase<ExpressJump, IExpressJumpInfo>
	{
		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600DB3C RID: 56124 RVA: 0x003D2A28 File Offset: 0x003D0C28
		public override string fileName
		{
			get
			{
				return "express_jump";
			}
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x003D2A30 File Offset: 0x003D0C30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IExpressJumpInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IExpressJumpInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x003D2A84 File Offset: 0x003D0C84
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
