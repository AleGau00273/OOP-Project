using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Project_Jonathan_Alex_Abdin;
using System.Text;

namespace LogisticsTests
{
    [TestClass]
    public class Member2Tests
    {

        //Instantiates a Drone and checks its MaxCapacity property.
        //Verifies that the constructor correctly enforces the 5kg limit for drones.
        [TestMethod]
        public void Drone_Limit_ShouldBe5kg()
        {
            Drone drone = new Drone();
            //Assert.AreEqual checks if the actual value matches the expected value (5) in this case.
            Assert.AreEqual(5, drone.MaxCapacity);
        }


        //Instantiates a HeavyDutyHydrogenTruck and checks its MaxCapacity property.
        //Ensures the truck is correctly initialized with its 5000kg limit.
        //which is critical for logistics planning.
        [TestMethod]
        public void Truck_Limit_ShouldBe5000kg()
        {
            HeavydutyHydrogenTruck truck = new HeavydutyHydrogenTruck();
            Assert.AreEqual(5000, truck.MaxCapacity);
        }


        //Attempts to add a 6kg package to a 5kg drone using the '+' operator.
        //This tests the Operator Overloading logic. It ensures an exception is thrown when overloaded, which Alex would
        //then trigger a "Complaint pop up".
        [TestMethod]
        public void OperatorOverload_ShouldThrow_WhenDroneOverloaded()
        {
            Drone drone = new Drone { VehicleID = "DRN-01" };
            Package heavyPack = new Package { Weight = 6.0 };

            
            // This triggers your + operator logic
            //Verifies that the code inside the lambda throws exactly an InvalidOperationException
            Assert.ThrowsExactly<InvalidOperationException>(() =>
            {
                //This triggers the 'public static Vehicle operator +' logic.
                drone = (Drone)(drone + heavyPack);
            });
        }


        //Adds a truck (5000kg) and a drone (5kg) to a list and calls .Sort().
        //Verifies the IComparable implementation. This ensures the fleet can be automatically organized from smallest to largest capacity
        //for better management.
        [TestMethod]
        public void Sorting_ShouldOrderSmallestToLargest()
        {
            var drone = new Drone { MaxCapacity = 5 };
            var truck = new HeavydutyHydrogenTruck { MaxCapacity = 5000 };
            var list = new List<Vehicle> { truck, drone };

            //Act: This calls your custom ComparTo method internally
            list.Sort(); // Uses IComparable

            //Assert: After sorting, the drone (5kg) should be at index 0.
            Assert.AreEqual(5, list[0].MaxCapacity);
        }


        //Calls the load method using two double values (weight, size).
        //Tests Method Overloading. It confirms that the vehicle can update its load using raw numbers instead of a full
        //Package object.
        [TestMethod]
        public void MethodOverloading_LoadsCorrectWeight()
        {
            Drone drone = new Drone();
            //Specifically targets the Load (double weight, double size) version.
            drone.Load(2.5, 1.0); // Uses the double, double overload
            Assert.AreEqual(2.5, drone.CurrentWeightLoad);
        }
    }
}
