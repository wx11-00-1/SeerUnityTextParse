using System;

namespace core.config
{
	// Token: 0x02001DBF RID: 7615
	public class PetItem : XlsConfigBase<PetItem, IPetItemInfo>
	{
		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600E020 RID: 57376 RVA: 0x003D8E42 File Offset: 0x003D7042
		public override string fileName
		{
			get
			{
				return "pet_item";
			}
		}

		// Token: 0x0600E021 RID: 57377 RVA: 0x003D8E4C File Offset: 0x003D704C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPetItemInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPetItemInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E022 RID: 57378 RVA: 0x003D8EA0 File Offset: 0x003D70A0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
