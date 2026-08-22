using System.Collections.Generic;

namespace core.config
{
	public class ModuleClazzInfo
	{
		public static List<IModuleClazzService> moduleClazzServices = new List<IModuleClazzService>();

		private static bool m_Inited = false;

		public static void addModuleClazzService(IModuleClazzService moduleClazzService)
		{
			if (!moduleClazzServices.Contains(moduleClazzService))
			{
				moduleClazzServices.Add(moduleClazzService);
			}
		}

		public static void InitModuleClazzService()
		{
			if (!m_Inited)
			{
				m_Inited = true;
				addModuleClazzService(new ModuleRegistryService());
			}
		}
	}
}
