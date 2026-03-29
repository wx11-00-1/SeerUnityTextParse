using System;

namespace core.config
{
	// Token: 0x02002386 RID: 9094
	public class StarmapTemp : XlsConfigBase<StarmapTemp, IStarmapTempInfo>
	{
		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0601167E RID: 71294 RVA: 0x0049C978 File Offset: 0x0049AB78
		public override string fileName
		{
			get
			{
				return "starmap_temp";
			}
		}

		// Token: 0x0601167F RID: 71295 RVA: 0x0049C980 File Offset: 0x0049AB80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStarmapTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStarmapTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011680 RID: 71296 RVA: 0x0049C9D4 File Offset: 0x0049ABD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
