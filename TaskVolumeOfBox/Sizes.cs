using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVolumeOfBox
{
    class Sizes
    {
        public byte width;
        public byte length;
        public byte height;

        public int CalculateVolume(byte width,byte length, byte height)
        {
            this.width = width;
            this.length = length;
            this.height = height;
            return width * length * height;
        }

    }
}
