using System;
using System.Collections.Generic;

namespace GooseGame
{
    public static class SpaceFactory
    {
        private static readonly Dictionary<int, ISpace> SpecialSpaces = new Dictionary<int, ISpace>
        {
            {6, new SpaceBridge(6)},
            {19, new SpaceHotel()},
            {31, new SpaceWell()},
            {42, new SpaceMaze()},
            {50, new SpacePrison()},
            {51, new SpacePrison()},
            {52, new SpacePrison()},
            {53, new SpacePrison()},
            {54, new SpacePrison()},
            {55, new SpacePrison()},
            {58, new SpaceDeath()},
            {63, new SpaceWon()},
            {64, new SpaceBeyond()}
        };

        public static ISpace CreateInstance(int spaceIndex)
        {
            return GetSpecial(Math.Min(spaceIndex, 64)) ?? GetRegularOrJump(spaceIndex);
        }

        private static ISpace GetSpecial(int idx)
        {
            return SpecialSpaces.ContainsKey(idx) ? SpecialSpaces[idx] : null;
        }

        private static ISpace GetRegularOrJump(in int spaceIndex)
        {
            return spaceIndex % 6 == 0 ? (ISpace) new SpaceJump() : new SpaceRegular();
        }
    }
}