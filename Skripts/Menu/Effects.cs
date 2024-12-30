using System;
using IsaacGame.Skripts.Menu;

namespace IsaacGame.Skripts.Menu
{
    internal class Effects
    {

        private static bool _up = true;
        private static int _count = 0;




        public static int FadeEffect()
        {
            if (_count < 255 && _up) _count += 2;
            else if (_count > 253) _up = false;

            if (_count > 0 && !_up) _count -= 2;
            else if (_count < 1) _up = true;
            return _count;
        }

        public static int TicEffect()
        {
            if (Random.Shared.Next(300) > 298)
                if (Random.Shared.Next(2) == 1) return 9;
                else return -9;
            return 0;
        }

        public static int OpenEffect(int size , int count) => (count * 90 < size) ? count * 90 : size;

        public static int FPS(int count, int time)
        {

            return 0;
        }






















    }
}
