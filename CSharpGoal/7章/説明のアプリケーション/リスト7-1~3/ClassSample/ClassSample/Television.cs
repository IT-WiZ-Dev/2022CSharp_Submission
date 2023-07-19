using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Television
    {
        public bool power;                  // 電源の状態
        public int channel;                 // 現在のチャンネル
        public int volume;                  // 現在の音量
        public const int ChannelMin = 1;    // チャンネル下限
        public const int ChannelMax = 12;   // チャンネル上限
        public const int VolumeMin = 0;     // 音量下限
        public const int VolumeMax = 40;    // 音量上限

        // メソッド
        // テレビの電源をON/OFFする
        public void OnOff()
        {
            if (power == true)
                power = false;  // 電源OFF
            else
                power = true;   // 電源ON
        }

        // チャンネルを設定する
        public void SetChannel(int c)
        {
            if (c >= ChannelMin && c <= ChannelMax)
                channel = c;
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
