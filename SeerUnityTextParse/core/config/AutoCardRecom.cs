using System;

namespace core.config
{
	// Token: 0x0200213A RID: 8506
	public class AutoCardRecom : XlsConfigBase<AutoCardRecom, IAutoCardRecomInfo>
	{
		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600FCB8 RID: 64696 RVA: 0x0047D33D File Offset: 0x0047B53D
		public override string fileName
		{
			get
			{
				return "autoCardRecom";
			}
		}

		// Token: 0x0600FCB9 RID: 64697 RVA: 0x0047D344 File Offset: 0x0047B544
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutoCardRecomInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutoCardRecomInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FCBA RID: 64698 RVA: 0x0047D398 File Offset: 0x0047B598
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
