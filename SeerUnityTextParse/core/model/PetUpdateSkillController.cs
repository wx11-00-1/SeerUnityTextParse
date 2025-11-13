using System;
using System.Collections.Generic;
using common;
using core.manager;
//using Cysharp.Threading.Tasks;

namespace core.model
{
	// Token: 0x02001968 RID: 6504
	public class PetUpdateSkillController
	{
		// Token: 0x0600CC52 RID: 52306 RVA: 0x003B5686 File Offset: 0x003B3886
		public void setup(PetUpdateSkillInfo data)
		{
			this.m_InfoArray.AddRange(data.infoArray);
			if (this.m_InfoArray.Count > 0)
			{
				this.show();
				return;
			}
			//ResetableSingleTon<PetManager>.Ins.updateBagInfo(null).Forget();
		}


		// Token: 0x0600CC54 RID: 52308 RVA: 0x003B56C6 File Offset: 0x003B38C6
		private void loop()
		{
			if (this.m_InfoArray.Count > 0)
			{
				this.show();
				return;
			}
			//ResetableSingleTon<PetManager>.Ins.updateBagInfo(null).Forget();
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x003B56ED File Offset: 0x003B38ED
		private void show()
		{
			if (!this.canShow)
			{
				return;
			}
			UpdateSkillInfo info = this.m_InfoArray[0];
			this.m_InfoArray.RemoveAt(0);
			//UpdateSkillManager.update(info, new Action(this.loop));
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x003B5721 File Offset: 0x003B3921
		public void pauseShow()
		{
			this.canShow = false;
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x003B572A File Offset: 0x003B392A
		public void resumeShow()
		{
			this.canShow = true;
			if (this.m_InfoArray.Count > 0)
			{
				this.show();
			}
		}

		// Token: 0x0400E2AD RID: 58029
		private List<UpdateSkillInfo> m_InfoArray = new List<UpdateSkillInfo>();

		// Token: 0x0400E2AE RID: 58030
		private bool canShow = true;
	}
}
