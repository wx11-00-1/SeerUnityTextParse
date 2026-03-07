using System;

namespace core.config
{
	// Token: 0x02001F61 RID: 8033
	public class IClickfpsGameInfo : IConfigItem
	{
		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x0600EFA0 RID: 61344 RVA: 0x004320D0 File Offset: 0x004302D0
		// (set) Token: 0x0600EFA1 RID: 61345 RVA: 0x004320D8 File Offset: 0x004302D8
		public int id { get; set; }

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x0600EFA2 RID: 61346 RVA: 0x004320E1 File Offset: 0x004302E1
		// (set) Token: 0x0600EFA3 RID: 61347 RVA: 0x004320E9 File Offset: 0x004302E9
		public int num { get; set; }

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x0600EFA4 RID: 61348 RVA: 0x004320F2 File Offset: 0x004302F2
		// (set) Token: 0x0600EFA5 RID: 61349 RVA: 0x004320FA File Offset: 0x004302FA
		public int time { get; set; }

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x00432103 File Offset: 0x00430303
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
