using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems0
{
	// Token: 0x02002019 RID: 8217
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x0600F9A8 RID: 63912 RVA: 0x003FEEB4 File Offset: 0x003FD0B4
		// (set) Token: 0x0600F9A9 RID: 63913 RVA: 0x003FEEBC File Offset: 0x003FD0BC
		public string Name { get; set; }

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600F9AA RID: 63914 RVA: 0x003FEEC5 File Offset: 0x003FD0C5
		// (set) Token: 0x0600F9AB RID: 63915 RVA: 0x003FEECD File Offset: 0x003FD0CD
		public int Bean { get; set; }

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x0600F9AC RID: 63916 RVA: 0x003FEED6 File Offset: 0x003FD0D6
		// (set) Token: 0x0600F9AD RID: 63917 RVA: 0x003FEEDE File Offset: 0x003FD0DE
		public int catID { get; set; }

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x0600F9AE RID: 63918 RVA: 0x003FEEE7 File Offset: 0x003FD0E7
		// (set) Token: 0x0600F9AF RID: 63919 RVA: 0x003FEEEF File Offset: 0x003FD0EF
		public int Hide { get; set; }

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x0600F9B0 RID: 63920 RVA: 0x003FEEF8 File Offset: 0x003FD0F8
		// (set) Token: 0x0600F9B1 RID: 63921 RVA: 0x003FEF00 File Offset: 0x003FD100
		public int ID { get; set; }

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x0600F9B2 RID: 63922 RVA: 0x003FEF09 File Offset: 0x003FD109
		// (set) Token: 0x0600F9B3 RID: 63923 RVA: 0x003FEF11 File Offset: 0x003FD111
		public int LifeTime { get; set; }

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x0600F9B4 RID: 63924 RVA: 0x003FEF1A File Offset: 0x003FD11A
		// (set) Token: 0x0600F9B5 RID: 63925 RVA: 0x003FEF22 File Offset: 0x003FD122
		public int Max { get; set; }

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600F9B6 RID: 63926 RVA: 0x003FEF2B File Offset: 0x003FD12B
		// (set) Token: 0x0600F9B7 RID: 63927 RVA: 0x003FEF33 File Offset: 0x003FD133
		public int Price { get; set; }

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600F9B8 RID: 63928 RVA: 0x003FEF3C File Offset: 0x003FD13C
		// (set) Token: 0x0600F9B9 RID: 63929 RVA: 0x003FEF44 File Offset: 0x003FD144
		public int purpose { get; set; }

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x0600F9BA RID: 63930 RVA: 0x003FEF4D File Offset: 0x003FD14D
		// (set) Token: 0x0600F9BB RID: 63931 RVA: 0x003FEF55 File Offset: 0x003FD155
		public int Rarity { get; set; }

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x0600F9BC RID: 63932 RVA: 0x003FEF5E File Offset: 0x003FD15E
		// (set) Token: 0x0600F9BD RID: 63933 RVA: 0x003FEF66 File Offset: 0x003FD166
		public int Sort { get; set; }

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x0600F9BE RID: 63934 RVA: 0x003FEF6F File Offset: 0x003FD16F
		// (set) Token: 0x0600F9BF RID: 63935 RVA: 0x003FEF77 File Offset: 0x003FD177
		public int UseMax { get; set; }

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x0600F9C0 RID: 63936 RVA: 0x003FEF80 File Offset: 0x003FD180
		// (set) Token: 0x0600F9C1 RID: 63937 RVA: 0x003FEF88 File Offset: 0x003FD188
		public int wd { get; set; }

		// Token: 0x0600F9C2 RID: 63938 RVA: 0x003FEF94 File Offset: 0x003FD194
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F9C3 RID: 63939 RVA: 0x003FF051 File Offset: 0x003FD251
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F9C4 RID: 63940 RVA: 0x003FF059 File Offset: 0x003FD259
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F9C5 RID: 63941 RVA: 0x003FF061 File Offset: 0x003FD261
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F9C6 RID: 63942 RVA: 0x003FF069 File Offset: 0x003FD269
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F9C7 RID: 63943 RVA: 0x003FF071 File Offset: 0x003FD271
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F9C8 RID: 63944 RVA: 0x003FF079 File Offset: 0x003FD279
		public override bool IsHide()
		{
			return this.Hide == 1;
		}

		// Token: 0x0600F9C9 RID: 63945 RVA: 0x003FF084 File Offset: 0x003FD284
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0600F9CA RID: 63946 RVA: 0x003FF08C File Offset: 0x003FD28C
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0600F9CB RID: 63947 RVA: 0x003FF094 File Offset: 0x003FD294
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F9CC RID: 63948 RVA: 0x003FF09C File Offset: 0x003FD29C
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F9CD RID: 63949 RVA: 0x003FF0A4 File Offset: 0x003FD2A4
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F9CE RID: 63950 RVA: 0x003FF0AC File Offset: 0x003FD2AC
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F9CF RID: 63951 RVA: 0x003FF0B4 File Offset: 0x003FD2B4
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
