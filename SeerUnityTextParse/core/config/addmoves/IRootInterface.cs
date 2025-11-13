using System;

namespace core.config.addmoves
{
	// Token: 0x02002080 RID: 8320
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x0600FE09 RID: 65033 RVA: 0x00403D96 File Offset: 0x00401F96
		public override string fileName
		{
			get
			{
				return "addmoves";
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600FE0A RID: 65034 RVA: 0x00403D9D File Offset: 0x00401F9D
		// (set) Token: 0x0600FE0B RID: 65035 RVA: 0x00403DA5 File Offset: 0x00401FA5
		public IMoves Moves { get; set; }

		// Token: 0x0600FE0C RID: 65036 RVA: 0x00403DAE File Offset: 0x00401FAE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Moves = new IMoves();
				this.Moves.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FE0D RID: 65037 RVA: 0x00403DD4 File Offset: 0x00401FD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
