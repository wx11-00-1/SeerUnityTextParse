using System;

namespace core.config
{
	// Token: 0x0200271A RID: 10010
	public class MysteryBoxGameItem : XlsConfigBase<MysteryBoxGameItem, IMysteryBoxGameItemInfo>
	{
		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06013BEB RID: 80875 RVA: 0x0055C7FE File Offset: 0x0055A9FE
		public override string fileName
		{
			get
			{
				return "mysteryBoxGameItem";
			}
		}

		// Token: 0x06013BEC RID: 80876 RVA: 0x0055C808 File Offset: 0x0055AA08
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMysteryBoxGameItemInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMysteryBoxGameItemInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013BED RID: 80877 RVA: 0x0055C85C File Offset: 0x0055AA5C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
