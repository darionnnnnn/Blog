using System;

namespace Structural_03_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default

            // // 樹狀結構
            // // 建立根目錄
            // Default.Composite root = new Default.Composite("root");
            // root.Add(new Default.Leaf("項目 A"));
            // root.Add(new Default.Leaf("項目 B"));
            //
            // // 建立容器 1
            // Default.Composite composite1 = new Default.Composite("容器 1");
            // composite1.Add(new Default.Leaf("項目 C"));
            // composite1.Add(new Default.Leaf("項目 D"));
            // // 建立容器 2
            // Default.Composite composite2 = new Default.Composite("容器 2");
            // composite2.Add(new Default.Leaf("項目 E"));
            //
            // // 容器 2 加入 容器 1
            // composite1.Add(composite2);
            //
            // // 容器 1 加入根目錄
            // root.Add(composite1);
            // root.Add(new Default.Leaf("項目 F"));
            //
            // Default.Leaf leaf_G = new Default.Leaf("項目 G");
            // root.Add(leaf_G);
            //
            // root.Display(0);
            //
            // Console.WriteLine("\n === 移除 項目 G ===\n");
            //
            // root.Remove(leaf_G);
            // root.Display(0);

            #endregion

            #region Situation

            // 樹狀結構
            // 建立根地區
            Situation.District rootDistrict = new Situation.District("台北市");

            // 建立子地區
            Situation.District districtDaan = new Situation.District("大安區");
            // 建立大安區1
            Situation.District districtDaan1 = new Situation.District("大安區 1");
            districtDaan1.Add(new Situation.Store("門市 A"));
            districtDaan1.Add(new Situation.Store("門市 B"));
            // 建立大安區2
            Situation.District districtDaan2 = new Situation.District("大安區 2");
            districtDaan2.Add(new Situation.Store("門市 C"));
            districtDaan2.Add(new Situation.Store("門市 D"));

            // 大安區1 & 大安區2 加入 大安區
            districtDaan.Add(districtDaan1);
            districtDaan.Add(districtDaan2);

            // 大安區 加入 台北市
            rootDistrict.Add(districtDaan);

            rootDistrict.Display(0);

            #endregion

            Console.ReadLine();
        }
    }
}
