using System;

namespace core.config
{
	// Token: 0x02001DF7 RID: 7671
	public class Retrieve : XlsConfigBase<Retrieve, IRetrieveInfo>
	{
		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x0600E27C RID: 57980 RVA: 0x003DBB82 File Offset: 0x003D9D82
		public override string fileName
		{
			get
			{
				return "retrieve";
			}
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x003DBB8C File Offset: 0x003D9D8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRetrieveInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRetrieveInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E27E RID: 57982 RVA: 0x003DBBE0 File Offset: 0x003D9DE0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
