using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class TestAssemblyTests
    {
        private readonly Program _app;

        public TestAssemblyTests()
        {
            _app = new Program
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 50},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETP concert",
                        SellIn = 5,
                        Quality = 50
                    },
                    new Item
                    {
                        Name = "Backstage passes to a D498FJ9FJ2N concert",
                        SellIn = 10,
                        Quality = 30
                    },
                    new Item
                    {
                        Name = "Backstage passes to a FH38F39DJ39 concert",
                        SellIn = 5,
                        Quality = 33
                    },
                    new Item
                    {
                        Name = "Backstage passes to a I293JD92J44 concert",
                        SellIn = 6,
                        Quality = 27
                    },
                    new Item
                    {
                        Name = "Backstage passes to a O2848394820 concert",
                        SellIn = 1,
                        Quality = 13
                    },
                    new Item
                    {
                        Name = "Backstage passes to a DEEEADMEEET concert",
                        SellIn = 0,
                        Quality = 25
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},

                     new Item {Name = "Conjured Mana Cake 2", SellIn = -1, Quality = 3},

                      new Item {Name = "Conjured Mana Cake 3", SellIn = 0, Quality = 6}
                }
            };

            _app.UpdateInventory();
        }

        [Fact]
        public void DexterityVest_Quality_ShouldBeZero()
        {
            Assert.Equal(0, _app.Items.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }

        [Fact]
        public void Backstage_Quality_ShouldBeZero()
        {
            Assert.Equal(0, _app.Items.First(x => x.Name == "Backstage passes to a DEEEADMEEET concert").Quality);
        }

        [Fact]
        public void Backstage_Quality_ShouldIncreaseByThree()
        {
            Assert.Equal(16, _app.Items.First(x => x.Name == "Backstage passes to a O2848394820 concert").Quality);
        }

        [Fact]
        public void Backstage_Quality_ShouldIncreaseByTwo()
        {
            Assert.Equal(29, _app.Items.First(x => x.Name == "Backstage passes to a I293JD92J44 concert").Quality);
        }

        
        [Fact]
        public void Backstage_Quality_ShouldIncreaseByThreeForFiveDays()
        {
            Assert.Equal(36, _app.Items.First(x => x.Name == "Backstage passes to a FH38F39DJ39 concert").Quality);
        }

        
        [Fact]
        public void Backstage_Quality_ShouldIncreaseByTwoForTenDays()
        {
            Assert.Equal(32, _app.Items.First(x => x.Name == "Backstage passes to a D498FJ9FJ2N concert").Quality);
        }

        
        [Fact]
        public void Backstage_Quality_ShouldIncreaseByOne()
        {
            Assert.Equal(21, _app.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETC concert").Quality);
        }

        [Fact]
        public void Conjured_Quality_ShouldDecreaseByTwo()
        {
            Assert.Equal(4, _app.Items.First(x => x.Name == "Conjured Mana Cake").Quality);
        }

        [Fact]
        public void Conjured_Quality_ShouldDecreaseByFour()
        {
            Assert.Equal(0, _app.Items.First(x => x.Name == "Conjured Mana Cake 2").Quality);
        }

        [Fact]
        public void Conjured_Quality_ShouldDecreaseByFourForZeroDays()
        {
            Assert.Equal(2, _app.Items.First(x => x.Name == "Conjured Mana Cake 3").Quality);
        }

        [Fact]
        public void AgedBrie_Quality_ShouldBeFifty()
        {
            Assert.Equal(50, _app.Items.First(x => x.Name == "Aged Brie").Quality);
        }

        [Fact]
        public void Backstage_Quality_ShouldBeFifty()
        {
            Assert.Equal(50, _app.Items.First(x => x.Name == "Backstage passes to a TAFKAL80ETP concert").Quality);
        }
    }
}