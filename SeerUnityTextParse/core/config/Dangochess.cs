using System;

namespace core.config
{
	// Token: 0x02001F84 RID: 8068
	public class Dangochess : XlsConfigBase<Dangochess, IDangochessInfo>
	{
		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x0600F0EC RID: 61676 RVA: 0x004339E6 File Offset: 0x00431BE6
		public override string fileName
		{
			get
			{
				return "dangochess";
			}
		}

		// Token: 0x0600F0ED RID: 61677 RVA: 0x004339F0 File Offset: 0x00431BF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangochessInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangochessInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F0EE RID: 61678 RVA: 0x00433A44 File Offset: 0x00431C44
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
