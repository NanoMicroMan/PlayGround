using System.Collections.Generic;
using NUnit.Framework;

namespace GooseGameTest
{
    public class Tests
    {
        private readonly Dictionary<int, string> _testTexts = new Dictionary<int, string>
        {
            {6, "The Bridge: Go to space 12"},
            {12, "Move two spaces forward"},
            {13, "Stay in space 13"},
            {19, "The Hotel: Stay for (miss) one turn"},
            {30, "Move two spaces forward"},
            {31, "The Well: Wait until someone comes to pull you out - they then take your place"},
            {42, "The Prison: Wait until someone comes to release you - they then take your place"},
            {49, "Stay in space 49"},
            {50, "The Maze: Go back to space 39"},
            {55, "The Maze: Go back to space 39"},
            {56, "Stay in space 56"},
            {58, "Death: Return your piece to the beginning - start the game again"},
            {63, "Finish: you ended the game"},
            {88, "Move to space 53 and stay in prison for two turns"}
        };

        private GooseGame.GooseGame _game;

        [SetUp]
        public void Setup()
        {
            _game = new GooseGame.GooseGame();
        }

        [Test]
        public void TestTexts()
        {
            foreach (var (key, value) in _testTexts)
                Assert.AreEqual(value, _game.GetSpaceText(key), "Strings differ at space index: " + key);
        }
    }
}