using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems5
{
	// Token: 0x02001FED RID: 8173
	public class IItemsItem : ItemData
	{
		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x0600F662 RID: 63074 RVA: 0x003FBE64 File Offset: 0x003FA064
		// (set) Token: 0x0600F663 RID: 63075 RVA: 0x003FBE6C File Offset: 0x003FA06C
		public string Name { get; set; }

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x0600F664 RID: 63076 RVA: 0x003FBE75 File Offset: 0x003FA075
		// (set) Token: 0x0600F665 RID: 63077 RVA: 0x003FBE7D File Offset: 0x003FA07D
		public int Bean { get; set; }

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600F666 RID: 63078 RVA: 0x003FBE86 File Offset: 0x003FA086
		// (set) Token: 0x0600F667 RID: 63079 RVA: 0x003FBE8E File Offset: 0x003FA08E
		public int catID { get; set; }

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600F668 RID: 63080 RVA: 0x003FBE97 File Offset: 0x003FA097
		// (set) Token: 0x0600F669 RID: 63081 RVA: 0x003FBE9F File Offset: 0x003FA09F
		public int Hide { get; set; }

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600F66A RID: 63082 RVA: 0x003FBEA8 File Offset: 0x003FA0A8
		// (set) Token: 0x0600F66B RID: 63083 RVA: 0x003FBEB0 File Offset: 0x003FA0B0
		public int ID { get; set; }

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x0600F66C RID: 63084 RVA: 0x003FBEB9 File Offset: 0x003FA0B9
		// (set) Token: 0x0600F66D RID: 63085 RVA: 0x003FBEC1 File Offset: 0x003FA0C1
		public int Max { get; set; }

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600F66E RID: 63086 RVA: 0x003FBECA File Offset: 0x003FA0CA
		// (set) Token: 0x0600F66F RID: 63087 RVA: 0x003FBED2 File Offset: 0x003FA0D2
		public int Price { get; set; }

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x0600F670 RID: 63088 RVA: 0x003FBEDB File Offset: 0x003FA0DB
		// (set) Token: 0x0600F671 RID: 63089 RVA: 0x003FBEE3 File Offset: 0x003FA0E3
		public int purpose { get; set; }

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600F672 RID: 63090 RVA: 0x003FBEEC File Offset: 0x003FA0EC
		// (set) Token: 0x0600F673 RID: 63091 RVA: 0x003FBEF4 File Offset: 0x003FA0F4
		public int Sort { get; set; }

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x0600F674 RID: 63092 RVA: 0x003FBEFD File Offset: 0x003FA0FD
		// (set) Token: 0x0600F675 RID: 63093 RVA: 0x003FBF05 File Offset: 0x003FA105
		public int VipOnly { get; set; }

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x0600F676 RID: 63094 RVA: 0x003FBF0E File Offset: 0x003FA10E
		// (set) Token: 0x0600F677 RID: 63095 RVA: 0x003FBF16 File Offset: 0x003FA116
		public int wd { get; set; }

		// Token: 0x0600F678 RID: 63096 RVA: 0x003FBF20 File Offset: 0x003FA120
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F679 RID: 63097 RVA: 0x003FBFC3 File Offset: 0x003FA1C3
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F67A RID: 63098 RVA: 0x003FBFCB File Offset: 0x003FA1CB
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F67B RID: 63099 RVA: 0x003FBFD3 File Offset: 0x003FA1D3
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F67C RID: 63100 RVA: 0x003FBFDB File Offset: 0x003FA1DB
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x003FBFE3 File Offset: 0x003FA1E3
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F67E RID: 63102 RVA: 0x003FBFEB File Offset: 0x003FA1EB
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x003FBFF6 File Offset: 0x003FA1F6
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x003FBFFE File Offset: 0x003FA1FE
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F681 RID: 63105 RVA: 0x003FC006 File Offset: 0x003FA206
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F682 RID: 63106 RVA: 0x003FC00E File Offset: 0x003FA20E
		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		// Token: 0x0600F683 RID: 63107 RVA: 0x003FC019 File Offset: 0x003FA219
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
