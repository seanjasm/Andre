using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pillar_Kata
{
    public class TestClass
    {
        [Theory]
        //inline data test all wanted outputs
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void CheckNumber_FromPRocessDataClass(int nums)
        {
            //pulls process data class and checks the method and injects the above numbers into the method
            //to see if it works
            //same peramiters and testing if outcome is true.
            var actual = ProcessData.CheckNumber(nums);
            Assert.True(actual);
        }

        [Fact]
        //testing one thing and one output
        public void Produce()
        {
            //im expecting the double of 4.39 from the key of "okra"
            double expected = 4.39;
            // we put only okra because the value(okra) automaticly includes the key
            var actual = GroceryProduct.Produce()["Okra"].unitPrice;
            // .equals compares
            Assert.Equal(expected, actual);
        }

        //[Theory]
        //[InlineData("Beets", .50)]
        //[InlineData("Broccoli", .70)]
        //[InlineData("Bag of Carrots", 3.99)]
        //[InlineData("Letttuces", 1.99)]
        //[InlineData("Okra", 4.39)]
        //[InlineData("Sweet Corn	", 4.39)]
        //[InlineData("Watermelon/Melons", 5.28)]
        //[InlineData("Rhubarb", 8.37)]
        //[InlineData("Green Beans", 8.33)]
        //[InlineData("Bokchoy", 7.45)]
        //[InlineData("Mint", .25)]
        //[InlineData("Kohlrabi", 20.00)]
        //[Fact]
        //public void AddToPRoduceKart()
        //{
        //    KartItem list = new KartItem(0,0);
        //    //list.AddItemToKart("Beets", 2);
        //    double expected = 1;
        //    double actual = list.AddItemToKart("Beets", 2);
        //    //Kart.AddProduce("Beets", 2);
        //    Assert.Equal(expected, actual);
        //}
    }
}
