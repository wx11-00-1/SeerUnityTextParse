using System;

namespace core.config
{
	// Token: 0x02001E71 RID: 7793
	public class Suitsale : XlsConfigBase<Suitsale, ISuitsaleInfo>
	{
		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x0600E7DA RID: 59354 RVA: 0x003E28B5 File Offset: 0x003E0AB5
		public override string fileName
		{
			get
			{
				return "suitsale";
			}
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x003E28BC File Offset: 0x003E0ABC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISuitsaleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISuitsaleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E7DC RID: 59356 RVA: 0x003E2910 File Offset: 0x003E0B10
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
