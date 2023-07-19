using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Television
    {
        private int channel;                    // 現在のチャンネル
        private const int ChannelMin = 1;       // チャンネル下限
        private const int ChannelMax = 12;      // チャンネル上限
        private const int VolumeMin = 0;        // 音量下限
        private const int VolumeMax = 40;       // 音量上限

        // プロパティ
        public bool Power { get; private set; } // テレビのON/OFF状態
        public int Volume { get; private set; } // 現在の音量
        public int Channel                      // 現在のチャンネル
        {
            get { return channel; }
            set
            {
                if (value >= ChannelMin && value <= ChannelMax)
                    channel = value;
            }
        }

        // メソッド
        // テレビの電源をON/OFFする
        public void OnOFF()
        {
            if (Power == true)
                Power = false;  // 電源OFF
            else
                Power = true;   // 電源ON
        }

        // チャンネルを+1する
        public void ChannelUP()
        {
            if (Channel < ChannelMax)
                Channel++;
        }

        // チャンネルを-1する
        public void ChannelDown()
        {
            if (Channel > ChannelMin)
                Channel--;
        }

        // 音量を上げる
        public void VolumeUP()
        {
            if (Volume < VolumeMax)
                Volume++;
        }

        // 音量を下げる
        public void VolumeDown()
        {
            if (Volume > VolumeMin)
                Volume--;
        }
    }
}
