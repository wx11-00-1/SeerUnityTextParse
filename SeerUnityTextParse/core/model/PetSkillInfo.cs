using System;
using common;
using core.config;

namespace core.model
{
	// Token: 0x0200195E RID: 6494
	public class PetSkillInfo
	{
		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600CC21 RID: 52257 RVA: 0x003B4D4B File Offset: 0x003B2F4B
		// (set) Token: 0x0600CC22 RID: 52258 RVA: 0x003B4D53 File Offset: 0x003B2F53
		public int id
		{
			get
			{
				return this.m_id;
			}
			set
			{
				this.m_id = value;
			}
		}

		// Token: 0x0600CC23 RID: 52259 RVA: 0x003B4D5C File Offset: 0x003B2F5C
		public PetSkillInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.m_id = (int)data.ReadUnsignedInt();
				this.pp = (int)data.ReadUnsignedInt();
			}
			if (this.pp < 0)
			{
				this.pp = 0;
			}
		}

		// Token: 0x0600CC24 RID: 52260 RVA: 0x003B4D8F File Offset: 0x003B2F8F
		public PetSkillInfo(int id)
		{
			this.m_id = id;
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600CC25 RID: 52261 RVA: 0x003B4D9E File Offset: 0x003B2F9E
		// (set) Token: 0x0600CC26 RID: 52262 RVA: 0x003B4DCA File Offset: 0x003B2FCA
		public string name
		{
			get
			{
				if (!string.IsNullOrEmpty(this.m_strName))
				{
					return this.m_strName;
				}
				return ResetableSingleTon<SkillXMLInfo>.Ins.getName(this.m_id, this.skinId);
			}
			set
			{
				this.m_strName = value;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x0600CC27 RID: 52263 RVA: 0x003B4DD4 File Offset: 0x003B2FD4
		// (set) Token: 0x0600CC28 RID: 52264 RVA: 0x003B4DFA File Offset: 0x003B2FFA
		public int maxPP
		{
			get
			{
				return this.m_nMaxPP = ResetableSingleTon<SkillXMLInfo>.Ins.getPP(this.m_id);
			}
			set
			{
				this.m_nMaxPP = value;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x0600CC29 RID: 52265 RVA: 0x003B4E04 File Offset: 0x003B3004
		// (set) Token: 0x0600CC2A RID: 52266 RVA: 0x003B4E2A File Offset: 0x003B302A
		public int damage
		{
			get
			{
				return this.m_nDamge = ResetableSingleTon<SkillXMLInfo>.Ins.getDamage(this.m_id);
			}
			set
			{
				this.m_nDamge = value;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600CC2B RID: 52267 RVA: 0x003B4E33 File Offset: 0x003B3033
		public bool isFullPP
		{
			get
			{
				return this.maxPP <= this.pp;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x0600CC2C RID: 52268 RVA: 0x003B4E46 File Offset: 0x003B3046
		// (set) Token: 0x0600CC2D RID: 52269 RVA: 0x003B4E50 File Offset: 0x003B3050
		//public PetInfo petInfo
		//{
		//	get
		//	{
		//		return this.m_petInfo;
		//	}
		//	set
		//	{
		//		this.m_petInfo = value;
		//		this.skinId = ((this.m_petInfo != null) ? this.m_petInfo.skinId : 0);
		//		this.petId = ((this.m_petInfo != null) ? this.m_petInfo.id : 0);
		//	}
		//}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x0600CC2E RID: 52270 RVA: 0x003B4E9C File Offset: 0x003B309C
		// (set) Token: 0x0600CC2F RID: 52271 RVA: 0x003B4EA4 File Offset: 0x003B30A4
		public int tag
		{
			get
			{
				return this.m_tag;
			}
			set
			{
				this.m_tag = value;
			}
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x003B4EAD File Offset: 0x003B30AD
		public void GetSaveByteArray(ByteArray data)
		{
			data.WriteUnsignedInt((uint)this.id);
			data.WriteUnsignedInt((uint)this.pp);
		}

		// Token: 0x0400E266 RID: 57958
		private int m_id;

		// Token: 0x0400E267 RID: 57959
		private int m_tag;

		// Token: 0x0400E268 RID: 57960
		private int m_nMaxPP;

		// Token: 0x0400E269 RID: 57961
		private int m_nDamge;

		// Token: 0x0400E26A RID: 57962
		private string m_strName;

		// Token: 0x0400E26B RID: 57963
		//public PetInfo m_petInfo;

		// Token: 0x0400E26C RID: 57964
		public int skinId;

		// Token: 0x0400E26D RID: 57965
		public int pp;

		// Token: 0x0400E26E RID: 57966
		public int petId;
	}
}
