using System;

namespace core.config
{
	// Token: 0x02001C9F RID: 7327
	public class AnniversaryVault : XlsConfigBase<AnniversaryVault, IAnniversaryVaultInfo>
	{
		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x0600D436 RID: 54326 RVA: 0x003CA3DD File Offset: 0x003C85DD
		public override string fileName
		{
			get
			{
				return "AnniversaryVault";
			}
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x003CA3E4 File Offset: 0x003C85E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAnniversaryVaultInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAnniversaryVaultInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x003CA438 File Offset: 0x003C8638
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
