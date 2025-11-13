using System;

namespace core.config.awakendetail
{
	// Token: 0x0200206A RID: 8298
	public class IRace
	{
		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x0600FD6D RID: 64877 RVA: 0x00403173 File Offset: 0x00401373
		// (set) Token: 0x0600FD6E RID: 64878 RVA: 0x0040317B File Offset: 0x0040137B
		public int[] NewRace { get; set; }

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x0600FD6F RID: 64879 RVA: 0x00403184 File Offset: 0x00401384
		// (set) Token: 0x0600FD70 RID: 64880 RVA: 0x0040318C File Offset: 0x0040138C
		public int[] OldRace { get; set; }

		// Token: 0x0600FD71 RID: 64881 RVA: 0x00403198 File Offset: 0x00401398
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NewRace = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.NewRace[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.OldRace = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.OldRace[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
