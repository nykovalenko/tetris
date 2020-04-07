using System;
using System.Collections.Generic;
using NUnit.Framework;
using TetrisClient;
using TetrisClient.Enums;
using TetrisClient.Strategies;

namespace Tests.Strategies
{
    [TestFixture]
    public class LevelDetermineStrategyTest
    {
        private LevelDetermineStrategy _levelDetermineStrategy;

        [OneTimeSetUp]
        public void Init()
        {
            _levelDetermineStrategy = new LevelDetermineStrategy();
        }

        [Test]
        public void CheckOnlySquaresLevelDetermination()
        {

            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.YELLOW,
                Element.YELLOW,
                Element.YELLOW,
            };

            foreach (ELevel type in Enum.GetValues(typeof(ELevel)))
            {
                var initialLevel = type;

                for (var i = 0; i < 40; i++)
                {
                    var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
                    Assert.AreEqual((i < 39 ? initialLevel : ELevel.OnlySquares), resultLevel);
                }
            }
        }

        [Test]
        public void CheckOnlySquaresLevelDeterminationAfterLevelRefresh()
        {

            throw new NotImplementedException();

            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.YELLOW,
                Element.YELLOW,
                Element.YELLOW,
            };

            foreach (ELevel type in Enum.GetValues(typeof(ELevel)))
            {
                var initialLevel = type;

                for (var i = 0; i < 40; i++)
                {
                    var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
                    Assert.AreEqual((i < 39 ? initialLevel : ELevel.OnlySquares), resultLevel);
                }
            }
        }

        [Test]
        public void CheckOnlySquaresNumberRefresh()
        {

            foreach (ELevel type in Enum.GetValues(typeof(ELevel)))
            {
                if (type == ELevel.OnlySquares)
                    continue;

                var initialLevel = type;

                for (var i = 0; i < 100; i++)
                {
                    var futureElements = new List<Element>()
                    {
                        Element.YELLOW,
                        Element.YELLOW,
                        Element.YELLOW,
                        (i % 2 == 1) ? Element.YELLOW : Element.BLUE,
                    };

                    var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
                    Assert.AreEqual(initialLevel, resultLevel);
                }
            }
        }

        [Test]
        public void CheckSquaresLinesDetermination()
        {
            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.BLUE,
                Element.YELLOW,
                Element.YELLOW,
            };

            var initialLevel = ELevel.OnlySquares;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.SquaresLines, resultLevel);
        }

        [Test]
        public void CheckSquaresLinesLandJDeterminationWhenL()
        {
            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.BLUE,
                Element.YELLOW,
                Element.CYAN,
            };

            var initialLevel = ELevel.SquaresLines;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.SquaresLinesLandJ, resultLevel);
        }

        [Test]
        public void CheckSquaresLinesLandJDeterminationWhenJ()
        {
            var futureElements = new List<Element>()
            {
                Element.BLUE,
                Element.BLUE,
                Element.YELLOW,
                Element.ORANGE,
            };

            var initialLevel = ELevel.SquaresLines;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.SquaresLinesLandJ, resultLevel);
        }

        [Test]
        public void CheckSquaresLinesLandJDeterminationWhenLAndJ()
        {
            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.BLUE,
                Element.CYAN,
                Element.ORANGE,
            };

            var initialLevel = ELevel.SquaresLines;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.SquaresLinesLandJ, resultLevel);
        }

        [Test]
        public void CheckHighDeterminationWhenS()
        {
            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.BLUE,
                Element.CYAN,
                Element.GREEN,
            };

            var initialLevel = ELevel.SquaresLinesLandJ;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.High, resultLevel);
        }

        [Test]
        public void CheckHighDeterminationWhenZ()
        {
            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.BLUE,
                Element.CYAN,
                Element.RED,
            };

            var initialLevel = ELevel.SquaresLinesLandJ;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.High, resultLevel);
        }

        [Test]
        public void CheckHighDeterminationWhenT()
        {
            var futureElements = new List<Element>()
            {
                Element.YELLOW,
                Element.BLUE,
                Element.CYAN,
                Element.PURPLE,
            };

            var initialLevel = ELevel.SquaresLinesLandJ;

            var resultLevel = _levelDetermineStrategy.GetLevel(initialLevel, futureElements);
            Assert.AreEqual(ELevel.High, resultLevel);
        }
    }
}
