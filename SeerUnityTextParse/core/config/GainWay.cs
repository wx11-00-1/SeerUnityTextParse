using System;

namespace core.config
{
	// Token: 0x0200225E RID: 8798
	public class GainWay : XlsConfigBase<GainWay, IGainWayInfo>
	{
		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x060109AA RID: 68010 RVA: 0x0048C9EA File Offset: 0x0048ABEA
		public override string fileName
		{
			get
			{
				return "gainWay";
			}
		}

		// Token: 0x060109AB RID: 68011 RVA: 0x0048C9F4 File Offset: 0x0048ABF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IGainWayInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IGainWayInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060109AC RID: 68012 RVA: 0x0048CA48 File Offset: 0x0048AC48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
