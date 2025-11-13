using System;

namespace core.config.Attireconversion
{
	// Token: 0x02002073 RID: 8307
	public class IAttireconversions
	{
		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x0600FDAF RID: 64943 RVA: 0x00403628 File Offset: 0x00401828
		// (set) Token: 0x0600FDB0 RID: 64944 RVA: 0x00403630 File Offset: 0x00401830
		public IAttireconversionItem[] Attireconversion { get; set; }

		// Token: 0x0600FDB1 RID: 64945 RVA: 0x0040363C File Offset: 0x0040183C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Attireconversion = new IAttireconversionItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Attireconversion[i] = new IAttireconversionItem();
					this.Attireconversion[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
