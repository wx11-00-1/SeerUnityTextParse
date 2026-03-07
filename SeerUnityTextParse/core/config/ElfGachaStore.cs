using System;

namespace core.config
{
	// Token: 0x02001FBA RID: 8122
	public class ElfGachaStore : XlsConfigBase<ElfGachaStore, IElfGachaStoreInfo>
	{
		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x0600F32E RID: 62254 RVA: 0x004363D7 File Offset: 0x004345D7
		public override string fileName
		{
			get
			{
				return "elfGachaStore";
			}
		}

		// Token: 0x0600F32F RID: 62255 RVA: 0x004363E0 File Offset: 0x004345E0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IElfGachaStoreInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IElfGachaStoreInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F330 RID: 62256 RVA: 0x00436434 File Offset: 0x00434634
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
