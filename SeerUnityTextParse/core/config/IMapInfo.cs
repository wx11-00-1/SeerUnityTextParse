using System;

namespace core.config
{
	// Token: 0x02001D92 RID: 7570
	public class IMapInfo : IConfigItem
	{
		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600DE16 RID: 56854 RVA: 0x003D6500 File Offset: 0x003D4700
		// (set) Token: 0x0600DE17 RID: 56855 RVA: 0x003D6508 File Offset: 0x003D4708
		public string DeviceID { get; set; }

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600DE18 RID: 56856 RVA: 0x003D6511 File Offset: 0x003D4711
		// (set) Token: 0x0600DE19 RID: 56857 RVA: 0x003D6519 File Offset: 0x003D4719
		public string Ename { get; set; }

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x0600DE1A RID: 56858 RVA: 0x003D6522 File Offset: 0x003D4722
		// (set) Token: 0x0600DE1B RID: 56859 RVA: 0x003D652A File Offset: 0x003D472A
		public string name { get; set; }

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x0600DE1C RID: 56860 RVA: 0x003D6533 File Offset: 0x003D4733
		// (set) Token: 0x0600DE1D RID: 56861 RVA: 0x003D653B File Offset: 0x003D473B
		public string sound { get; set; }

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600DE1E RID: 56862 RVA: 0x003D6544 File Offset: 0x003D4744
		// (set) Token: 0x0600DE1F RID: 56863 RVA: 0x003D654C File Offset: 0x003D474C
		public int[] NPCID { get; set; }

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x003D6555 File Offset: 0x003D4755
		// (set) Token: 0x0600DE21 RID: 56865 RVA: 0x003D655D File Offset: 0x003D475D
		public int[] NPCXYZ { get; set; }

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600DE22 RID: 56866 RVA: 0x003D6566 File Offset: 0x003D4766
		// (set) Token: 0x0600DE23 RID: 56867 RVA: 0x003D656E File Offset: 0x003D476E
		public int[] PlayerXYZ { get; set; }

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x0600DE24 RID: 56868 RVA: 0x003D6577 File Offset: 0x003D4777
		// (set) Token: 0x0600DE25 RID: 56869 RVA: 0x003D657F File Offset: 0x003D477F
		public int[] WildBossID { get; set; }

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x0600DE26 RID: 56870 RVA: 0x003D6588 File Offset: 0x003D4788
		// (set) Token: 0x0600DE27 RID: 56871 RVA: 0x003D6590 File Offset: 0x003D4790
		public int[] WildBossPoint { get; set; }

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x0600DE28 RID: 56872 RVA: 0x003D6599 File Offset: 0x003D4799
		// (set) Token: 0x0600DE29 RID: 56873 RVA: 0x003D65A1 File Offset: 0x003D47A1
		public int[] WildBossWeight { get; set; }

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x0600DE2A RID: 56874 RVA: 0x003D65AA File Offset: 0x003D47AA
		// (set) Token: 0x0600DE2B RID: 56875 RVA: 0x003D65B2 File Offset: 0x003D47B2
		public int enterMap { get; set; }

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x0600DE2C RID: 56876 RVA: 0x003D65BB File Offset: 0x003D47BB
		// (set) Token: 0x0600DE2D RID: 56877 RVA: 0x003D65C3 File Offset: 0x003D47C3
		public int GroupID { get; set; }

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600DE2E RID: 56878 RVA: 0x003D65CC File Offset: 0x003D47CC
		// (set) Token: 0x0600DE2F RID: 56879 RVA: 0x003D65D4 File Offset: 0x003D47D4
		public int id { get; set; }

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600DE30 RID: 56880 RVA: 0x003D65DD File Offset: 0x003D47DD
		// (set) Token: 0x0600DE31 RID: 56881 RVA: 0x003D65E5 File Offset: 0x003D47E5
		public int MapRatio { get; set; }

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600DE32 RID: 56882 RVA: 0x003D65EE File Offset: 0x003D47EE
		// (set) Token: 0x0600DE33 RID: 56883 RVA: 0x003D65F6 File Offset: 0x003D47F6
		public int pic { get; set; }

		// Token: 0x0600DE34 RID: 56884 RVA: 0x003D6600 File Offset: 0x003D4800
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DeviceID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Ename = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GroupID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MapRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NPCID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.NPCID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NPCXYZ = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.NPCXYZ[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.PlayerXYZ = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.PlayerXYZ[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WildBossID = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.WildBossID[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WildBossPoint = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.WildBossPoint[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WildBossWeight = new int[num6];
				for (int n = 0; n < num6; n++)
				{
					this.WildBossWeight[n] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.enterMap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sound = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
