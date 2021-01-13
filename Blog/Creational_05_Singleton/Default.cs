using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_05_Singleton
{
    public class Default
    {
        /// <summary>
        /// Singleton 實體
        /// </summary>
        public class Singleton
        {
            private static Singleton _instance;

            // 建構子通常為 protected or private，避免由外部建立實體
            protected Singleton()
            {
            }

            public static Singleton Instance()
            {
                // 使用延遲載入，此方式並非 thread safe
                return _instance ??= new Singleton();
            }
        }
    }

}
