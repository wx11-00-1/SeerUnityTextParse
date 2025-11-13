using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems23
{
	// Token: 0x02001FF9 RID: 8185
	public class IItemsItem : ItemData
	{
		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600F761 RID: 63329 RVA: 0x003FCCFC File Offset: 0x003FAEFC
		// (set) Token: 0x0600F762 RID: 63330 RVA: 0x003FCD04 File Offset: 0x003FAF04
		public string ExchangeOutCnt { get; set; }

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x0600F763 RID: 63331 RVA: 0x003FCD0D File Offset: 0x003FAF0D
		// (set) Token: 0x0600F764 RID: 63332 RVA: 0x003FCD15 File Offset: 0x003FAF15
		public string ExchangeOutId { get; set; }

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600F765 RID: 63333 RVA: 0x003FCD1E File Offset: 0x003FAF1E
		// (set) Token: 0x0600F766 RID: 63334 RVA: 0x003FCD26 File Offset: 0x003FAF26
		public string Name { get; set; }

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600F767 RID: 63335 RVA: 0x003FCD2F File Offset: 0x003FAF2F
		// (set) Token: 0x0600F768 RID: 63336 RVA: 0x003FCD37 File Offset: 0x003FAF37
		public int Bean { get; set; }

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600F769 RID: 63337 RVA: 0x003FCD40 File Offset: 0x003FAF40
		// (set) Token: 0x0600F76A RID: 63338 RVA: 0x003FCD48 File Offset: 0x003FAF48
		public int catID { get; set; }

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600F76B RID: 63339 RVA: 0x003FCD51 File Offset: 0x003FAF51
		// (set) Token: 0x0600F76C RID: 63340 RVA: 0x003FCD59 File Offset: 0x003FAF59
		public int Hide { get; set; }

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600F76D RID: 63341 RVA: 0x003FCD62 File Offset: 0x003FAF62
		// (set) Token: 0x0600F76E RID: 63342 RVA: 0x003FCD6A File Offset: 0x003FAF6A
		public int icon { get; set; }

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600F76F RID: 63343 RVA: 0x003FCD73 File Offset: 0x003FAF73
		// (set) Token: 0x0600F770 RID: 63344 RVA: 0x003FCD7B File Offset: 0x003FAF7B
		public int ID { get; set; }

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600F771 RID: 63345 RVA: 0x003FCD84 File Offset: 0x003FAF84
		// (set) Token: 0x0600F772 RID: 63346 RVA: 0x003FCD8C File Offset: 0x003FAF8C
		public int LifeTime { get; set; }

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600F773 RID: 63347 RVA: 0x003FCD95 File Offset: 0x003FAF95
		// (set) Token: 0x0600F774 RID: 63348 RVA: 0x003FCD9D File Offset: 0x003FAF9D
		public int Max { get; set; }

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x0600F775 RID: 63349 RVA: 0x003FCDA6 File Offset: 0x003FAFA6
		// (set) Token: 0x0600F776 RID: 63350 RVA: 0x003FCDAE File Offset: 0x003FAFAE
		public int purpose { get; set; }

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600F777 RID: 63351 RVA: 0x003FCDB7 File Offset: 0x003FAFB7
		// (set) Token: 0x0600F778 RID: 63352 RVA: 0x003FCDBF File Offset: 0x003FAFBF
		public int Rarity { get; set; }

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x0600F779 RID: 63353 RVA: 0x003FCDC8 File Offset: 0x003FAFC8
		// (set) Token: 0x0600F77A RID: 63354 RVA: 0x003FCDD0 File Offset: 0x003FAFD0
		public int Sort { get; set; }

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x0600F77B RID: 63355 RVA: 0x003FCDD9 File Offset: 0x003FAFD9
		// (set) Token: 0x0600F77C RID: 63356 RVA: 0x003FCDE1 File Offset: 0x003FAFE1
		public int UseMax { get; set; }

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x0600F77D RID: 63357 RVA: 0x003FCDEA File Offset: 0x003FAFEA
		// (set) Token: 0x0600F77E RID: 63358 RVA: 0x003FCDF2 File Offset: 0x003FAFF2
		public int wd { get; set; }

		// Token: 0x0600F77F RID: 63359 RVA: 0x003FCDFC File Offset: 0x003FAFFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F780 RID: 63360 RVA: 0x003FCEE1 File Offset: 0x003FB0E1
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x003FCEE9 File Offset: 0x003FB0E9
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F782 RID: 63362 RVA: 0x003FCEF1 File Offset: 0x003FB0F1
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F783 RID: 63363 RVA: 0x003FCEF9 File Offset: 0x003FB0F9
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F784 RID: 63364 RVA: 0x003FCF01 File Offset: 0x003FB101
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F785 RID: 63365 RVA: 0x003FCF09 File Offset: 0x003FB109
		public override string GetExchangeOutId()
		{
			return this.ExchangeOutId;
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x003FCF11 File Offset: 0x003FB111
		public override string GetExchangeOutCnt()
		{
			return this.ExchangeOutCnt;
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x003FCF19 File Offset: 0x003FB119
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x003FCF24 File Offset: 0x003FB124
		public override int Geticon()
		{
			return this.icon;
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x003FCF2C File Offset: 0x003FB12C
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x003FCF34 File Offset: 0x003FB134
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x003FCF3C File Offset: 0x003FB13C
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F78C RID: 63372 RVA: 0x003FCF44 File Offset: 0x003FB144
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x003FCF4C File Offset: 0x003FB14C
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x003FCF54 File Offset: 0x003FB154
		public override int GetUseMax()
		{
			return this.UseMax;
		}
	}
}
