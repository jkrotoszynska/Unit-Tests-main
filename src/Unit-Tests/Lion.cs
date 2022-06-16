using System;

namespace Unit_Tests
{
    public class Lion : IAnimal, IMammal, IPredator
    {
        public string animalNoise(){
            string noise = "Roar";
            return noise;
        }

        public bool Hibernate(){
            bool doesHibernate = false;
            return doesHibernate;
        }

        public string Hunt(){
            string hunts = "The lion hunts";
            return hunts;
        }
    }
}