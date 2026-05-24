using System;

namespace core.config
{
	// Token: 0x0200268A RID: 9866
	public class SkinMon : XlsConfigBase<SkinMon, ISkinMonInfo>
	{
		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x060132AA RID: 78506 RVA: 0x00520958 File Offset: 0x0051EB58
		public override string fileName
		{
			get
			{
				return "skinMon";
			}
		}

		// Token: 0x060132AB RID: 78507 RVA: 0x00520960 File Offset: 0x0051EB60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISkinMonInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISkinMonInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060132AC RID: 78508 RVA: 0x005209B4 File Offset: 0x0051EBB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
