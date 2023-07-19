using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{

    // 電気製品クラス
    class ElectronicProducts
    {
        // コンストラクター
        public ElectronicProducts()
        {
            Power = false;
        }
        public ElectronicProducts(bool power)
        {
            Power = power;
        }

        // プロパティ
        public bool Power { get; private set; } // 電源の状態

        // メソッド
        // 電源をON/OFFする
        public void OnOff()
        {
            if (Power == true)
                Power = false;      // 電源OFF
            else
                Power = true;       // 電源ON
        }
    }
}
