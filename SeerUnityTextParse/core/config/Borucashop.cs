using System;

namespace core.config
{
	// Token: 0x02002494 RID: 9364
	public class Borucashop : XlsConfigBase<Borucashop, IBorucashopInfo>
	{
		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06011CBA RID: 72890 RVA: 0x00505C24 File Offset: 0x00503E24
		public override string fileName
		{
			get
			{
				return "borucashop";
			}
		}

		// Token: 0x06011CBB RID: 72891 RVA: 0x00505C2C File Offset: 0x00503E2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBorucashopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBorucashopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011CBC RID: 72892 RVA: 0x00505C80 File Offset: 0x00503E80
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
