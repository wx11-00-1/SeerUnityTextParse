using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EE0 RID: 7904
	public class itemsOptimizeCatItem24Def : ItemData
	{
		// Token: 0x0600EC99 RID: 60569 RVA: 0x003F04ED File Offset: 0x003EE6ED
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC9A RID: 60570 RVA: 0x003F04F5 File Offset: 0x003EE6F5
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC9B RID: 60571 RVA: 0x003F04FD File Offset: 0x003EE6FD
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC9C RID: 60572 RVA: 0x003F0505 File Offset: 0x003EE705
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC9D RID: 60573 RVA: 0x003F050D File Offset: 0x003EE70D
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC9E RID: 60574 RVA: 0x003F0518 File Offset: 0x003EE718
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC9F RID: 60575 RVA: 0x003F0520 File Offset: 0x003EE720
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600ECA0 RID: 60576 RVA: 0x003F0528 File Offset: 0x003EE728
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x003F0530 File Offset: 0x003EE730
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EFEB RID: 61419
		public int catID;

		// Token: 0x0400EFEC RID: 61420
		public int ID;

		// Token: 0x0400EFED RID: 61421
		public string Name;

		// Token: 0x0400EFEE RID: 61422
		public int Max;

		// Token: 0x0400EFEF RID: 61423
		public int Hide;

		// Token: 0x0400EFF0 RID: 61424
		public int purpose;

		// Token: 0x0400EFF1 RID: 61425
		public int wd;

		// Token: 0x0400EFF2 RID: 61426
		public int Sort;
	}
}
