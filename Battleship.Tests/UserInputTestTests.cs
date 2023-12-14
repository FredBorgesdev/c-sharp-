using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using NUnit.Framework;
using BattleShip.UI;

namespace Battleship.Tests
{
    [TestFixture]
    class UserInputTestTests
    {
        [TestCase("a2, r", 1, 2)]
        [TestCase("b4, l", 2, 4)]
        [TestCase("c10, d", 3, 10)]
        [TestCase("f9, u", 6, 9)]
        [TestCase("e8, u", 5, 8)]
        [TestCase("g7, u", 7, 7)]
        public void GetRightCoordinator(string location, int x, int y)
        {
            Assert.AreEqual(new Coordinate(x, y), ControlInput.GetLocation(location).Coordinate);
        }


        [TestCase("c12, u")]
        [TestCase("b8, p")]
        [TestCase("dc, l")]
        [TestCase("e11, u")]
        [TestCase("1c, o")]
        [TestCase("e13, v")]
        public void CannotGetLocation(string location)
        {
            Assert.IsNull(ControlInput.GetLocation(location));
        }
                
        [TestCase("r", ShipDirection.Right)]
        [TestCase("l", ShipDirection.Left)]
        [TestCase("d", ShipDirection.Down)]
        [TestCase("u", ShipDirection.Up)]
        public void GetDirection(string direction, ShipDirection expected)
        {
            Assert.AreEqual(expected, ControlInput.getDirection(direction));
        }        
    }
}
