using System;

namespace core.config
{
	// Token: 0x02002150 RID: 8528
	public class Awakenlevel : XlsConfigBase<Awakenlevel, IAwakenlevelInfo>
	{
		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600FD94 RID: 64916 RVA: 0x0047E35F File Offset: 0x0047C55F
		public override string fileName
		{
			get
			{
				return "awakenlevel";
			}
		}

		// Token: 0x0600FD95 RID: 64917 RVA: 0x0047E368 File Offset: 0x0047C568
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakenlevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakenlevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FD96 RID: 64918 RVA: 0x0047E3BC File Offset: 0x0047C5BC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
