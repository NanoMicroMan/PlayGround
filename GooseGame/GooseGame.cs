using System;

namespace GooseGame
{
    public static class GooseGame
    {
        public static string GetSpaceText(in int spaceIndex)
        {
            return SpaceFactory.CreateInstance(spaceIndex).GetText(spaceIndex);
        }

        public static void PrintSpace(in int spaceIndex)
        {
            Console.Out.WriteLine(GetSpaceText(spaceIndex));
        }
    }
}