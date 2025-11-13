using System;

namespace core.config
{
	// Token: 0x02001D59 RID: 7513
	public class Furniture : XlsConfigBase<Furniture, IFurnitureInfo>
	{
		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600DC02 RID: 56322 RVA: 0x003D3BCD File Offset: 0x003D1DCD
		public override string fileName
		{
			get
			{
				return "furniture";
			}
		}

		// Token: 0x0600DC03 RID: 56323 RVA: 0x003D3BD4 File Offset: 0x003D1DD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFurnitureInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFurnitureInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x003D3C28 File Offset: 0x003D1E28
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
