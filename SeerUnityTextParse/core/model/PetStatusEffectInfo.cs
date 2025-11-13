using System;

namespace core.model
{
	// Token: 0x02001961 RID: 6497
	public class PetStatusEffectInfo
	{
		// Token: 0x0600CC34 RID: 52276 RVA: 0x003B4F53 File Offset: 0x003B3153
		public PetStatusEffectInfo()
		{
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x003B4F5B File Offset: 0x003B315B
		public PetStatusEffectInfo(ByteArray data)
		{
			this.type = (int)data.ReadUnsignedInt();
			this.id = (int)data.ReadUnsignedInt();
			this.parm = (int)data.ReadUnsignedInt();
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x003B4F87 File Offset: 0x003B3187
		public void SetData(ByteArray data)
		{
			this.type = data.ReadSignedInt();
			this.id = data.ReadSignedInt();
			this.parm = data.ReadSignedInt();
		}

		// Token: 0x0400E27B RID: 57979
		public int type;

		// Token: 0x0400E27C RID: 57980
		public int id;

		// Token: 0x0400E27D RID: 57981
		public int parm;

		// Token: 0x0400E27E RID: 57982
		public string name;

		// Token: 0x0400E27F RID: 57983
		public string des;

		// Token: 0x0400E280 RID: 57984
		public bool isShow;
	}
}
