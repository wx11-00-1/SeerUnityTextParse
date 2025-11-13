using System;

namespace core.config.addmoves
{
	// Token: 0x0200207F RID: 8319
	public class IMoves
	{
		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x0600FE05 RID: 65029 RVA: 0x00403D29 File Offset: 0x00401F29
		// (set) Token: 0x0600FE06 RID: 65030 RVA: 0x00403D31 File Offset: 0x00401F31
		public IMoveItem[] Move { get; set; }

		// Token: 0x0600FE07 RID: 65031 RVA: 0x00403D3C File Offset: 0x00401F3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Move = new IMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Move[i] = new IMoveItem();
					this.Move[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
