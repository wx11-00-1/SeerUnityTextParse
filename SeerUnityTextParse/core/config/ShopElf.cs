using System;

namespace core.config
{
	// Token: 0x02001E19 RID: 7705
	public class ShopElf : XlsConfigBase<ShopElf, IShopElfInfo>
	{
		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x0600E3D4 RID: 58324 RVA: 0x003DD97D File Offset: 0x003DBB7D
		public override string fileName
		{
			get
			{
				return "shop_elf";
			}
		}

		// Token: 0x0600E3D5 RID: 58325 RVA: 0x003DD984 File Offset: 0x003DBB84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopElfInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopElfInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x003DD9D8 File Offset: 0x003DBBD8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
