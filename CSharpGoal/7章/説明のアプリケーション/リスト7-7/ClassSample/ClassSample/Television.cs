using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Television
    {
        private bool power;                 // 電源の状態
        private int channel;                // 現在のチャンネル
        private int volume;                 // 現在の音量
        private const int ChannelMin = 1;   // チャンネル下限
        private const int ChannelMax = 12;  // チャンネル上限
        private const int VolumeMin = 0;    // 音量下限
        private const int VolumeMax = 40;   // 音量上限

        // プロパティ
        public bool Power
        {
            get { return power; }
        }
        public int Channel
        {
            get { return channel; }
            set
            {
                if (value >= ChannelMin && value <= ChannelMax)
                    channel = value;
            }
        }
        public int Volume
        {
            get { return volume; }
        }

        // メソッド
        // テレビの電源をON/OFFする
        public void OnOFF()
        {
            if (power == true)
                power = false;  // 電源OFF
            else
                power = true;   // 電源ON
        }

        // チャンネルを+1する
        public void ChannelUP()
        {
            if (channel < ChannelMax)
                channel++;
        }

        // チャンネルを-1する
        public void ChannelDown()
        {
            if (channel > ChannelMin)
                channel--;
        }

        // 音量を上げる
        public void VolumeUP()
        {
            if (volume < VolumeMax)
                volume++;
        }

        // 音量を下げる
        public void VolumeDown()
        {
            if (volume > VolumeMin)
                volume--;
        }
    }
}
