using System;

namespace core.config
{
	// Token: 0x02002184 RID: 8580
	public class Bottlebonus : XlsConfigBase<Bottlebonus, IBottlebonusInfo>
	{
		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x0601000C RID: 65548 RVA: 0x00481184 File Offset: 0x0047F384
		public override string fileName
		{
			get
			{
				return "bottlebonus";
			}
		}

		// Token: 0x0601000D RID: 65549 RVA: 0x0048118C File Offset: 0x0047F38C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBottlebonusInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBottlebonusInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601000E RID: 65550 RVA: 0x004811E0 File Offset: 0x0047F3E0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
