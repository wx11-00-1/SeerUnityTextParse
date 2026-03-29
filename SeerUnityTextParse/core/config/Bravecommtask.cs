using System;

namespace core.config
{
	// Token: 0x0200218A RID: 8586
	public class Bravecommtask : XlsConfigBase<Bravecommtask, IBravecommtaskInfo>
	{
		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x0601004A RID: 65610 RVA: 0x004815F2 File Offset: 0x0047F7F2
		public override string fileName
		{
			get
			{
				return "Bravecommtask";
			}
		}

		// Token: 0x0601004B RID: 65611 RVA: 0x004815FC File Offset: 0x0047F7FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBravecommtaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBravecommtaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601004C RID: 65612 RVA: 0x00481650 File Offset: 0x0047F850
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
