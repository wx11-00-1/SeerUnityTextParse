using System;

namespace core.config
{
	// Token: 0x0200268C RID: 9868
	public class SkinStorePool : XlsConfigBase<SkinStorePool, ISkinStorePoolInfo>
	{
		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x060132CC RID: 78540 RVA: 0x00520BE5 File Offset: 0x0051EDE5
		public override string fileName
		{
			get
			{
				return "skinStorePool";
			}
		}

		// Token: 0x060132CD RID: 78541 RVA: 0x00520BEC File Offset: 0x0051EDEC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISkinStorePoolInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISkinStorePoolInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060132CE RID: 78542 RVA: 0x00520C40 File Offset: 0x0051EE40
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
