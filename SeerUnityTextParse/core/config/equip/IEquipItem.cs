using System;

namespace core.config.equip
{
	// Token: 0x02002040 RID: 8256
	public class IEquipItem
	{
		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x0600FC21 RID: 64545 RVA: 0x004018EC File Offset: 0x003FFAEC
		// (set) Token: 0x0600FC22 RID: 64546 RVA: 0x004018F4 File Offset: 0x003FFAF4
		public string Desc { get; set; }

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600FC23 RID: 64547 RVA: 0x004018FD File Offset: 0x003FFAFD
		// (set) Token: 0x0600FC24 RID: 64548 RVA: 0x00401905 File Offset: 0x003FFB05
		public string Name { get; set; }

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0600FC25 RID: 64549 RVA: 0x0040190E File Offset: 0x003FFB0E
		// (set) Token: 0x0600FC26 RID: 64550 RVA: 0x00401916 File Offset: 0x003FFB16
		public IRankItem[] Rank { get; set; }

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0600FC27 RID: 64551 RVA: 0x0040191F File Offset: 0x003FFB1F
		// (set) Token: 0x0600FC28 RID: 64552 RVA: 0x00401927 File Offset: 0x003FFB27
		public int ItemID { get; set; }

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x0600FC29 RID: 64553 RVA: 0x00401930 File Offset: 0x003FFB30
		// (set) Token: 0x0600FC2A RID: 64554 RVA: 0x00401938 File Offset: 0x003FFB38
		public int Quality { get; set; }

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x0600FC2B RID: 64555 RVA: 0x00401941 File Offset: 0x003FFB41
		// (set) Token: 0x0600FC2C RID: 64556 RVA: 0x00401949 File Offset: 0x003FFB49
		public int SuitID { get; set; }

		// Token: 0x0600FC2D RID: 64557 RVA: 0x00401954 File Offset: 0x003FFB54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Rank = new IRankItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Rank[i] = new IRankItem();
					this.Rank[i].Parse(bytes, ref byteIndex);
				}
			}
			this.SuitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
