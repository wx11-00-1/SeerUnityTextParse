using System;

namespace core.config
{
	// Token: 0x02001D5B RID: 7515
	public class GlobalNumber : XlsConfigBase<GlobalNumber, IGlobalNumberInfo>
	{
		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x0600DC16 RID: 56342 RVA: 0x003D3D3E File Offset: 0x003D1F3E
		public override string fileName
		{
			get
			{
				return "globalNumber";
			}
		}

		// Token: 0x0600DC17 RID: 56343 RVA: 0x003D3D48 File Offset: 0x003D1F48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IGlobalNumberInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IGlobalNumberInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC18 RID: 56344 RVA: 0x003D3D9C File Offset: 0x003D1F9C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
