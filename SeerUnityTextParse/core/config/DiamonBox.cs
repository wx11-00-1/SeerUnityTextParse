using System;

namespace core.config
{
	// Token: 0x02002218 RID: 8728
	public class DiamonBox : XlsConfigBase<DiamonBox, IDiamonBoxInfo>
	{
		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x060106A2 RID: 67234 RVA: 0x00488ECA File Offset: 0x004870CA
		public override string fileName
		{
			get
			{
				return "diamon_box";
			}
		}

		// Token: 0x060106A3 RID: 67235 RVA: 0x00488ED4 File Offset: 0x004870D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDiamonBoxInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDiamonBoxInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060106A4 RID: 67236 RVA: 0x00488F28 File Offset: 0x00487128
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
