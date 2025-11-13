using System;

namespace core.config
{
	// Token: 0x02001E1F RID: 7711
	public class Signboard : XlsConfigBase<Signboard, ISignboardInfo>
	{
		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x0600E430 RID: 58416 RVA: 0x003DE0E4 File Offset: 0x003DC2E4
		public override string fileName
		{
			get
			{
				return "Signboard";
			}
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x003DE0EC File Offset: 0x003DC2EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISignboardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISignboardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x003DE140 File Offset: 0x003DC340
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
