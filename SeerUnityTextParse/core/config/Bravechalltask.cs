using System;

namespace core.config
{
	// Token: 0x02002188 RID: 8584
	public class Bravechalltask : XlsConfigBase<Bravechalltask, IBravechalltaskInfo>
	{
		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0601002E RID: 65582 RVA: 0x004813EB File Offset: 0x0047F5EB
		public override string fileName
		{
			get
			{
				return "Bravechalltask";
			}
		}

		// Token: 0x0601002F RID: 65583 RVA: 0x004813F4 File Offset: 0x0047F5F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBravechalltaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBravechalltaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010030 RID: 65584 RVA: 0x00481448 File Offset: 0x0047F648
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
