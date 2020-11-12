namespace GooseGame
{
    public interface ISpace
    {
        string GetText(int spaceIndex);
    }

    public sealed class SpaceRegular : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "Stay in space " + spaceIndex;
        }
    }

    public sealed class SpaceJump : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "Move two spaces forward";
        }
    }

    public sealed class SpaceBridge : ISpace
    {
        private readonly int _bridgeLength;

        public SpaceBridge(int bridgeLength)
        {
            _bridgeLength = bridgeLength;
        }

        public string GetText(int spaceIndex)
        {
            return "The Bridge: Go to space " + (spaceIndex + _bridgeLength);
        }
    }

    public sealed class SpaceHotel : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "The Hotel: Stay for (miss) one turn";
        }
    }

    public sealed class SpacePrison : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "The Maze: Go back to space 39";
        }
    }

    public sealed class SpaceMaze : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "The Prison: Wait until someone comes to release you - they then take your place";
        }
    }

    public sealed class SpaceWell : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "The Well: Wait until someone comes to pull you out - they then take your place";
        }
    }

    public sealed class SpaceWon : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "Finish: you ended the game";
        }
    }

    public sealed class SpaceDeath : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "Death: Return your piece to the beginning - start the game again";
        }
    }

    public sealed class SpaceBeyond : ISpace
    {
        public string GetText(int spaceIndex)
        {
            return "Move to space 53 and stay in prison for two turns";
        }
    }
}