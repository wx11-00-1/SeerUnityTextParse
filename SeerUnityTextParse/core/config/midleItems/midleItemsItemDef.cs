using System;

namespace core.config.midleItems
{
	// Token: 0x02001FC8 RID: 8136
	public class midleItemsItemDef
	{
		// Token: 0x0600F542 RID: 62786 RVA: 0x003FAA80 File Offset: 0x003F8C80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F360 RID: 62304
		public int ID;

		// Token: 0x0400F361 RID: 62305
		public string Name;

		// Token: 0x0400F362 RID: 62306
		public int Max;

		// Token: 0x0400F363 RID: 62307
		public int catID;
	}
}
