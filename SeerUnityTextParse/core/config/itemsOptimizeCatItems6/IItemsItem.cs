using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems6
{
	// Token: 0x02001FEB RID: 8171
	public class IItemsItem : ItemData
	{
		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x0600F64B RID: 63051 RVA: 0x003FBCF8 File Offset: 0x003F9EF8
		// (set) Token: 0x0600F64C RID: 63052 RVA: 0x003FBD00 File Offset: 0x003F9F00
		public string Name { get; set; }

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600F64D RID: 63053 RVA: 0x003FBD09 File Offset: 0x003F9F09
		// (set) Token: 0x0600F64E RID: 63054 RVA: 0x003FBD11 File Offset: 0x003F9F11
		public int catID { get; set; }

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600F64F RID: 63055 RVA: 0x003FBD1A File Offset: 0x003F9F1A
		// (set) Token: 0x0600F650 RID: 63056 RVA: 0x003FBD22 File Offset: 0x003F9F22
		public int ID { get; set; }

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600F651 RID: 63057 RVA: 0x003FBD2B File Offset: 0x003F9F2B
		// (set) Token: 0x0600F652 RID: 63058 RVA: 0x003FBD33 File Offset: 0x003F9F33
		public int Max { get; set; }

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600F653 RID: 63059 RVA: 0x003FBD3C File Offset: 0x003F9F3C
		// (set) Token: 0x0600F654 RID: 63060 RVA: 0x003FBD44 File Offset: 0x003F9F44
		public int wd { get; set; }

		// Token: 0x0600F655 RID: 63061 RVA: 0x003FBD50 File Offset: 0x003F9F50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F656 RID: 63062 RVA: 0x003FBDA5 File Offset: 0x003F9FA5
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F657 RID: 63063 RVA: 0x003FBDAD File Offset: 0x003F9FAD
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F658 RID: 63064 RVA: 0x003FBDB5 File Offset: 0x003F9FB5
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x003FBDBD File Offset: 0x003F9FBD
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x003FBDC5 File Offset: 0x003F9FC5
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
