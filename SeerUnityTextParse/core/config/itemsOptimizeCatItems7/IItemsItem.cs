using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems7
{
	// Token: 0x02001FE9 RID: 8169
	public class IItemsItem : ItemData
	{
		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x0600F625 RID: 63013 RVA: 0x003FBACC File Offset: 0x003F9CCC
		// (set) Token: 0x0600F626 RID: 63014 RVA: 0x003FBAD4 File Offset: 0x003F9CD4
		public string Name { get; set; }

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x0600F627 RID: 63015 RVA: 0x003FBADD File Offset: 0x003F9CDD
		// (set) Token: 0x0600F628 RID: 63016 RVA: 0x003FBAE5 File Offset: 0x003F9CE5
		public int Bean { get; set; }

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600F629 RID: 63017 RVA: 0x003FBAEE File Offset: 0x003F9CEE
		// (set) Token: 0x0600F62A RID: 63018 RVA: 0x003FBAF6 File Offset: 0x003F9CF6
		public int catID { get; set; }

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600F62B RID: 63019 RVA: 0x003FBAFF File Offset: 0x003F9CFF
		// (set) Token: 0x0600F62C RID: 63020 RVA: 0x003FBB07 File Offset: 0x003F9D07
		public int Hide { get; set; }

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x0600F62D RID: 63021 RVA: 0x003FBB10 File Offset: 0x003F9D10
		// (set) Token: 0x0600F62E RID: 63022 RVA: 0x003FBB18 File Offset: 0x003F9D18
		public int hideNum { get; set; }

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x0600F62F RID: 63023 RVA: 0x003FBB21 File Offset: 0x003F9D21
		// (set) Token: 0x0600F630 RID: 63024 RVA: 0x003FBB29 File Offset: 0x003F9D29
		public int ID { get; set; }

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x0600F631 RID: 63025 RVA: 0x003FBB32 File Offset: 0x003F9D32
		// (set) Token: 0x0600F632 RID: 63026 RVA: 0x003FBB3A File Offset: 0x003F9D3A
		public int Max { get; set; }

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600F633 RID: 63027 RVA: 0x003FBB43 File Offset: 0x003F9D43
		// (set) Token: 0x0600F634 RID: 63028 RVA: 0x003FBB4B File Offset: 0x003F9D4B
		public int purpose { get; set; }

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x0600F635 RID: 63029 RVA: 0x003FBB54 File Offset: 0x003F9D54
		// (set) Token: 0x0600F636 RID: 63030 RVA: 0x003FBB5C File Offset: 0x003F9D5C
		public int Sort { get; set; }

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600F637 RID: 63031 RVA: 0x003FBB65 File Offset: 0x003F9D65
		// (set) Token: 0x0600F638 RID: 63032 RVA: 0x003FBB6D File Offset: 0x003F9D6D
		public int wd { get; set; }

		// Token: 0x0600F639 RID: 63033 RVA: 0x003FBB78 File Offset: 0x003F9D78
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hideNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x003FBC0E File Offset: 0x003F9E0E
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x003FBC16 File Offset: 0x003F9E16
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F63C RID: 63036 RVA: 0x003FBC1E File Offset: 0x003F9E1E
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F63D RID: 63037 RVA: 0x003FBC26 File Offset: 0x003F9E26
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F63E RID: 63038 RVA: 0x003FBC2E File Offset: 0x003F9E2E
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F63F RID: 63039 RVA: 0x003FBC36 File Offset: 0x003F9E36
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F640 RID: 63040 RVA: 0x003FBC41 File Offset: 0x003F9E41
		public override int GethideNum()
		{
			return this.hideNum;
		}

		// Token: 0x0600F641 RID: 63041 RVA: 0x003FBC49 File Offset: 0x003F9E49
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F642 RID: 63042 RVA: 0x003FBC51 File Offset: 0x003F9E51
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F643 RID: 63043 RVA: 0x003FBC59 File Offset: 0x003F9E59
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
