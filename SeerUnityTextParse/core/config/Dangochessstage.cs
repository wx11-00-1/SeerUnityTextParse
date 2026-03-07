using System;

namespace core.config
{
	// Token: 0x02001F86 RID: 8070
	public class Dangochessstage : XlsConfigBase<Dangochessstage, IDangochessstageInfo>
	{
		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600F102 RID: 61698 RVA: 0x00433B85 File Offset: 0x00431D85
		public override string fileName
		{
			get
			{
				return "dangochessstage";
			}
		}

		// Token: 0x0600F103 RID: 61699 RVA: 0x00433B8C File Offset: 0x00431D8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangochessstageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangochessstageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F104 RID: 61700 RVA: 0x00433BE0 File Offset: 0x00431DE0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
