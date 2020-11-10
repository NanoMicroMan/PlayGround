namespace GooseGame
{
    public interface ISpace
    {
        string GetText(int spaceIndex);
    }

    public class SpaceRegular : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "Stay in space " + spaceIndex;
        }
    }

    public class SpaceJump : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "Move two spaces forward";
        }
    }

    public class SpaceBridge : ISpace
    {
        private readonly int _bridgeLength;

        public SpaceBridge(int bridgeLength)
        {
            _bridgeLength = bridgeLength;
        }

        public virtual string GetText(int spaceIndex)
        {
            return "The Bridge: Go to space " + (spaceIndex + _bridgeLength);
        }
    }

    public class SpaceHotel : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "The Hotel: Stay for (miss) one turn";
        }
    }

    public class SpacePrison : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "The Maze: Go back to space 39";
        }
    }

    public class SpaceMaze : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "The Prison: Wait until someone comes to release you - they then take your place";
        }
    }

    public class SpaceWell : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "The Well: Wait until someone comes to pull you out - they then take your place";
        }
    }

    public class SpaceWon : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "Finish: you ended the game";
        }
    }

    public class SpaceDeath : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "Death: Return your piece to the beginning - start the game again";
        }
    }

    public class SpaceBeyond : ISpace
    {
        public virtual string GetText(int spaceIndex)
        {
            return "Move to space 53 and stay in prison for two turns";
        }
    }
}