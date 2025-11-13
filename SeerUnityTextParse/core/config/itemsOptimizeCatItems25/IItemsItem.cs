using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems25
{
	// Token: 0x02001FF5 RID: 8181
	public class IItemsItem : ItemData
	{
		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600F71B RID: 63259 RVA: 0x003FC8F4 File Offset: 0x003FAAF4
		// (set) Token: 0x0600F71C RID: 63260 RVA: 0x003FC8FC File Offset: 0x003FAAFC
		public string Name { get; set; }

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600F71D RID: 63261 RVA: 0x003FC905 File Offset: 0x003FAB05
		// (set) Token: 0x0600F71E RID: 63262 RVA: 0x003FC90D File Offset: 0x003FAB0D
		public int catID { get; set; }

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600F71F RID: 63263 RVA: 0x003FC916 File Offset: 0x003FAB16
		// (set) Token: 0x0600F720 RID: 63264 RVA: 0x003FC91E File Offset: 0x003FAB1E
		public int Hide { get; set; }

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600F721 RID: 63265 RVA: 0x003FC927 File Offset: 0x003FAB27
		// (set) Token: 0x0600F722 RID: 63266 RVA: 0x003FC92F File Offset: 0x003FAB2F
		public int ID { get; set; }

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600F723 RID: 63267 RVA: 0x003FC938 File Offset: 0x003FAB38
		// (set) Token: 0x0600F724 RID: 63268 RVA: 0x003FC940 File Offset: 0x003FAB40
		public int LifeTime { get; set; }

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600F725 RID: 63269 RVA: 0x003FC949 File Offset: 0x003FAB49
		// (set) Token: 0x0600F726 RID: 63270 RVA: 0x003FC951 File Offset: 0x003FAB51
		public int Max { get; set; }

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x0600F727 RID: 63271 RVA: 0x003FC95A File Offset: 0x003FAB5A
		// (set) Token: 0x0600F728 RID: 63272 RVA: 0x003FC962 File Offset: 0x003FAB62
		public int Rarity { get; set; }

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x0600F729 RID: 63273 RVA: 0x003FC96B File Offset: 0x003FAB6B
		// (set) Token: 0x0600F72A RID: 63274 RVA: 0x003FC973 File Offset: 0x003FAB73
		public int Sort { get; set; }

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x0600F72B RID: 63275 RVA: 0x003FC97C File Offset: 0x003FAB7C
		// (set) Token: 0x0600F72C RID: 63276 RVA: 0x003FC984 File Offset: 0x003FAB84
		public int UseMax { get; set; }

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600F72D RID: 63277 RVA: 0x003FC98D File Offset: 0x003FAB8D
		// (set) Token: 0x0600F72E RID: 63278 RVA: 0x003FC995 File Offset: 0x003FAB95
		public int wd { get; set; }

		// Token: 0x0600F72F RID: 63279 RVA: 0x003FC9A0 File Offset: 0x003FABA0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F730 RID: 63280 RVA: 0x003FCA36 File Offset: 0x003FAC36
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F731 RID: 63281 RVA: 0x003FCA3E File Offset: 0x003FAC3E
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F732 RID: 63282 RVA: 0x003FCA46 File Offset: 0x003FAC46
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x003FCA4E File Offset: 0x003FAC4E
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F734 RID: 63284 RVA: 0x003FCA56 File Offset: 0x003FAC56
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F735 RID: 63285 RVA: 0x003FCA61 File Offset: 0x003FAC61
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0600F736 RID: 63286 RVA: 0x003FCA69 File Offset: 0x003FAC69
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F737 RID: 63287 RVA: 0x003FCA71 File Offset: 0x003FAC71
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600F738 RID: 63288 RVA: 0x003FCA79 File Offset: 0x003FAC79
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F739 RID: 63289 RVA: 0x003FCA81 File Offset: 0x003FAC81
		public override int GetUseMax()
		{
			return this.UseMax;
		}
	}
}
