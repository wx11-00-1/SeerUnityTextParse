using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems15
{
	// Token: 0x0200200B RID: 8203
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x0600F870 RID: 63600 RVA: 0x003FDD34 File Offset: 0x003FBF34
		// (set) Token: 0x0600F871 RID: 63601 RVA: 0x003FDD3C File Offset: 0x003FBF3C
		public string Name { get; set; }

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600F872 RID: 63602 RVA: 0x003FDD45 File Offset: 0x003FBF45
		// (set) Token: 0x0600F873 RID: 63603 RVA: 0x003FDD4D File Offset: 0x003FBF4D
		public int Bean { get; set; }

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600F874 RID: 63604 RVA: 0x003FDD56 File Offset: 0x003FBF56
		// (set) Token: 0x0600F875 RID: 63605 RVA: 0x003FDD5E File Offset: 0x003FBF5E
		public int catID { get; set; }

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600F876 RID: 63606 RVA: 0x003FDD67 File Offset: 0x003FBF67
		// (set) Token: 0x0600F877 RID: 63607 RVA: 0x003FDD6F File Offset: 0x003FBF6F
		public int Hide { get; set; }

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600F878 RID: 63608 RVA: 0x003FDD78 File Offset: 0x003FBF78
		// (set) Token: 0x0600F879 RID: 63609 RVA: 0x003FDD80 File Offset: 0x003FBF80
		public int ID { get; set; }

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600F87A RID: 63610 RVA: 0x003FDD89 File Offset: 0x003FBF89
		// (set) Token: 0x0600F87B RID: 63611 RVA: 0x003FDD91 File Offset: 0x003FBF91
		public int Max { get; set; }

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600F87C RID: 63612 RVA: 0x003FDD9A File Offset: 0x003FBF9A
		// (set) Token: 0x0600F87D RID: 63613 RVA: 0x003FDDA2 File Offset: 0x003FBFA2
		public int purpose { get; set; }

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x0600F87E RID: 63614 RVA: 0x003FDDAB File Offset: 0x003FBFAB
		// (set) Token: 0x0600F87F RID: 63615 RVA: 0x003FDDB3 File Offset: 0x003FBFB3
		public int Sort { get; set; }

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x0600F880 RID: 63616 RVA: 0x003FDDBC File Offset: 0x003FBFBC
		// (set) Token: 0x0600F881 RID: 63617 RVA: 0x003FDDC4 File Offset: 0x003FBFC4
		public int UseMax { get; set; }

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x0600F882 RID: 63618 RVA: 0x003FDDCD File Offset: 0x003FBFCD
		// (set) Token: 0x0600F883 RID: 63619 RVA: 0x003FDDD5 File Offset: 0x003FBFD5
		public int wd { get; set; }

		// Token: 0x0600F884 RID: 63620 RVA: 0x003FDDE0 File Offset: 0x003FBFE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x003FDE76 File Offset: 0x003FC076
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F886 RID: 63622 RVA: 0x003FDE7E File Offset: 0x003FC07E
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F887 RID: 63623 RVA: 0x003FDE86 File Offset: 0x003FC086
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x003FDE8E File Offset: 0x003FC08E
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F889 RID: 63625 RVA: 0x003FDE96 File Offset: 0x003FC096
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F88A RID: 63626 RVA: 0x003FDE9E File Offset: 0x003FC09E
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F88B RID: 63627 RVA: 0x003FDEA9 File Offset: 0x003FC0A9
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F88C RID: 63628 RVA: 0x003FDEB1 File Offset: 0x003FC0B1
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F88D RID: 63629 RVA: 0x003FDEB9 File Offset: 0x003FC0B9
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x003FDEC1 File Offset: 0x003FC0C1
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
