using System;

namespace core.config.achievements_temp
{
	// Token: 0x02002358 RID: 9048
	public class IBranchItem
	{
		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x06011A40 RID: 72256 RVA: 0x0046DD3A File Offset: 0x0046BF3A
		// (set) Token: 0x06011A41 RID: 72257 RVA: 0x0046DD42 File Offset: 0x0046BF42
		public string _text { get; set; }

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x06011A42 RID: 72258 RVA: 0x0046DD4B File Offset: 0x0046BF4B
		// (set) Token: 0x06011A43 RID: 72259 RVA: 0x0046DD53 File Offset: 0x0046BF53
		public string Desc { get; set; }

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x06011A44 RID: 72260 RVA: 0x0046DD5C File Offset: 0x0046BF5C
		// (set) Token: 0x06011A45 RID: 72261 RVA: 0x0046DD64 File Offset: 0x0046BF64
		public IRuleItem[] Rule { get; set; }

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06011A46 RID: 72262 RVA: 0x0046DD6D File Offset: 0x0046BF6D
		// (set) Token: 0x06011A47 RID: 72263 RVA: 0x0046DD75 File Offset: 0x0046BF75
		public int ID { get; set; }

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06011A48 RID: 72264 RVA: 0x0046DD7E File Offset: 0x0046BF7E
		// (set) Token: 0x06011A49 RID: 72265 RVA: 0x0046DD86 File Offset: 0x0046BF86
		public int isShowPro { get; set; }

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06011A4A RID: 72266 RVA: 0x0046DD8F File Offset: 0x0046BF8F
		// (set) Token: 0x06011A4B RID: 72267 RVA: 0x0046DD97 File Offset: 0x0046BF97
		public int IsSingle { get; set; }

		// Token: 0x06011A4C RID: 72268 RVA: 0x0046DDA0 File Offset: 0x0046BFA0
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
