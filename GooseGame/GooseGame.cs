using System;
using System.Collections.Generic;

namespace GooseGame
{
    public class GooseGame
    {
        private readonly Dictionary<int, ISpace> _specialSpaces = new Dictionary<int, ISpace>
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

        public string GetSpaceText(in int spaceIndex)
        {
            return CreateInstance(spaceIndex).GetText(spaceIndex);
        }

        public void PrintSpace(in int spaceIndex)
        {
            Console.Out.WriteLine(GetSpaceText(spaceIndex));
        }

        private ISpace CreateInstance(int spaceIndex)
        {
            return GetSpecial(Math.Min(spaceIndex, 64)) ??
                   GetJump(spaceIndex) ??
                   new SpaceRegular();
        }

        private ISpace GetJump(in int spaceIndex)
        {
            return spaceIndex % 6 == 0 ? new SpaceJump() : null;
        }

        private ISpace GetSpecial(int idx)
        {
            return _specialSpaces.ContainsKey(idx) ? _specialSpaces[idx] : null;
        }
    }
}