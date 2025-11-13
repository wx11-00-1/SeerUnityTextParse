using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems26
{
	// Token: 0x02001FF3 RID: 8179
	public class IItemsItem : ItemData
	{
		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600F6F8 RID: 63224 RVA: 0x003FC6F0 File Offset: 0x003FA8F0
		// (set) Token: 0x0600F6F9 RID: 63225 RVA: 0x003FC6F8 File Offset: 0x003FA8F8
		public string Name { get; set; }

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600F6FA RID: 63226 RVA: 0x003FC701 File Offset: 0x003FA901
		// (set) Token: 0x0600F6FB RID: 63227 RVA: 0x003FC709 File Offset: 0x003FA909
		public int catID { get; set; }

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x0600F6FC RID: 63228 RVA: 0x003FC712 File Offset: 0x003FA912
		// (set) Token: 0x0600F6FD RID: 63229 RVA: 0x003FC71A File Offset: 0x003FA91A
		public int ID { get; set; }

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x0600F6FE RID: 63230 RVA: 0x003FC723 File Offset: 0x003FA923
		// (set) Token: 0x0600F6FF RID: 63231 RVA: 0x003FC72B File Offset: 0x003FA92B
		public int Max { get; set; }

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x0600F700 RID: 63232 RVA: 0x003FC734 File Offset: 0x003FA934
		// (set) Token: 0x0600F701 RID: 63233 RVA: 0x003FC73C File Offset: 0x003FA93C
		public int purpose { get; set; }

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0600F702 RID: 63234 RVA: 0x003FC745 File Offset: 0x003FA945
		// (set) Token: 0x0600F703 RID: 63235 RVA: 0x003FC74D File Offset: 0x003FA94D
		public int Rarity { get; set; }

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x0600F704 RID: 63236 RVA: 0x003FC756 File Offset: 0x003FA956
		// (set) Token: 0x0600F705 RID: 63237 RVA: 0x003FC75E File Offset: 0x003FA95E
		public int Sort { get; set; }

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600F706 RID: 63238 RVA: 0x003FC767 File Offset: 0x003FA967
		// (set) Token: 0x0600F707 RID: 63239 RVA: 0x003FC76F File Offset: 0x003FA96F
		public int UseMax { get; set; }

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600F708 RID: 63240 RVA: 0x003FC778 File Offset: 0x003FA978
		// (set) Token: 0x0600F709 RID: 63241 RVA: 0x003FC780 File Offset: 0x003FA980
		public int wd { get; set; }

		// Token: 0x0600F70A RID: 63242 RVA: 0x003FC78C File Offset: 0x003FA98C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F70B RID: 63243 RVA: 0x003FC815 File Offset: 0x003FAA15
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F70C RID: 63244 RVA: 0x003FC81D File Offset: 0x003FAA1D
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F70D RID: 63245 RVA: 0x003FC825 File Offset: 0x003FAA25
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F70E RID: 63246 RVA: 0x003FC82D File Offset: 0x003FAA2D
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F70F RID: 63247 RVA: 0x003FC835 File Offset: 0x003FAA35
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F710 RID: 63248 RVA: 0x003FC83D File Offset: 0x003FAA3D
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600F711 RID: 63249 RVA: 0x003FC845 File Offset: 0x003FAA45
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F712 RID: 63250 RVA: 0x003FC84D File Offset: 0x003FAA4D
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F713 RID: 63251 RVA: 0x003FC855 File Offset: 0x003FAA55
		public override int GetRarity()
		{
			return this.Rarity;
		}
	}
}
