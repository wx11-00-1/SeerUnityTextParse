using System;

namespace core.config.achievements_temp
{
	// Token: 0x0200235C RID: 9052
	public class ITypeItem
	{
		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x06011A72 RID: 72306 RVA: 0x0046E0BB File Offset: 0x0046C2BB
		// (set) Token: 0x06011A73 RID: 72307 RVA: 0x0046E0C3 File Offset: 0x0046C2C3
		public IBranchesItem[] Branches { get; set; }

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06011A74 RID: 72308 RVA: 0x0046E0CC File Offset: 0x0046C2CC
		// (set) Token: 0x06011A75 RID: 72309 RVA: 0x0046E0D4 File Offset: 0x0046C2D4
		public string Desc { get; set; }

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06011A76 RID: 72310 RVA: 0x0046E0DD File Offset: 0x0046C2DD
		// (set) Token: 0x06011A77 RID: 72311 RVA: 0x0046E0E5 File Offset: 0x0046C2E5
		public int ID { get; set; }

		// Token: 0x06011A78 RID: 72312 RVA: 0x0046E0F0 File Offset: 0x0046C2F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Branches = new IBranchesItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Branches[i] = new IBranchesItem();
					this.Branches[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
