using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems24
{
	// Token: 0x02001FF7 RID: 8183
	public class IItemsItem : ItemData
	{
		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600F741 RID: 63297 RVA: 0x003FCB20 File Offset: 0x003FAD20
		// (set) Token: 0x0600F742 RID: 63298 RVA: 0x003FCB28 File Offset: 0x003FAD28
		public string Name { get; set; }

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600F743 RID: 63299 RVA: 0x003FCB31 File Offset: 0x003FAD31
		// (set) Token: 0x0600F744 RID: 63300 RVA: 0x003FCB39 File Offset: 0x003FAD39
		public int catID { get; set; }

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600F745 RID: 63301 RVA: 0x003FCB42 File Offset: 0x003FAD42
		// (set) Token: 0x0600F746 RID: 63302 RVA: 0x003FCB4A File Offset: 0x003FAD4A
		public int Hide { get; set; }

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x0600F747 RID: 63303 RVA: 0x003FCB53 File Offset: 0x003FAD53
		// (set) Token: 0x0600F748 RID: 63304 RVA: 0x003FCB5B File Offset: 0x003FAD5B
		public int ID { get; set; }

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600F749 RID: 63305 RVA: 0x003FCB64 File Offset: 0x003FAD64
		// (set) Token: 0x0600F74A RID: 63306 RVA: 0x003FCB6C File Offset: 0x003FAD6C
		public int Max { get; set; }

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600F74B RID: 63307 RVA: 0x003FCB75 File Offset: 0x003FAD75
		// (set) Token: 0x0600F74C RID: 63308 RVA: 0x003FCB7D File Offset: 0x003FAD7D
		public int purpose { get; set; }

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600F74D RID: 63309 RVA: 0x003FCB86 File Offset: 0x003FAD86
		// (set) Token: 0x0600F74E RID: 63310 RVA: 0x003FCB8E File Offset: 0x003FAD8E
		public int Sort { get; set; }

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600F74F RID: 63311 RVA: 0x003FCB97 File Offset: 0x003FAD97
		// (set) Token: 0x0600F750 RID: 63312 RVA: 0x003FCB9F File Offset: 0x003FAD9F
		public int wd { get; set; }

		// Token: 0x0600F751 RID: 63313 RVA: 0x003FCBA8 File Offset: 0x003FADA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F752 RID: 63314 RVA: 0x003FCC24 File Offset: 0x003FAE24
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x003FCC2C File Offset: 0x003FAE2C
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x003FCC34 File Offset: 0x003FAE34
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x003FCC3C File Offset: 0x003FAE3C
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F756 RID: 63318 RVA: 0x003FCC44 File Offset: 0x003FAE44
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F757 RID: 63319 RVA: 0x003FCC4F File Offset: 0x003FAE4F
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F758 RID: 63320 RVA: 0x003FCC57 File Offset: 0x003FAE57
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600F759 RID: 63321 RVA: 0x003FCC5F File Offset: 0x003FAE5F
		public override int GetSort()
		{
			return this.Sort;
		}
	}
}
