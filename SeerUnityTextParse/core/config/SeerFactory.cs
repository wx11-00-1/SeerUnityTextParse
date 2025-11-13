using System;

namespace core.config
{
	// Token: 0x02001E11 RID: 7697
	public class SeerFactory : XlsConfigBase<SeerFactory, ISeerFactoryInfo>
	{
		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600E372 RID: 58226 RVA: 0x003DD161 File Offset: 0x003DB361
		public override string fileName
		{
			get
			{
				return "seerFactory";
			}
		}

		// Token: 0x0600E373 RID: 58227 RVA: 0x003DD168 File Offset: 0x003DB368
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISeerFactoryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISeerFactoryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x003DD1BC File Offset: 0x003DB3BC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
