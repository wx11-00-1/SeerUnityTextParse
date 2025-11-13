using System;

namespace core.config
{
	// Token: 0x02001CC7 RID: 7367
	public class BitBuffer : XlsConfigBase<BitBuffer, IBitBufferInfo>
	{
		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x003CC2C9 File Offset: 0x003CA4C9
		public override string fileName
		{
			get
			{
				return "bitBuffer";
			}
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x003CC2D0 File Offset: 0x003CA4D0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBitBufferInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBitBufferInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x003CC324 File Offset: 0x003CA524
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
