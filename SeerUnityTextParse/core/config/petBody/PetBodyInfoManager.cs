using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using common;

namespace core.config.petBody
{
	public class PetBodyInfoManager : ResetableSingleTon<PetBodyInfoManager>
	{
		public enum PetBodyPositionType
		{
			FullBody = 1,
			Head,
			Prefab
		}

		private Dictionary<PetBodyPositionType, PetBodyInfos> _infos;

		public override void Reset()
		{
			base.Reset();
		}
	}
}
