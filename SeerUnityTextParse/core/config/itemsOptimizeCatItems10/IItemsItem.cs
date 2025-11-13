using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems10
{
	// Token: 0x02002015 RID: 8213
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x0600F944 RID: 63812 RVA: 0x003FE920 File Offset: 0x003FCB20
		// (set) Token: 0x0600F945 RID: 63813 RVA: 0x003FE928 File Offset: 0x003FCB28
		public string Name { get; set; }

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600F946 RID: 63814 RVA: 0x003FE931 File Offset: 0x003FCB31
		// (set) Token: 0x0600F947 RID: 63815 RVA: 0x003FE939 File Offset: 0x003FCB39
		public int Bean { get; set; }

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x0600F948 RID: 63816 RVA: 0x003FE942 File Offset: 0x003FCB42
		// (set) Token: 0x0600F949 RID: 63817 RVA: 0x003FE94A File Offset: 0x003FCB4A
		public int catID { get; set; }

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600F94A RID: 63818 RVA: 0x003FE953 File Offset: 0x003FCB53
		// (set) Token: 0x0600F94B RID: 63819 RVA: 0x003FE95B File Offset: 0x003FCB5B
		public int Hide { get; set; }

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600F94C RID: 63820 RVA: 0x003FE964 File Offset: 0x003FCB64
		// (set) Token: 0x0600F94D RID: 63821 RVA: 0x003FE96C File Offset: 0x003FCB6C
		public int ID { get; set; }

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600F94E RID: 63822 RVA: 0x003FE975 File Offset: 0x003FCB75
		// (set) Token: 0x0600F94F RID: 63823 RVA: 0x003FE97D File Offset: 0x003FCB7D
		public int Max { get; set; }

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x0600F950 RID: 63824 RVA: 0x003FE986 File Offset: 0x003FCB86
		// (set) Token: 0x0600F951 RID: 63825 RVA: 0x003FE98E File Offset: 0x003FCB8E
		public int purpose { get; set; }

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600F952 RID: 63826 RVA: 0x003FE997 File Offset: 0x003FCB97
		// (set) Token: 0x0600F953 RID: 63827 RVA: 0x003FE99F File Offset: 0x003FCB9F
		public int Sort { get; set; }

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600F954 RID: 63828 RVA: 0x003FE9A8 File Offset: 0x003FCBA8
		// (set) Token: 0x0600F955 RID: 63829 RVA: 0x003FE9B0 File Offset: 0x003FCBB0
		public int UseMax { get; set; }

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x0600F956 RID: 63830 RVA: 0x003FE9B9 File Offset: 0x003FCBB9
		// (set) Token: 0x0600F957 RID: 63831 RVA: 0x003FE9C1 File Offset: 0x003FCBC1
		public int wd { get; set; }

		// Token: 0x0600F958 RID: 63832 RVA: 0x003FE9CC File Offset: 0x003FCBCC
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

		// Token: 0x0600F959 RID: 63833 RVA: 0x003FEA62 File Offset: 0x003FCC62
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F95A RID: 63834 RVA: 0x003FEA6A File Offset: 0x003FCC6A
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F95B RID: 63835 RVA: 0x003FEA72 File Offset: 0x003FCC72
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F95C RID: 63836 RVA: 0x003FEA7A File Offset: 0x003FCC7A
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F95D RID: 63837 RVA: 0x003FEA82 File Offset: 0x003FCC82
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F95E RID: 63838 RVA: 0x003FEA8A File Offset: 0x003FCC8A
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F95F RID: 63839 RVA: 0x003FEA95 File Offset: 0x003FCC95
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x003FEA9D File Offset: 0x003FCC9D
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x003FEAA5 File Offset: 0x003FCCA5
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x003FEAAD File Offset: 0x003FCCAD
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
