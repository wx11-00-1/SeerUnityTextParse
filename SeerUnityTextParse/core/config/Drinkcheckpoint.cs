using System;

namespace core.config
{
	// Token: 0x02001D35 RID: 7477
	public class Drinkcheckpoint : XlsConfigBase<Drinkcheckpoint, IDrinkcheckpointInfo>
	{
		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x003D1B90 File Offset: 0x003CFD90
		public override string fileName
		{
			get
			{
				return "drinkcheckpoint";
			}
		}

		// Token: 0x0600DA71 RID: 55921 RVA: 0x003D1B98 File Offset: 0x003CFD98
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDrinkcheckpointInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDrinkcheckpointInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA72 RID: 55922 RVA: 0x003D1BEC File Offset: 0x003CFDEC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
