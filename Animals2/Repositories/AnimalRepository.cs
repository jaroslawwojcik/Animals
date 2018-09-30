using Animals2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals2.Repositories
{
    public class AnimalRepository
    {
        private List<IAnimal> _animals = new List<IAnimal>();

        public void AddAnimalToList(IAnimal animal)
        {
            _animals.Add(animal);
        }

        public List<IAnimal> GetList()
        {
            var animalList = _animals;
            return animalList;
        }
    }
}
