using System;

namespace core.config.achievements
{
	// Token: 0x02002089 RID: 8329
	public class IBranchItem
	{
		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600FE4F RID: 65103 RVA: 0x00404252 File Offset: 0x00402452
		// (set) Token: 0x0600FE50 RID: 65104 RVA: 0x0040425A File Offset: 0x0040245A
		public string _text { get; set; }

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600FE51 RID: 65105 RVA: 0x00404263 File Offset: 0x00402463
		// (set) Token: 0x0600FE52 RID: 65106 RVA: 0x0040426B File Offset: 0x0040246B
		public string Desc { get; set; }

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600FE53 RID: 65107 RVA: 0x00404274 File Offset: 0x00402474
		// (set) Token: 0x0600FE54 RID: 65108 RVA: 0x0040427C File Offset: 0x0040247C
		public IRuleItem[] Rule { get; set; }

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600FE55 RID: 65109 RVA: 0x00404285 File Offset: 0x00402485
		// (set) Token: 0x0600FE56 RID: 65110 RVA: 0x0040428D File Offset: 0x0040248D
		public int ID { get; set; }

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600FE57 RID: 65111 RVA: 0x00404296 File Offset: 0x00402496
		// (set) Token: 0x0600FE58 RID: 65112 RVA: 0x0040429E File Offset: 0x0040249E
		public int isShowPro { get; set; }

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600FE59 RID: 65113 RVA: 0x004042A7 File Offset: 0x004024A7
		// (set) Token: 0x0600FE5A RID: 65114 RVA: 0x004042AF File Offset: 0x004024AF
		public int IsSingle { get; set; }

		// Token: 0x0600FE5B RID: 65115 RVA: 0x004042B8 File Offset: 0x004024B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsSingle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Rule = new IRuleItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Rule[i] = new IRuleItem();
					this.Rule[i].Parse(bytes, ref byteIndex);
				}
			}
			this._text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isShowPro = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
